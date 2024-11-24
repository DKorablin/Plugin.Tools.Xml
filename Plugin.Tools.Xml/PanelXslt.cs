using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using SAL.Windows;
using System.Drawing;

namespace Plugin.Tools.Xml
{
	/// <summary>Окно теста XSLT</summary>
	public partial class PanelXslt : UserControl
	{
		private Plugin Plugin => (Plugin)this.Window.Plugin;
		private IWindow Window => (IWindow)base.Parent;

		/// <summary>Создание экземпляра окна теста XSLT</summary>
		public PanelXslt()
			=> InitializeComponent();

		/// <summary>Событие при завершении инициализации элемента управления</summary>
		protected override void OnCreateControl()
		{
			this.Window.Caption = "XSLT Tester";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Float);

			if(this.Plugin.Settings.DefaultXml != null)
				txtXml.Text = this.Plugin.Settings.DefaultXml;

			base.OnCreateControl();
		}

		private void tsbnApply_Click(Object sender, EventArgs e)
		{
			String xml = txtXml.Text;
			String xslt = txtXslt.Text;

			txtOutput.Text = this.Plugin.ApplyXslt(xml, xslt);
			this.txtOutput_Leave(sender, e);

			this.Plugin.Settings.DefaultXml = xml;
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
	}
}