using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using SAL.Windows;
using System.Drawing;

namespace Plugin.Tools.Xml
{
	/// <summary>XPath Test Window</summary>
	public partial class PanelXPath : UserControl
	{
		private Plugin Plugin => (Plugin)this.Window.Plugin;
		private IWindow Window => (IWindow)base.Parent;

		/// <summary>Creating an XPath test instance</summary>
		public PanelXPath()
			=> this.InitializeComponent();

		/// <summary>Event fired when control initialization is complete</summary>
		protected override void OnCreateControl()
		{
			this.Window.Caption = "XPath Tester";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Float);

			if(this.Plugin.Settings.DefaultXml != null)
				txtXml.Text = this.Plugin.Settings.DefaultXml;

			if(this.Plugin.Settings.MruXPath != null)
			{
				txtXPath.AutoCompleteCustomSource = new AutoCompleteStringCollection();
				txtXPath.AutoCompleteCustomSource.AddRange(this.Plugin.Settings.MruXPath);
			}

			base.OnCreateControl();
		}

		private void tsbnApply_Click(Object sender, EventArgs e)
		{
			String xml = txtXml.Text;
			String xpath = txtXPath.Text;

			txtOutput.Text = this.Plugin.ApplyXPath(xml, xpath);
			this.txtOutput_Leave(sender, e);

			this.Plugin.Settings.DefaultXml = xml;
			this.AddXPathToMru(xpath);
		}

		private void TextBox_KeyDown(Object sender, KeyEventArgs e)
		{
			switch(e.KeyData)
			{
			case Keys.A | Keys.Control:
				e.Handled = true;
				((TextBox)sender).SelectAll();
				break;
			}
		}

		private void txtOutput_Enter(Object sender, EventArgs e)
		{
			if(txtOutput.ForeColor == SystemColors.GrayText)
			{
				txtOutput.Text = String.Empty;
				txtOutput.ForeColor = Color.Empty;
			}
		}

		private void txtOutput_Leave(Object sender, EventArgs e)
		{
			String text = txtOutput.Text;
			if(String.IsNullOrEmpty(text))
			{
				txtOutput.ForeColor = SystemColors.GrayText;
				txtOutput.Text = "Empty";
			} else
			{
				txtOutput.ForeColor = Color.Empty;
			}
		}

		private void AddXPathToMru(String xpath)
		{
			if(txtXPath.AutoCompleteCustomSource == null)
				txtXPath.AutoCompleteCustomSource = new AutoCompleteStringCollection();

			Int32 index = txtXPath.AutoCompleteCustomSource.IndexOf(xpath);

			if(index == 0)
				return;
			else if(index == -1)
				txtXPath.AutoCompleteCustomSource.Insert(0, xpath);
			else
			{
				txtXPath.AutoCompleteCustomSource.RemoveAt(index);
				txtXPath.AutoCompleteCustomSource.Insert(0, xpath);
			}

			this.Plugin.Settings.AddXPathToMru(xpath);
			this.Plugin.HostWindows.Plugins.Settings(this.Plugin).SaveAssemblyParameters();
		}
	}
}