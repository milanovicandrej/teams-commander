using CommanderEngine;
using Microsoft.Graph;
using Microsoft.Graph.SecurityNamespace;
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
    public partial class TemplateBuilder : Form
    {
        List<Template> templates;
        Template current;
        int createIndex = 1;

        public TemplateBuilder()
        {
            InitializeComponent();
            templates = new List<Template>();
            current = new Template();

        }

        private void RefreshList()
        {
            cbTemplates.Items.Clear();

            foreach(Template template in templates)
            {
                cbTemplates.Items.Add(template);
            }
            cbTemplates.SelectedItem = cbTemplates.Items[0];
            current = (Template)(cbTemplates.Items[0]);
        }

        private void RefreshComponents()
        {
            txtName.Text = current.TemplateName;
            lbChannels.Items.Clear();
            lbChannels.DisplayMember = "DisplayName";

            foreach(Channel channel in current.Channels)
            {
                lbChannels.Items.Add(channel);
            }

            msAllowCreateChannel.Checked = current.MemberSettings.AllowCreateUpdateChannels ?? false;
            msAllowDeleteChannel.Checked = current.MemberSettings.AllowDeleteChannels ?? false;
            msAllowConnectors.Checked = current.MemberSettings.AllowCreateUpdateRemoveConnectors ?? false;
            msAllowApps.Checked = current.MemberSettings.AllowAddRemoveApps ?? false;

            mgAllowEdit.Checked = current.MessagingSettings.AllowUserEditMessages ?? false;
            mgAllowDelete.Checked = current.MessagingSettings.AllowUserDeleteMessages ?? false;
            mgAllowOwner.Checked  = current.MessagingSettings.AllowOwnerDeleteMessages?? false;
            mgAllowTeamMentions.Checked = current.MessagingSettings.AllowTeamMentions?? false;
            mgChannelMentions.Checked = current.MessagingSettings.AllowChannelMentions ?? false;
            
        }

        private void TemplateBuilder_Load(object sender, EventArgs e)
        { 

            var req = GraphHelper.GetUsersAsync();
            req.Wait();

            templates.Add(Template.Standard);
            templates.AddRange(Template.LoadFromFile(Settings.Singleton.TemplateFilePath));
            RefreshList();
            RefreshComponents();
        }

        private void cbTemplates_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbTemplates.SelectedIndex == 0)
            {
                txtName.Enabled = false;
                tableLayoutPanel2.Enabled = false;
            }
            else
            {
                txtName.Enabled = true;
                tableLayoutPanel2.Enabled = true;
            }
            current = (Template)(cbTemplates.SelectedItem);
            RefreshComponents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Template newTemplate = new Template();
            newTemplate.TemplateName = newTemplate.TemplateName+" " + createIndex;
            templates.Add(newTemplate);
            RefreshList();

            cbTemplates.SelectedItem = cbTemplates.Items[cbTemplates.Items.Count - 1];
            current = (Template)(cbTemplates.SelectedItem);
            createIndex++;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbTemplates.SelectedIndex != 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this template ?", "Delete", MessageBoxButtons.YesNo);

                if (res == DialogResult.No)
                    return;

                int index = cbTemplates.SelectedIndex;

                cbTemplates.Items.Remove(current);
                templates.Remove(current);
                Template.SaveAsList(Settings.Singleton.TemplateFilePath, templates.Skip(1).ToList());
                RefreshComponents();
                cbTemplates.SelectedIndex = 0;
                current = (Template)cbTemplates.SelectedItem;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int index = cbTemplates.SelectedIndex;

                Template.SaveAsList(Settings.Singleton.TemplateFilePath, templates.Skip(1).ToList());

                MessageBox.Show("Successfully saved templates !");
                RefreshList();
                cbTemplates.SelectedIndex = index;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            string name = "";
            DialogResult res = CustomDialogs.InputDialog(ref name, "Input channel name...", "Add channel");
            
            if(res == DialogResult.OK)
            {
                current.Channels.Add(new Channel
                {
                    DisplayName = name,
                    Description = "",
                    MembershipType = ChannelMembershipType.Standard
                });
                RefreshComponents();
            }
        }

        private void btnDeleteChannel_Click(object sender, EventArgs e)
        {
            current.Channels.Remove((Channel)lbChannels.SelectedItem);
            RefreshComponents();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            current.TemplateName = txtName.Text;
        }

        private void msAllowCreateChannel_CheckedChanged(object sender, EventArgs e)
        {
            current.MemberSettings.AllowCreateUpdateChannels = msAllowCreateChannel.Checked;
        }

        private void msAllowDeleteChannel_CheckedChanged(object sender, EventArgs e)
        {
            current.MemberSettings.AllowDeleteChannels = msAllowDeleteChannel.Checked;
        }

        private void msAllowApps_CheckedChanged(object sender, EventArgs e)
        {
            current.MemberSettings.AllowAddRemoveApps = msAllowApps.Checked;
        }

        private void msAllowConnectors_CheckedChanged(object sender, EventArgs e)
        {
            current.MemberSettings.AllowCreateUpdateRemoveConnectors= msAllowConnectors.Checked;
        }

        private void mgAllowEdit_CheckedChanged(object sender, EventArgs e)
        {
            current.MessagingSettings.AllowUserEditMessages = mgAllowEdit.Checked;
        }

        private void mgAllowDelete_CheckedChanged(object sender, EventArgs e)
        {
            current.MessagingSettings.AllowUserDeleteMessages = mgAllowDelete.Checked;
        }

        private void mgAllowOwner_CheckedChanged(object sender, EventArgs e)
        {
            current.MessagingSettings.AllowOwnerDeleteMessages = mgAllowOwner.Checked;
        }

        private void mgAllowTeamMentions_CheckedChanged(object sender, EventArgs e)
        {
            current.MessagingSettings.AllowTeamMentions = mgAllowTeamMentions.Checked;
        }

        private void mgChannelMentions_CheckedChanged(object sender, EventArgs e)
        {
            current.MessagingSettings.AllowChannelMentions = mgChannelMentions.Checked;
        }
    }
}
