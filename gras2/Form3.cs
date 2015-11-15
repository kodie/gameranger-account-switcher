using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gras2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label_app_version.Text = "Version " + Application.ProductVersion;

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.picture_github, "Check out the source on GitHub!");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_uninstall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Form1.String_ConfirmUninstall, Form1.String_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Directory.Delete(Form1.Path_AccountSwitcher, true);
                Application.Exit();
            }
        }

        private void link_kodieg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kodieg.com");
        }

        private void link_gameranger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://gameranger.com");
        }

        private void picture_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kodie/gameranger-account-switcher");
        }
    }
}
