namespace CodeBeautifier
{
    partial class About
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lnkGitRepo = new System.Windows.Forms.LinkLabel();
            this.lnkQuickStart = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(197, 126);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CodeBeautifier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 131);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(104, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "©1999 Dave Mason";
            // 
            // lnkGitRepo
            // 
            this.lnkGitRepo.AutoSize = true;
            this.lnkGitRepo.Location = new System.Drawing.Point(39, 80);
            this.lnkGitRepo.Name = "lnkGitRepo";
            this.lnkGitRepo.Size = new System.Drawing.Size(93, 13);
            this.lnkGitRepo.TabIndex = 3;
            this.lnkGitRepo.TabStop = true;
            this.lnkGitRepo.Text = "GitHub Repository";
            this.lnkGitRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitRepo_LinkClicked);
            // 
            // lnkQuickStart
            // 
            this.lnkQuickStart.AutoSize = true;
            this.lnkQuickStart.Location = new System.Drawing.Point(156, 80);
            this.lnkQuickStart.Name = "lnkQuickStart";
            this.lnkQuickStart.Size = new System.Drawing.Size(91, 13);
            this.lnkQuickStart.TabIndex = 4;
            this.lnkQuickStart.TabStop = true;
            this.lnkQuickStart.Text = "Quick Start Guide";
            this.lnkQuickStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkQuickStart_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Generate html markup from Rich Text Format text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // About
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkQuickStart);
            this.Controls.Add(this.lnkGitRepo);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.LinkLabel lnkGitRepo;
        private System.Windows.Forms.LinkLabel lnkQuickStart;
        private System.Windows.Forms.Label label2;
    }
}