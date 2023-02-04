using CommanderEngine;
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

namespace GUIClient
{
    public partial class AddMemberForm : Form
    {
        TeamMembersCollectionPage nonMembers;
        TeamMembersCollectionPage toBeAdded;
        Processing proc;
        readonly string teamID;

        public AddMemberForm(ITeamMembersCollectionPage postojeci,string teamID)
        {
            InitializeComponent();
            nonMembers = new TeamMembersCollectionPage();
            toBeAdded = new TeamMembersCollectionPage();
            this.teamID = teamID;
            proc = new Processing("");

            var req = GraphHelper.GetUsersAsync();
            req.Wait();

            var res = req.Result;

            for(int i = 0; i< res.Count; i++)
            {
                bool flag = true;

                for(int j = 0; j< postojeci.Count; j++)
                {
                    if (res[i].Mail == ((AadUserConversationMember)postojeci[j]).Email)
                    {
                        flag = false;
                    }
                }

                if (flag)
                {
                    nonMembers.Add(new AadUserConversationMember
                    {
                        DisplayName = res[i].DisplayName,
                        Id = res[i].Id,
                        Email = res[i].Mail
                    });
                }
            }
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            RefreshComponents();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RefreshComponents()
        {
            lbAll.DisplayMember = "Email";
            lbAll.Items.Clear();
            foreach (var item in nonMembers)
            {
                if (((AadUserConversationMember)item).Email.ToLower().Contains(txtFilter.Text.ToLower()))
                {
                    lbAll.Items.Add(item);
                }
            }

            lbAdd.DisplayMember = "Email";
            lbAdd.Items.Clear();
            foreach (var item in toBeAdded)
            {
                lbAdd.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var lista = new TeamMembersCollectionPage();

            foreach(var item in lbAll.SelectedItems)
            {
                
                    lista.Add((AadUserConversationMember)item);
               
            }

            foreach (var item in lista)
            {
                toBeAdded.Add(item);
                nonMembers.Remove(item);
            }

            RefreshComponents();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var lista = new TeamMembersCollectionPage();

            foreach (var item in lbAdd.SelectedItems)
            {
                lista.Add((AadUserConversationMember)item);
            }

            foreach (var item in lista)
            {
                nonMembers.Add(item);
                toBeAdded.Remove(item);
            }

            RefreshComponents();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshComponents();
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {

            if (toBeAdded.Count > 0)
            {
                proc.SetMessage("Adding " + toBeAdded.Count + " members to team !");
                proc.Show();
                addMembersWorker.RunWorkerAsync();
            }
        }

        private void addMembersWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int percentage = 100 / toBeAdded.Count;

            Task[] tasks = new Task[toBeAdded.Count];

            for (int i = 0; i < toBeAdded.Count; i++)
            {
                var member = new AadUserConversationMember()
                {
                    AdditionalData = new Dictionary<string, object>()
                    {{"user@odata.bind", "https://graph.microsoft.com/v1.0/users('"+((AadUserConversationMember)(toBeAdded[i])).Email+"')"}}
                };

                tasks[i] = GraphHelper.AddMember(teamID, member);
            }

            foreach (Task task in tasks)
            {
                task.Wait();
                addMembersWorker.ReportProgress(percentage);
            }
        }

        private void addMembersWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            proc.Close();
            this.Close();
        }

        private void addMembersWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            proc.Increment(e.ProgressPercentage);
        }
    }
}
