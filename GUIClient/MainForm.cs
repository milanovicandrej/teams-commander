using CommanderEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIClient
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        ListTeams? ListTeams;
        public QueueForm commandQueue;

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetStatus(string message)
        {
            statusStrip.Items[0].Text = message;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            AddTeamForm form = new AddTeamForm();
            form.MdiParent = this;
            form.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            LoginForm dialog = new LoginForm();

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Enabled = true;

                //Prozor za spisak team-ova
                ListTeams = new ListTeams();
                ListTeams.MdiParent = this;

                SetStatus("Logged in successfully !");

                commandQueue = new QueueForm();
                commandQueue.MdiParent = this;
                commandQueue.Hide();
            }

        }


        private void listTeamsToolStrip_Click(object sender, EventArgs e)
        {
            ListTeams.Show();
        }

        private void syncToolStripButton_Click(object sender, EventArgs e)
        {
            ListTeams.SyncData();
        }

        private void commandQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandQueue.Show();
        }

        private void templateBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemplateBuilder tb = new TemplateBuilder();
            tb.Show();
        }

        private void syncToCloudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListTeams.SyncData();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences pref = new Preferences();
            pref.Show();
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
