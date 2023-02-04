using CommanderEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIClient
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Singleton.ClientId = txtClientId.Text;
            Settings.Singleton.ClientSecret = txtClientSecret.Text;
            Settings.Singleton.TenantId = txtTennantId.Text;
            Settings.Singleton.TemplateFilePath = txtFileLoc.Text;
            this.Close();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            txtClientId.Text = Settings.Singleton.ClientId;
            txtClientSecret.Text=Settings.Singleton.ClientSecret;
            txtTennantId.Text=Settings.Singleton.TenantId;
            txtFileLoc.Text=Settings.Singleton.TemplateFilePath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
