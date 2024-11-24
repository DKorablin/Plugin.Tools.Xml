namespace Plugin.Tools.Xml
{
	partial class PanelXPath
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
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.tsbnApply = new System.Windows.Forms.ToolStripButton();
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.splitInput = new System.Windows.Forms.SplitContainer();
			this.txtXPath = new AlphaOmega.Windows.Forms.DefaultTextBox();
			this.txtXml = new AlphaOmega.Windows.Forms.DefaultTextBox();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.tsMain.SuspendLayout();
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
			this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbnApply});
			this.tsMain.Location = new System.Drawing.Point(0, 0);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size(150, 25);
			this.tsMain.TabIndex = 0;
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
			this.splitInput.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitInput.IsSplitterFixed = true;
			this.splitInput.Location = new System.Drawing.Point(0, 0);
			this.splitInput.Name = "splitInput";
			this.splitInput.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitInput.Panel1
			// 
			this.splitInput.Panel1.Controls.Add(this.txtXPath);
			this.splitInput.Panel1MinSize = 20;
			// 
			// splitInput.Panel2
			// 
			this.splitInput.Panel2.Controls.Add(this.txtXml);
			this.splitInput.Size = new System.Drawing.Size(90, 125);
			this.splitInput.SplitterDistance = 22;
			this.splitInput.TabIndex = 0;
			// 
			// txtXPath
			// 
			this.txtXPath.PlaceHolderText = "XPath";
			this.txtXPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtXPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtXPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtXPath.Location = new System.Drawing.Point(0, 0);
			this.txtXPath.Name = "txtXPath";
			this.txtXPath.Size = new System.Drawing.Size(90, 20);
			this.txtXPath.TabIndex = 0;
			this.txtXPath.WordWrap = false;
			this.txtXPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
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
			this.txtXml.Size = new System.Drawing.Size(90, 99);
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
			// PanelXPath
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitMain);
			this.Controls.Add(this.tsMain);
			this.Name = "PanelXPath";
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
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
		private AlphaOmega.Windows.Forms.DefaultTextBox txtXPath;
		private AlphaOmega.Windows.Forms.DefaultTextBox txtXml;
		private System.Windows.Forms.ToolStrip tsMain;
	}
}
