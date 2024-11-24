namespace Plugin.Tools.Xml
{
	partial class PanelXsd
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ToolStrip tsMain;
			this.tsbnCheck = new System.Windows.Forms.ToolStripButton();
			this.tsbnGenerate = new System.Windows.Forms.ToolStripButton();
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.txtXml = new  AlphaOmega.Windows.Forms.DefaultTextBox();
			this.txtXsd = new AlphaOmega.Windows.Forms.DefaultTextBox();
			tsMain = new System.Windows.Forms.ToolStrip();
			tsMain.SuspendLayout();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.Panel2.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsMain
			// 
			tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbnCheck,
            this.tsbnGenerate});
			tsMain.Location = new System.Drawing.Point(0, 0);
			tsMain.Name = "tsMain";
			tsMain.Size = new System.Drawing.Size(150, 25);
			tsMain.TabIndex = 0;
			// 
			// tsbnCheck
			// 
			this.tsbnCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbnCheck.Enabled = false;
			this.tsbnCheck.Image = global::Plugin.Tools.Xml.Properties.Resources.iconDebug;
			this.tsbnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbnCheck.Name = "tsbnCheck";
			this.tsbnCheck.Size = new System.Drawing.Size(23, 22);
			this.tsbnCheck.ToolTipText = "Check XML";
			this.tsbnCheck.Click += new System.EventHandler(this.tsbnCheck_Click);
			// 
			// tsbnGenerate
			// 
			this.tsbnGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbnGenerate.Enabled = false;
			this.tsbnGenerate.Image = global::Plugin.Tools.Xml.Properties.Resources.bnXsdGenerate;
			this.tsbnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbnGenerate.Name = "tsbnGenerate";
			this.tsbnGenerate.Size = new System.Drawing.Size(23, 22);
			this.tsbnGenerate.ToolTipText = "Generate XSD";
			this.tsbnGenerate.Click += new System.EventHandler(this.tsbnGenerate_Click);
			// 
			// splitMain
			// 
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.Location = new System.Drawing.Point(0, 25);
			this.splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.txtXml);
			// 
			// splitMain.Panel2
			// 
			this.splitMain.Panel2.Controls.Add(this.txtXsd);
			this.splitMain.Size = new System.Drawing.Size(150, 125);
			this.splitMain.SplitterDistance = 71;
			this.splitMain.TabIndex = 1;
			// 
			// txtXml
			// 
			this.txtXml.AcceptsReturn = true;
			this.txtXml.AcceptsTab = true;
			this.txtXml.DefaultText = "XML";
			this.txtXml.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtXml.ForeColor = System.Drawing.Color.Gray;
			this.txtXml.Location = new System.Drawing.Point(0, 0);
			this.txtXml.MaxLength = 2147483647;
			this.txtXml.Multiline = true;
			this.txtXml.Name = "txtXml";
			this.txtXml.PlaceHolderText = "XML";
			this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtXml.Size = new System.Drawing.Size(71, 125);
			this.txtXml.TabIndex = 0;
			this.txtXml.Text = "XML";
			this.txtXml.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.txtXml.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			// 
			// txtXsd
			// 
			this.txtXsd.AcceptsReturn = true;
			this.txtXsd.AcceptsTab = true;
			this.txtXsd.DefaultText = "XSD";
			this.txtXsd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtXsd.ForeColor = System.Drawing.Color.Gray;
			this.txtXsd.Location = new System.Drawing.Point(0, 0);
			this.txtXsd.MaxLength = 2147483647;
			this.txtXsd.Multiline = true;
			this.txtXsd.Name = "txtXsd";
			this.txtXsd.PlaceHolderText = "XSD";
			this.txtXsd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtXsd.Size = new System.Drawing.Size(75, 125);
			this.txtXsd.TabIndex = 0;
			this.txtXsd.Text = "XSD";
			this.txtXsd.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.txtXsd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			// 
			// PanelXsd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitMain);
			this.Controls.Add(tsMain);
			this.Name = "PanelXsd";
			tsMain.ResumeLayout(false);
			tsMain.PerformLayout();
			this.splitMain.Panel1.ResumeLayout(false);
			this.splitMain.Panel1.PerformLayout();
			this.splitMain.Panel2.ResumeLayout(false);
			this.splitMain.Panel2.PerformLayout();
			this.splitMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitMain;
		private AlphaOmega.Windows.Forms.DefaultTextBox txtXml;
		private AlphaOmega.Windows.Forms.DefaultTextBox txtXsd;
		private System.Windows.Forms.ToolStripButton tsbnCheck;
		private System.Windows.Forms.ToolStripButton tsbnGenerate;

	}
}
