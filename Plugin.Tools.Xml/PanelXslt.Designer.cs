namespace Plugin.Tools.Xml
{
	partial class PanelXslt
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
			this.tsbnApply = new System.Windows.Forms.ToolStripButton();
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.splitInput = new System.Windows.Forms.SplitContainer();
			this.txtXslt = new AlphaOmega.Windows.Forms.DefaultTextBox();
			this.txtXml = new AlphaOmega.Windows.Forms.DefaultTextBox();
			this.txtOutput = new System.Windows.Forms.TextBox();
			tsMain = new System.Windows.Forms.ToolStrip();
			tsMain.SuspendLayout();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.Panel2.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.splitInput.Panel1.SuspendLayout();
			this.splitInput.Panel2.SuspendLayout();
			this.splitInput.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsMain
			// 
			tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbnApply});
			tsMain.Location = new System.Drawing.Point(0, 0);
			tsMain.Name = "tsMain";
			tsMain.Size = new System.Drawing.Size(150, 25);
			tsMain.TabIndex = 0;
			// 
			// tsbnApply
			// 
			this.tsbnApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbnApply.Image = global::Plugin.Tools.Xml.Properties.Resources.iconDebug;
			this.tsbnApply.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbnApply.Name = "tsbnApply";
			this.tsbnApply.Size = new System.Drawing.Size(23, 22);
			this.tsbnApply.Text = "Apply";
			this.tsbnApply.Click += new System.EventHandler(this.tsbnApply_Click);
			// 
			// splitMain
			// 
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.Location = new System.Drawing.Point(0, 25);
			this.splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.splitInput);
			// 
			// splitMain.Panel2
			// 
			this.splitMain.Panel2.Controls.Add(this.txtOutput);
			this.splitMain.Size = new System.Drawing.Size(150, 125);
			this.splitMain.SplitterDistance = 90;
			this.splitMain.TabIndex = 1;
			// 
			// splitInput
			// 
			this.splitInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitInput.Location = new System.Drawing.Point(0, 0);
			this.splitInput.Name = "splitInput";
			this.splitInput.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitInput.Panel1
			// 
			this.splitInput.Panel1.Controls.Add(this.txtXslt);
			// 
			// splitInput.Panel2
			// 
			this.splitInput.Panel2.Controls.Add(this.txtXml);
			this.splitInput.Size = new System.Drawing.Size(90, 125);
			this.splitInput.SplitterDistance = 53;
			this.splitInput.TabIndex = 0;
			// 
			// txtXslt
			// 
			this.txtXslt.PlaceHolderText = "XSLT";
			this.txtXslt.AcceptsReturn = true;
			this.txtXslt.AcceptsTab = true;
			this.txtXslt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtXslt.Location = new System.Drawing.Point(0, 0);
			this.txtXslt.Multiline = true;
			this.txtXslt.Name = "txtXslt";
			this.txtXslt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtXslt.Size = new System.Drawing.Size(90, 53);
			this.txtXslt.TabIndex = 0;
			this.txtXslt.WordWrap = false;
			this.txtXslt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			// 
			// txtXml
			// 
			this.txtXml.PlaceHolderText = "XML";
			this.txtXml.AcceptsReturn = true;
			this.txtXml.AcceptsTab = true;
			this.txtXml.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtXml.Location = new System.Drawing.Point(0, 0);
			this.txtXml.Multiline = true;
			this.txtXml.Name = "txtXml";
			this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtXml.Size = new System.Drawing.Size(90, 68);
			this.txtXml.TabIndex = 0;
			this.txtXml.WordWrap = false;
			this.txtXml.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			// 
			// txtOutput
			// 
			this.txtOutput.AcceptsReturn = true;
			this.txtOutput.AcceptsTab = true;
			this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutput.ForeColor = System.Drawing.SystemColors.GrayText;
			this.txtOutput.Location = new System.Drawing.Point(0, 0);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOutput.Size = new System.Drawing.Size(56, 125);
			this.txtOutput.TabIndex = 0;
			this.txtOutput.Text = "Empty";
			this.txtOutput.WordWrap = false;
			this.txtOutput.Enter += new System.EventHandler(this.txtOutput_Enter);
			this.txtOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			this.txtOutput.Leave += new System.EventHandler(this.txtOutput_Leave);
			// 
			// PanelXslt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitMain);
			this.Controls.Add(tsMain);
			this.Name = "PanelXslt";
			tsMain.ResumeLayout(false);
			tsMain.PerformLayout();
			this.splitMain.Panel1.ResumeLayout(false);
			this.splitMain.Panel2.ResumeLayout(false);
			this.splitMain.Panel2.PerformLayout();
			this.splitMain.ResumeLayout(false);
			this.splitInput.Panel1.ResumeLayout(false);
			this.splitInput.Panel1.PerformLayout();
			this.splitInput.Panel2.ResumeLayout(false);
			this.splitInput.Panel2.PerformLayout();
			this.splitInput.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitMain;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.ToolStripButton tsbnApply;
		private System.Windows.Forms.SplitContainer splitInput;
		private AlphaOmega.Windows.Forms.DefaultTextBox txtXslt;
		private AlphaOmega.Windows.Forms.DefaultTextBox txtXml;

	}
}
