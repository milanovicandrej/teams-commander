using Config.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommanderEngine;

namespace GUIClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Settings.LoadSettings();
            Settings.DefaultSettings();
            txtEmail.Text = Settings.Singleton?.DefaultUser;
        }

        private void LogInFunc()
        {
            string username = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            lblError.Visible = false;
            lblAttempt.Visible = true;
            btnConfig.Enabled = false;
            btnLogin.Enabled = false;

            bool result = false;

            try
            {
                result = GraphHelper.InitializeGraphWithUsername(Settings.Singleton, username, password);
                GraphHelper.InitializeGraphForAppOnlyAuth();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to log in !");
            }

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            lblError.Visible = true;
            btnConfig.Enabled = true;
            btnLogin.Enabled = true;
            lblAttempt.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogInFunc();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Preferences pf = new Preferences();
            pf.ShowDialog();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LogInFunc();
            }
        }
    }
}
