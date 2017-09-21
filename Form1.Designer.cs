namespace CodeBeautifier
{
    partial class Form1
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
            this.rtCode = new System.Windows.Forms.RichTextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnBeautify = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRichText = new System.Windows.Forms.TabPage();
            this.tabHtml = new System.Windows.Forms.TabPage();
            this.tabOpts = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckFontBold = new System.Windows.Forms.CheckBox();
            this.ckBackColor = new System.Windows.Forms.CheckBox();
            this.ckColor = new System.Windows.Forms.CheckBox();
            this.ckFontName = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckRootNode = new System.Windows.Forms.CheckBox();
            this.lblRootName = new System.Windows.Forms.Label();
            this.txtRootName = new System.Windows.Forms.TextBox();
            this.txtNodeAttributes = new System.Windows.Forms.TextBox();
            this.lblNodeAttributes = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabRichText.SuspendLayout();
            this.tabHtml.SuspendLayout();
            this.tabOpts.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtCode
            // 
            this.rtCode.AcceptsTab = true;
            this.rtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtCode.Location = new System.Drawing.Point(3, 3);
            this.rtCode.Name = "rtCode";
            this.rtCode.Size = new System.Drawing.Size(546, 310);
            this.rtCode.TabIndex = 0;
            this.rtCode.Text = "";
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(3, 3);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCode.Size = new System.Drawing.Size(546, 310);
            this.txtCode.TabIndex = 1;
            // 
            // btnBeautify
            // 
            this.btnBeautify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBeautify.Location = new System.Drawing.Point(12, 376);
            this.btnBeautify.Name = "btnBeautify";
            this.btnBeautify.Size = new System.Drawing.Size(75, 23);
            this.btnBeautify.TabIndex = 2;
            this.btnBeautify.Text = "&Beautify";
            this.btnBeautify.UseVisualStyleBackColor = true;
            this.btnBeautify.Click += new System.EventHandler(this.btnBeautify_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRichText);
            this.tabControl1.Controls.Add(this.tabHtml);
            this.tabControl1.Controls.Add(this.tabOpts);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 342);
            this.tabControl1.TabIndex = 4;
            // 
            // tabRichText
            // 
            this.tabRichText.Controls.Add(this.rtCode);
            this.tabRichText.Location = new System.Drawing.Point(4, 22);
            this.tabRichText.Name = "tabRichText";
            this.tabRichText.Padding = new System.Windows.Forms.Padding(3);
            this.tabRichText.Size = new System.Drawing.Size(552, 316);
            this.tabRichText.TabIndex = 0;
            this.tabRichText.Text = "Rich Text";
            this.tabRichText.UseVisualStyleBackColor = true;
            // 
            // tabHtml
            // 
            this.tabHtml.Controls.Add(this.txtCode);
            this.tabHtml.Location = new System.Drawing.Point(4, 22);
            this.tabHtml.Name = "tabHtml";
            this.tabHtml.Padding = new System.Windows.Forms.Padding(3);
            this.tabHtml.Size = new System.Drawing.Size(552, 316);
            this.tabHtml.TabIndex = 1;
            this.tabHtml.Text = "Encoded HTML";
            this.tabHtml.UseVisualStyleBackColor = true;
            // 
            // tabOpts
            // 
            this.tabOpts.Controls.Add(this.groupBox2);
            this.tabOpts.Controls.Add(this.groupBox1);
            this.tabOpts.Location = new System.Drawing.Point(4, 22);
            this.tabOpts.Name = "tabOpts";
            this.tabOpts.Size = new System.Drawing.Size(552, 316);
            this.tabOpts.TabIndex = 2;
            this.tabOpts.Text = "Options";
            this.tabOpts.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckFontBold);
            this.groupBox1.Controls.Add(this.ckBackColor);
            this.groupBox1.Controls.Add(this.ckColor);
            this.groupBox1.Controls.Add(this.ckFontName);
            this.groupBox1.Location = new System.Drawing.Point(19, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HTML Format Options";
            // 
            // ckFontBold
            // 
            this.ckFontBold.AutoSize = true;
            this.ckFontBold.Location = new System.Drawing.Point(17, 95);
            this.ckFontBold.Name = "ckFontBold";
            this.ckFontBold.Size = new System.Drawing.Size(71, 17);
            this.ckFontBold.TabIndex = 8;
            this.ckFontBold.Text = "Font Bold";
            this.ckFontBold.UseVisualStyleBackColor = true;
            // 
            // ckBackColor
            // 
            this.ckBackColor.AutoSize = true;
            this.ckBackColor.Location = new System.Drawing.Point(17, 49);
            this.ckBackColor.Name = "ckBackColor";
            this.ckBackColor.Size = new System.Drawing.Size(78, 17);
            this.ckBackColor.TabIndex = 6;
            this.ckBackColor.Text = "Back Color";
            this.ckBackColor.UseVisualStyleBackColor = true;
            // 
            // ckColor
            // 
            this.ckColor.AutoSize = true;
            this.ckColor.Location = new System.Drawing.Point(17, 26);
            this.ckColor.Name = "ckColor";
            this.ckColor.Size = new System.Drawing.Size(50, 17);
            this.ckColor.TabIndex = 5;
            this.ckColor.Text = "Color";
            this.ckColor.UseVisualStyleBackColor = true;
            // 
            // ckFontName
            // 
            this.ckFontName.AutoSize = true;
            this.ckFontName.Location = new System.Drawing.Point(17, 72);
            this.ckFontName.Name = "ckFontName";
            this.ckFontName.Size = new System.Drawing.Size(78, 17);
            this.ckFontName.TabIndex = 7;
            this.ckFontName.Text = "Font Name";
            this.ckFontName.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtNodeAttributes);
            this.groupBox2.Controls.Add(this.lblNodeAttributes);
            this.groupBox2.Controls.Add(this.txtRootName);
            this.groupBox2.Controls.Add(this.lblRootName);
            this.groupBox2.Controls.Add(this.ckRootNode);
            this.groupBox2.Location = new System.Drawing.Point(188, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 153);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Root Node Options";
            // 
            // ckRootNode
            // 
            this.ckRootNode.AutoSize = true;
            this.ckRootNode.Location = new System.Drawing.Point(17, 26);
            this.ckRootNode.Name = "ckRootNode";
            this.ckRootNode.Size = new System.Drawing.Size(161, 17);
            this.ckRootNode.TabIndex = 6;
            this.ckRootNode.Text = "Enclose HTML in Root node";
            this.ckRootNode.UseVisualStyleBackColor = true;
            this.ckRootNode.CheckedChanged += new System.EventHandler(this.ckRootNode_CheckedChanged);
            // 
            // lblRootName
            // 
            this.lblRootName.AutoSize = true;
            this.lblRootName.Enabled = false;
            this.lblRootName.Location = new System.Drawing.Point(14, 53);
            this.lblRootName.Name = "lblRootName";
            this.lblRootName.Size = new System.Drawing.Size(93, 13);
            this.lblRootName.TabIndex = 7;
            this.lblRootName.Text = "Root Node Name:";
            // 
            // txtRootName
            // 
            this.txtRootName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRootName.Enabled = false;
            this.txtRootName.Location = new System.Drawing.Point(113, 49);
            this.txtRootName.Name = "txtRootName";
            this.txtRootName.Size = new System.Drawing.Size(225, 20);
            this.txtRootName.TabIndex = 8;
            // 
            // txtNodeAttributes
            // 
            this.txtNodeAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodeAttributes.Enabled = false;
            this.txtNodeAttributes.Location = new System.Drawing.Point(113, 72);
            this.txtNodeAttributes.Name = "txtNodeAttributes";
            this.txtNodeAttributes.Size = new System.Drawing.Size(225, 20);
            this.txtNodeAttributes.TabIndex = 10;
            // 
            // lblNodeAttributes
            // 
            this.lblNodeAttributes.AutoSize = true;
            this.lblNodeAttributes.Enabled = false;
            this.lblNodeAttributes.Location = new System.Drawing.Point(14, 76);
            this.lblNodeAttributes.Name = "lblNodeAttributes";
            this.lblNodeAttributes.Size = new System.Drawing.Size(83, 13);
            this.lblNodeAttributes.TabIndex = 9;
            this.lblNodeAttributes.Text = "Node Attributes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBeautify);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Beautifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRichText.ResumeLayout(false);
            this.tabHtml.ResumeLayout(false);
            this.tabHtml.PerformLayout();
            this.tabOpts.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnBeautify;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRichText;
        private System.Windows.Forms.TabPage tabHtml;
        private System.Windows.Forms.TabPage tabOpts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNodeAttributes;
        private System.Windows.Forms.Label lblNodeAttributes;
        private System.Windows.Forms.TextBox txtRootName;
        private System.Windows.Forms.Label lblRootName;
        private System.Windows.Forms.CheckBox ckRootNode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckFontBold;
        private System.Windows.Forms.CheckBox ckBackColor;
        private System.Windows.Forms.CheckBox ckColor;
        private System.Windows.Forms.CheckBox ckFontName;
    }
}

