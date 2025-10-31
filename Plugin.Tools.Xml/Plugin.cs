using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;
using SAL.Flatbed;
using SAL.Windows;

namespace Plugin.Tools.Xml
{
	/// <summary>Initial entry point for SAL plugins communication</summary>
	public class Plugin : IPlugin, IPluginSettings<PluginSettings>
	{
		private readonly IHost _host;
		private PluginSettings _settings;
		private TraceSource _trace;
		private Dictionary<String, DockState> _documentTypes;

		internal TraceSource Trace => this._trace ?? (this._trace = Plugin.CreateTraceSource<Plugin>());

		internal IHostWindows HostWindows => this._host as IHostWindows;

		/// <summary>Settings for interaction from the host</summary>
		Object IPluginSettings.Settings => this.Settings;

		/// <summary>Settings for interaction from the plugin</summary>
		public PluginSettings Settings
		{
			get
			{
				if(this._settings == null)
				{
					this._settings = new PluginSettings();
					this._host.Plugins.Settings(this).LoadAssemblyParameters(this._settings);
				}
				return this._settings;
			}
		}

		private IMenuItem XmlMenu { get; set; }

		private IMenuItem XsltMenu { get; set; }

		private IMenuItem XPathMenu { get; set; }

		private IMenuItem XsdMenu { get; set; }

		private Dictionary<String, DockState> DocumentTypes
		{
			get
			{
				if(this._documentTypes == null)
					this._documentTypes = new Dictionary<String, DockState>()
					{
						{ typeof(PanelXslt).ToString(), DockState.DockRightAutoHide },
						{ typeof(PanelXPath).ToString(), DockState.DockRightAutoHide },
						{ typeof(PanelXsd).ToString(), DockState.DockRightAutoHide },
					};
				return this._documentTypes;
			}
		}

		/// <summary>Create instance of the Plugin host ans specify IHost as the bridge between other plugins</summary>
		/// <param name="host">Plugin loader initiator</param>
		public Plugin(IHost host)
			=> this._host = host ?? throw new ArgumentNullException(nameof(host));

		/// <summary>Get <see cref="IWindow" /> by name, which is available in the plugin</summary>
		/// <param name="typeName">Window type to get from the plugin</param>
		/// <param name="args">Arguments passed to the window</param>
		/// <returns>Reference to the created window</returns>
		public IWindow GetPluginControl(String typeName, Object args)
			=> this.CreateWindow(typeName, false, args);

		/// <summary>Transform XML to XSLT</summary>
		/// <param name="xml">Input XML</param>
		/// <param name="xslt">XSLT Template</param>
		/// <exception cref="ArgumentNullException"><paramref name="xslt"/> is required argument</exception>
		/// <returns>Transformation Result</returns>
		public String ApplyXslt(String xml, String xslt)
		{
			if(String.IsNullOrEmpty(xslt))
				throw new ArgumentNullException(nameof(xslt));

			using(StringReader xslReader = new StringReader(xslt))
			{
				XslCompiledTransform transform = new XslCompiledTransform();
				transform.Load(new XmlTextReader(xslReader));

				using(StringReader xmlReader = new StringReader(xml))
				using(MemoryStream stream = new MemoryStream())
				{
					transform.Transform(XmlReader.Create(xmlReader), null, stream);
					stream.Seek(0, SeekOrigin.Begin);
					using(StreamReader result = new StreamReader(stream))
						return result.ReadToEnd();
				}
			}
		}

		/// <summary>Apply XPath to XML content and get the response</summary>
		/// <param name="xml">Incoming XML</param>
		/// <param name="xpath">XPath selector</param>
		/// <exception cref="ArgumentNullException">xpath is a required argument</exception>
		/// <returns>Selection result</returns>
		public String ApplyXPath(String xml, String xpath)
		{
			if(String.IsNullOrEmpty(xpath))
				throw new ArgumentNullException(nameof(xpath));

			XmlDocument document = new XmlDocument();
			document.LoadXml(xml);
			XmlNodeList nodes = document.SelectNodes(xpath);

			using(StringWriter stringWriter = new StringWriter())
			using(XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter)
			{
				Formatting = Formatting.Indented,
				Indentation = 0,
				IndentChar = '\t',
			})
			{
				foreach(XmlNode node in nodes)
					node.WriteTo(xmlWriter);

				return stringWriter.ToString();
			}
		}

		/// <summary>Generate XML Schema Definition from XML data file</summary>
		/// <param name="xml">Input XML</param>
		/// <returns>Output XSD</returns>
		public String GenerateXsd(String xml)
		{
			if(String.IsNullOrEmpty(xml))
				throw new ArgumentNullException(nameof(xml));

			using(Stream stream = Plugin.CreateStream(xml))
			{
				XmlReader reader = XmlReader.Create(stream);
				XmlSchemaInference schema = new XmlSchemaInference();
				XmlSchemaSet schemaSet = schema.InferSchema(reader);

				XmlWriterSettings settings = new XmlWriterSettings()
				{
					Encoding = Encoding.UTF8,
					IndentChars = "\t",
				};
				using(StringWriter writer = new StringWriter())
				using(XmlWriter xmlWriter = XmlWriter.Create(writer, settings))
				{
					foreach(XmlSchema s in schemaSet.Schemas())
						s.Write(writer);

					return writer.ToString();
				}
			}
		}

		/// <summary>Validate XML text by XSD</summary>
		/// <param name="xml">XML data</param>
		/// <param name="xsd">XSD validator</param>
		public void ValidateXmlByXsd(String xml, String xsd)
		{
			if(String.IsNullOrEmpty(xml))
				throw new ArgumentNullException(nameof(xml));
			if(String.IsNullOrEmpty(xsd))
				throw new ArgumentNullException(nameof(xsd));

			using(Stream xsdStream = Plugin.CreateStream(xsd))
			{
				XmlReader xsdReader = XmlReader.Create(xsdStream);
				XmlReaderSettings settings = new XmlReaderSettings()
				{
					ValidationType = ValidationType.Schema,
					CheckCharacters = false,//Check Encoding
				};
				settings.Schemas.Add(null, xsdReader);

				using(Stream xmlStream = Plugin.CreateStream(xml))
				{
					XmlReader xmlReader = XmlReader.Create(xmlStream, settings);
					XmlDocument document = new XmlDocument();
					document.Load(xmlReader);
				}
			}
		}

		Boolean IPlugin.OnConnection(ConnectMode mode)
		{
			IHostWindows host = this.HostWindows;
			if(host == null)
			{
				this.Trace.TraceInformation("Plugin {0} requires {1}", this, typeof(IHostWindows));
				return true;
			}

			IMenuItem menuTools = host.MainMenu.FindMenuItem("Tools");
			if(menuTools == null)
			{
				this.Trace.TraceInformation("Menu item 'Tools' not found");
				return true;
			}

			this.XmlMenu = menuTools.FindMenuItem("XML");
			if(this.XmlMenu == null)
			{
				this.XmlMenu = menuTools.Create("XML");
				this.XmlMenu.Name = "Tools.XML";
			}

			this.XsltMenu = this.XmlMenu.Create("XSL&T");
			this.XsltMenu.Name = "Tools.XML.Xslt";
			this.XsltMenu.Click += (sender, e) => this.CreateWindow(typeof(PanelXslt).ToString(), false);

			this.XPathMenu = this.XmlMenu.Create("X&Path");
			this.XPathMenu.Name = "Tools.XML.XPath";
			this.XPathMenu.Click += (sender, e) => this.CreateWindow(typeof(PanelXPath).ToString(), false);

			this.XsdMenu = this.XmlMenu.Create("XS&D");
			this.XsdMenu.Name = "Tools.XML.XSD";
			this.XsdMenu.Click += (sender, e) => this.CreateWindow(typeof(PanelXsd).ToString(), false);

			this.XmlMenu.Items.Add(this.XsltMenu);
			this.XmlMenu.Items.Add(this.XPathMenu);
			this.XmlMenu.Items.Add(this.XsdMenu);

			menuTools.Items.Add(this.XmlMenu);

			return true;
		}

		Boolean IPlugin.OnDisconnection(DisconnectMode mode)
		{
			if(this.XPathMenu != null)
				this.HostWindows.MainMenu.Items.Remove(this.XPathMenu);
			if(this.XsltMenu != null)
				this.HostWindows.MainMenu.Items.Remove(this.XsltMenu);
			if(this.XsdMenu != null)
				this.HostWindows.MainMenu.Items.Remove(this.XsdMenu);
			if(this.XmlMenu != null)
				this.HostWindows.MainMenu.Items.Remove(this.XmlMenu);
			return true;
		}

		private IWindow CreateWindow(String typeName, Boolean searchForOpened, Object args = null)
		{
			DockState state;
			return this.DocumentTypes.TryGetValue(typeName, out state)
				? this.HostWindows.Windows.CreateWindow(this, typeName, searchForOpened, state, args)
				: null;
		}

		private static TraceSource CreateTraceSource<T>(String name = null) where T : IPlugin
		{
			TraceSource result = new TraceSource(typeof(T).Assembly.GetName().Name + name);
			result.Switch.Level = SourceLevels.All;
			result.Listeners.Remove("Default");
			result.Listeners.AddRange(System.Diagnostics.Trace.Listeners);
			return result;
		}

		private static Stream CreateStream(String text)
		{
			MemoryStream stream = new MemoryStream();
			StreamWriter writer = new StreamWriter(stream);
			writer.Write(text);
			writer.Flush();
			stream.Position = 0;
			return stream;
		}
	}
}