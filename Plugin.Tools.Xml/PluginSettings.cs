using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace Plugin.Tools.Xml
{
	/// <summary>External plugin settings</summary>
	public class PluginSettings
	{
		private String[] _mruXPath;
		/// <summary>Default XML that is substituted for the test</summary>
		[Category("General")]
		[Description("Default XML for testing")]
		[DisplayName("XML")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public String DefaultXml { get; set; }

		/// <summary>Most Recent used XPath's</summary>
		[Category("General")]
		[Description("Most recent used XPath's")]
		[DisplayName("XPath MRU")]
		public String MruXPathString
		{
			get => this.MruXPath == null || this.MruXPath.Length == 0
				? null
				: String.Join(";", this.MruXPath);
			set => this.MruXPath = value?.Split(';');
		}

		/// <summary>Most Recent used XPath's</summary>
		internal String[] MruXPath
		{
			get => this._mruXPath;
			set => this._mruXPath = value == null || value.Length == 0
				? null
				: value;
		}

		internal void AddXPathToMru(String xpath)
		{
			List<String> mru = this.MruXPath == null
				? new List<String>(1)
				: new List<String>(this.MruXPath);

			Int32 index = mru.IndexOf(xpath);
			if(index == 0)
				return;//And so at the top
			else if(index == -1)
			{//Not found, need to reduce list to 10 items
				while(mru.Count > 10)
					mru.RemoveAt(9);
				mru.Insert(0, xpath);
			}
			else
			{//Found not in the top, needs to be moved to the top
				mru.RemoveAt(index);
				mru.Insert(0, xpath);
			}
			this.MruXPath = mru.ToArray();
		}
	}
}