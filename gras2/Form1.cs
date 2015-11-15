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
    public partial class Form1 : Form
    {
        public static string String_CurrentAccountName = "";

        public static string String_LoggedIn = " (Logged In)";
        public static string String_Shortcode_AccountName = "%accountname%";

        public static string String_Title = "GameRanger Account Switcher";
        public static string String_GameRanger = "GameRanger";
        public static string String_NoGameRanger = "GameRanger was not found installed on your system.";
        public static string String_Nickname1 = "Please enter a nickname for the current account:";
        public static string String_Nickname2 = "Please enter a nickname for your new account:";
        public static string String_GameRangerRunning = "GameRanger is currently running. This application cannot start until GameRanger has been closed. Would you like to close GameRanger now?";
        public static string String_ConfirmDelete = "Are you sure that you want to delete the account " + String_Shortcode_AccountName + "?";
        public static string String_NickNameError1 = "Account nicknames can only contain letters, numbers, underscores, or dashes and must be between 1 and 16 characters long.";
        public static string String_NickNameError2 = "The account nickname " + String_Shortcode_AccountName + " already exists.";
        public static string String_ConfirmUninstall = "Are you absolutely sure that you would like to uninstall the GameRanger Account Switcher? This cannot be undone!";

        public static string Path_AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string Path_GameRanger = Path_AppData + "\\GameRanger";
        public static string Path_GameRanger_GameRanger = Path_GameRanger + "\\GameRanger";
        public static string Path_GameRanger_Prefs = Path_GameRanger + "\\GameRanger Prefs";
        public static string Path_AccountSwitcher = Path_GameRanger + "\\AccountSwitcher";
        public static string Path_AccountSwitcher_Accounts = Path_AccountSwitcher + "\\Accounts";

        public static string File_GameRanger = Path_GameRanger_GameRanger + "\\GameRanger.exe";
        public static string File_GameRanger_Settings = Path_GameRanger_Prefs + "\\Settings";
        public static string File_AccountSwitcher_Current = Path_AccountSwitcher + "\\Current";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForGameRanger();
            CheckIfGameRangerIsRunning();
            Installation();
            RefreshAccountsList();
        }

        private void CheckForGameRanger()
        {
            if (File.Exists(File_GameRanger))
            {
                return;
            }
            else
            {
                MessageBox.Show(String_NoGameRanger, String_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void CheckIfGameRangerIsRunning()
        {
            if (System.Diagnostics.Process.GetProcessesByName(String_GameRanger).Length > 0)
            {
                MessageBox.Show(String_GameRangerRunning, String_Title);
            }
        }

        private void Installation()
        {
            if (!Directory.Exists(Path_AccountSwitcher)) { Directory.CreateDirectory(Path_AccountSwitcher); }
            if (!Directory.Exists(Path_AccountSwitcher_Accounts)) { Directory.CreateDirectory(Path_AccountSwitcher_Accounts); }
            if (!File.Exists(File_AccountSwitcher_Current)) { File.Create(File_AccountSwitcher_Current); }
            if (File.Exists(File_GameRanger_Settings))
            {
                if (GetCurrentAccountName().Length == 0)
                {
                    string nickname = EditNameDialog(String_Nickname1);
                    if (nickname != null) { SetCurrentAccountName(nickname); } else { Application.Exit(); }
                } else { String_CurrentAccountName = GetCurrentAccountName(); }
            }
        }

        private string EditNameDialog(string labelText = null, string nickname = null)
        {
            using (Form2 dlg = new Form2())
            {
                if (labelText != null) { dlg.labelText = labelText; }
                if (nickname != null) { dlg.nickname = nickname; }
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    return dlg.nickname;
                }
                else
                {
                    return null;
                }
            }
        }

        private void SetCurrentAccountName(string name = "")
        {
            File.WriteAllText(File_AccountSwitcher_Current, name);
            String_CurrentAccountName = name;
        }

        private string GetCurrentAccountName()
        {
            return File.ReadAllText(File_AccountSwitcher_Current);
        }

        private bool SelectedAccountIsLoggedIn()
        {
            if (SelectedAccountName() == String_CurrentAccountName) { return true; } else { return false; }
        }

        private string SelectedAccountName()
        {
            return list_accounts.GetItemText(list_accounts.SelectedItem).Replace(String_LoggedIn, "");
        }

        private void RefreshAccountsList()
        {
            list_accounts.Items.Clear();
            if (String_CurrentAccountName != "") { list_accounts.Items.Add(String_CurrentAccountName + String_LoggedIn); }
            string[] accounts = Directory.GetFiles(Path_AccountSwitcher_Accounts);
            foreach (string account in accounts) { list_accounts.Items.Add(Path.GetFileNameWithoutExtension(account)); }
            if (list_accounts.Items.Count != 0) { list_accounts.SelectedIndex = 0; }
        }

        private void LogoutAccount()
        {
            if (File.Exists(File_GameRanger_Settings)) { File.Move(File_GameRanger_Settings, Path_AccountSwitcher_Accounts + "\\" + String_CurrentAccountName); }
            SetCurrentAccountName();
        }

        private void LoginAccount(string accountName)
        {
            LogoutAccount();
            string accountFile = Path_AccountSwitcher_Accounts + "\\" + accountName;
            if (File.Exists(accountFile))
            {
                File.Move(accountFile, File_GameRanger_Settings);
                SetCurrentAccountName(accountName);
            }
        }

        private void list_accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedAccountIsLoggedIn())
            {
                btn_logout.Enabled = true;
                btn_logout.Visible = true;
                btn_login.Enabled = false;
                btn_login.Visible = false;
            }
            else
            {
                btn_login.Enabled = true;
                btn_login.Visible = true;
                btn_logout.Enabled = false;
                btn_logout.Visible = false;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogoutAccount();
            RefreshAccountsList();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginAccount(list_accounts.GetItemText(list_accounts.SelectedItem));
            RefreshAccountsList();
        }

        private void btn_editname_Click(object sender, EventArgs e)
        {
            string newName = EditNameDialog(null, SelectedAccountName());
            if (newName != null)
            {
                if (SelectedAccountIsLoggedIn())
                {
                    SetCurrentAccountName(newName);
                }
                else
                {
                    string oldFile = Path_AccountSwitcher_Accounts + "\\" + SelectedAccountName();
                    string newFile = Path_AccountSwitcher_Accounts + "\\" + newName;
                    File.Move(oldFile, newFile);
                }
                RefreshAccountsList();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(String_ConfirmDelete.Replace(String_Shortcode_AccountName, SelectedAccountName()), String_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (SelectedAccountIsLoggedIn())
                {
                    File.Delete(File_GameRanger_Settings);
                    SetCurrentAccountName();
                }
                else
                {
                    File.Delete(Path_AccountSwitcher_Accounts + "\\" + SelectedAccountName());
                }
                RefreshAccountsList();
            }
        }

        private void btn_addacct_Click(object sender, EventArgs e)
        {
            string newAccountName = EditNameDialog(String_Nickname2);
            if (newAccountName != null)
            {
                LogoutAccount();
                SetCurrentAccountName(newAccountName);
                System.Diagnostics.Process.Start(File_GameRanger);
                Application.Exit();
            }
        }

        private void btn_launch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(File_GameRanger);
            Application.Exit();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            Form3 about = new Form3();
            about.ShowDialog();
        }
    }
}
