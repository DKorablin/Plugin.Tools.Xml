using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace Plugin.Tools.Xml
{
	/// <summary>Внешние настройки плагина</summary>
	public class PluginSettings
	{
		private String[] _mruXPath;
		/// <summary>XML по умолчанию, который подставляется для теста</summary>
		[Category("General")]
		[Description("Default XML for tesing")]
		[DisplayName("XML")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public String DefaultXml { get; set; }

		/// <summary>Most Rescent used XPath's</summary>
		[Category("General")]
		[Description("Most rescent used XPath's")]
		[DisplayName("XPath MRU")]
		public String MruXPathString
		{
			get => this.MruXPath == null || this.MruXPath.Length == 0
				? null
				: String.Join(";", this.MruXPath);
			set => this.MruXPath = value?.Split(';');
		}

		/// <summary>Most Rescent used XPath's</summary>
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
				return;//И так в топе
			else if(index == -1)
			{//Не найден, необходимо уменьшить список до 10 элементов
				while(mru.Count > 10)
					mru.RemoveAt(9);
				mru.Insert(0, xpath);
			}
			else
			{//Найден не в топе, необходимо перенести в топ
				mru.RemoveAt(index);
				mru.Insert(0, xpath);
			}
			this.MruXPath = mru.ToArray();
		}
	}
}