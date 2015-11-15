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
    public partial class Form2 : Form
    {
        public string labelText { set { label1.Text = value; } }

        public string nickname
        {
            set { txt_name.Text = value; }
            get { return txt_name.Text; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_name.Text, @"^[a-zA-Z0-9_-]+$") || txt_name.Text.Length == 0)
            {
                MessageBox.Show(Form1.String_NickNameError1, Form1.String_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(Form1.Path_AccountSwitcher_Accounts + "\\" + txt_name.Text) || txt_name.Text.ToLower() == Form1.String_CurrentAccountName.ToLower())
            {
                MessageBox.Show(Form1.String_NickNameError2.Replace(Form1.String_Shortcode_AccountName, txt_name.Text), Form1.String_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
