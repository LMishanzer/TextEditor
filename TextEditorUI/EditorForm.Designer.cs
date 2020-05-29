namespace TextEditorUI
{
    partial class EditorForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.editFont = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSize = new System.Windows.Forms.ToolStripMenuItem();
            this.biggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textField = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.charCountText = new System.Windows.Forms.ToolStripStatusLabel();
            this.charCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editFile,
            this.editFont});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(100, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuBar";
            // 
            // editFile
            // 
            this.editFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpen,
            this.fileSave,
            this.fileSaveAs});
            this.editFile.Name = "editFile";
            this.editFile.Size = new System.Drawing.Size(46, 24);
            this.editFile.Text = "File";
            // 
            // fileOpen
            // 
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(224, 26);
            this.fileOpen.Text = "Open";
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.Size = new System.Drawing.Size(224, 26);
            this.fileSave.Text = "Save";
            // 
            // fileSaveAs
            // 
            this.fileSaveAs.Name = "fileSaveAs";
            this.fileSaveAs.Size = new System.Drawing.Size(224, 26);
            this.fileSaveAs.Text = "Save as...";
            // 
            // editFont
            // 
            this.editFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontStyle,
            this.fontSize});
            this.editFont.Name = "editFont";
            this.editFont.Size = new System.Drawing.Size(52, 24);
            this.editFont.Text = "Font";
            // 
            // fontStyle
            // 
            this.fontStyle.Name = "fontStyle";
            this.fontStyle.Size = new System.Drawing.Size(124, 26);
            this.fontStyle.Text = "Style";
            // 
            // fontSize
            // 
            this.fontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biggerToolStripMenuItem,
            this.smallerToolStripMenuItem});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(124, 26);
            this.fontSize.Text = "Size";
            // 
            // biggerToolStripMenuItem
            // 
            this.biggerToolStripMenuItem.Name = "biggerToolStripMenuItem";
            this.biggerToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.biggerToolStripMenuItem.Text = "Bigger";
            // 
            // smallerToolStripMenuItem
            // 
            this.smallerToolStripMenuItem.Name = "smallerToolStripMenuItem";
            this.smallerToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.smallerToolStripMenuItem.Text = "Smaller";
            // 
            // textField
            // 
            this.textField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textField.Location = new System.Drawing.Point(0, 27);
            this.textField.Multiline = true;
            this.textField.Name = "textField";
            this.textField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textField.Size = new System.Drawing.Size(781, 503);
            this.textField.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charCountText,
            this.charCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 527);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(782, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // charCountText
            // 
            this.charCountText.Name = "charCountText";
            this.charCountText.Size = new System.Drawing.Size(122, 20);
            this.charCountText.Text = "Characters count:";
            // 
            // charCount
            // 
            this.charCount.Name = "charCount";
            this.charCount.Size = new System.Drawing.Size(0, 20);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EditorForm";
            this.Text = "Editor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editFile;
        private System.Windows.Forms.ToolStripMenuItem fileOpen;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripMenuItem editFont;
        private System.Windows.Forms.ToolStripMenuItem fontStyle;
        private System.Windows.Forms.ToolStripMenuItem fontSize;
        private System.Windows.Forms.TextBox textField;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel charCountText;
        private System.Windows.Forms.ToolStripStatusLabel charCount;
        private System.Windows.Forms.ToolStripMenuItem biggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallerToolStripMenuItem;
    }
}

