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
    public partial class AddTagForm : Form
    {
        ITeamMembersCollectionPage Members;
        TeamMembersCollectionPage toBeTagged;

        Processing proc;
        readonly string teamID;

        public AddTagForm(string teamID)
        {
            InitializeComponent();
            toBeTagged = new TeamMembersCollectionPage();

            this.teamID = teamID;
            proc = new Processing("");

            var req = GraphHelper.GetTeamMembers(teamID);
            req.Wait();

            Members = req.Result;
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
            foreach (var item in Members)
            {
                if (((AadUserConversationMember)item).Email.ToLower().Contains(txtFilter.Text.ToLower()))
                {
                    lbAll.Items.Add(item);
                }
            }

            lbAdd.DisplayMember = "Email";
            lbAdd.Items.Clear();
            foreach (var item in toBeTagged)
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
                toBeTagged.Add(item);
                Members.Remove(item);
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
                Members.Add(item);
                toBeTagged.Remove(item);
            }

            RefreshComponents();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshComponents();
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            if (toBeTagged.Count > 0)
            {
                addTagWorker.RunWorkerAsync();
            }
        }

        private void addTagWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var tagMembers = new TeamworkTagMembersCollectionPage();
                foreach (var member in toBeTagged)
                {
                    tagMembers.Add(new TeamworkTagMember() { UserId = member.Id });
                }

                var req = GraphHelper.AddTag(teamID, new TeamworkTag()
                {
                    DisplayName = txtTagName.Text,
                    Members = tagMembers
                });

                req.Wait();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addTagWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Successfully created a new tag !");
            this.Close();
        }
    }
}
