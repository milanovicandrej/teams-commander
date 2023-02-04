using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommanderEngine;

namespace GUIClient
{
    public partial class AddTeamForm : Form
    {
        Template choice;
        Processing proc;

        public AddTeamForm()
        {
            InitializeComponent();
            choice = new Template();
            proc = new Processing("Creating teams !");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            proc.Show();

            if (lbCreate.Items.Count > 0)
            {
                createTeamWorker.RunWorkerAsync();
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void RefreshTemplates()
        {
            List<Template> temp = Template.LoadFromFile(Settings.Singleton.TemplateFilePath);
            temp.Insert(0, Template.Standard);
            cbTemplate.DisplayMember = "DisplayName";
            cbTemplate.Items.Clear(); 
            foreach (Template item in temp)
            {
                cbTemplate.Items.Add(item);
            }

            cbTemplate.SelectedIndex = 0;
        }

        private void AddTeamForm_Load(object sender, EventArgs e)
        {
            RefreshTemplates();   
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = (Template)cbTemplate.SelectedItem;
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;
            foreach (string teamName in lbCreate.Items)
            {
                Team t = choice.CreateFromTemplate(teamName,teamName);
                Command cmd = new AddTeam(t);
                main.commandQueue.AddCommand(cmd);
            }

            MessageBox.Show("Queued " + lbCreate.Items.Count + " new teams to create !");
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                lbCreate.Items.Add(txtName.Text);
                txtName.Text = "";
            }
        }

        private void createTeamWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            int inc = 100 / lbCreate.Items.Count;

            foreach (string teamName in lbCreate.Items)
            {
                Team t = choice.CreateFromTemplate(teamName, teamName);
                Command cmd = new AddTeam(t);
                cmd.Execute();
                createTeamWorker.ReportProgress(inc);
            }
        }

        private void createTeamWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            proc.Close();

            MessageBox.Show("Successfully created " + lbCreate.Items.Count + " teams !");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void createTeamWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            proc.Increment(e.ProgressPercentage);
        }
    }
}
