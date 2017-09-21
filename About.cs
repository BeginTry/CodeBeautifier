using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeBeautifier
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblCopyright.Text = lblCopyright.Text.Replace("1999", DateTime.Today.Year.ToString());
        }

        private void lnkGitRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkGitRepo.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/BeginTry/CodeBeautifier");
        }

        private void lnkQuickStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkQuickStart.LinkVisited = true;
            System.Diagnostics.Process.Start("https://itsalljustelectrons.blogspot.com/2017/04/Code-Beautifier.html");
        }
    }
}
