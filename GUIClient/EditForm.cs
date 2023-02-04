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
    public partial class EditForm : Form
    {
        Team Team;
        ITeamChannelsCollectionPage Channels;
        ITeamMembersCollectionPage Members;
        ITeamTagsCollectionPage Tags;

        readonly string teamID;
        public EditForm(string id)
        {
            InitializeComponent();
            this.teamID = id;
            RefreshData(id);   
        }

        private void RefreshData(string id)
        {
            var teamReq = GraphHelper.GetTeam(id);
            var channelsReq = GraphHelper.GetTeamChannels(id);
            var membersReq = GraphHelper.GetTeamMembers(id);
            var tagReq = GraphHelper.GetTeamTags(id);

            teamReq.Wait();
            channelsReq.Wait();
            membersReq.Wait();
            tagReq.Wait();

            Team = teamReq.Result;
            Channels = channelsReq.Result;
            Members = membersReq.Result;
            Tags = tagReq.Result;
        }

        private void RefreshComponents()
        {
            RefreshData(teamID);
            //load all the channels
            lbChannel.DisplayMember = "DisplayName";
            lbChannel.Items.Clear();
            foreach (Channel channel in Channels)
            {
                lbChannel.Items.Add(channel);
            }


            //load all the members
            lbMembers.Items.Clear();
            lbMembers.DisplayMember = "Email";
            foreach (AadUserConversationMember member in Members)
            {
                lbMembers.Items.Add(member);
            }

            //load all tags
            lbTags.Items.Clear();
            lbTags.DisplayMember = "DisplayName";
            foreach(TeamworkTag tag in Tags)
            {
                lbTags.Items.Add(tag);
            }

        }

        private void editForm_Load(object sender, EventArgs e)
        {
            this.Text = Team.DisplayName + " - Edit";
            RefreshComponents();
            
        }

        private async void btnRemoveMember_Click(object sender, EventArgs e)
        {
            int count = lbMembers.SelectedItems.Count;
            Task[] tasks= new Task[count];

            try
            {
                for (int i = 0; i < count; i++)
                {
                    var userID = ((ConversationMember)lbMembers.SelectedItems[i]).Id;
                    tasks[i] = GraphHelper.RemoveMember(Team.Id,userID);
                }


                foreach(var task in tasks)
                {
                    await task;
                }

                MessageBox.Show("Successfully removed " + count + " members !");
                txtFilter.Text = "";
                RefreshComponents();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error removing members !");
            }
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            string channelName = "";
            DialogResult res = CustomDialogs.InputDialog(ref channelName, "Input new channel name ...", "Add channel");
            if(res == DialogResult.OK) {
                var req = GraphHelper.AddChannel(teamID, new Channel { DisplayName = channelName, Description = channelName });
                try
                {
                    req.Wait();
                    MessageBox.Show("Successfully created a channel !");
                    RefreshComponents();
                }catch(Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRemoveChannel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(Channel channel in lbChannel.SelectedItems)
                {
                    var req = GraphHelper.RemoveChannel(teamID, channel.Id);
                    req.Wait();
                }

                MessageBox.Show("Successfully deleted " + lbChannel.SelectedItems.Count + " channels !");
                RefreshComponents();
            }catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lbMembers.Items.Clear();
            lbMembers.DisplayMember = "Email";
            foreach (AadUserConversationMember member in Members)
            {
                if (member.DisplayName.ToLower().Contains(txtFilter.Text.ToLower()))
                {
                    lbMembers.Items.Add(member);
                }
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm mf = new AddMemberForm(Members,teamID);
            mf.ShowDialog();

            if(mf.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Succesfully added new members !");
                RefreshComponents();
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            try
            {
                AddTagForm tg = new AddTagForm(teamID);
                tg.ShowDialog();
                RefreshComponents();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do you want to delete this tag ?", "Delete tag", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    var req = GraphHelper.RemoveTag(teamID, ((TeamworkTag)lbTags.SelectedItem).Id);
                    req.Wait();
                    RefreshComponents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
