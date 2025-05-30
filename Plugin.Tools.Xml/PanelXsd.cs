﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using SAL.Windows;

namespace Plugin.Tools.Xml
{
	/// <summary>Окно тестирования и создания XSD схемы из XML</summary>
	public partial class PanelXsd : UserControl
	{
		private Plugin Plugin => (Plugin)this.Window.Plugin;
		private IWindow Window => (IWindow)base.Parent;

		/// <summary>Создание экземпляра окна тестирования XSD</summary>
		public PanelXsd()
			=> InitializeComponent();

		/// <summary>Событие при завершении инициализации элемента управления</summary>
		protected override void OnCreateControl()
		{
			this.Window.Caption = "XSD Test";
			this.Window.SetDockAreas(DockAreas.DockBottom | DockAreas.DockLeft | DockAreas.DockRight | DockAreas.DockTop | DockAreas.Float);

			base.OnCreateControl();
		}

		private void tsbnGenerate_Click(Object sender, EventArgs e)
		{
			String xml = txtXml.Text;
			txtXsd.Text = this.Plugin.GenerateXsd(xml);
		}

		private void tsbnCheck_Click(Object sender, EventArgs e)
		{
			String xml = txtXml.Text;
			String xsd = txtXsd.Text;

			this.Plugin.ValidateXmlByXsd(xml, xsd);
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

		private void TextBox_TextChanged(Object sender, EventArgs e)
		{
			tsbnCheck.Enabled = !txtXml.IsEmpty && !txtXsd.IsEmpty;
			tsbnGenerate.Enabled = !txtXml.IsEmpty;
		}
	}
}