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
using Microsoft.Graph;

namespace GUIClient
{
    public partial class ListTeams : Form
    {

        IUserJoinedTeamsCollectionPage? Teams;
        public ListTeams()
        {
            InitializeComponent();
            //Load teams !
            SyncData();
        }

        private void listTeams_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public bool SyncData()
        {
            try
            {
                var request = GraphHelper.GetTeams();
                request.Wait();
                Teams = request.Result;

                dataList.Columns.Clear();

                dataList.Columns.Add("Id");
                dataList.Columns.Add("Display Name");
                dataList.Columns.Add("Description");

                dataList.Items.Clear();

                foreach (var team in Teams)
                {
                    ListViewItem item = new ListViewItem(team.Id);
                    item.SubItems.Add(team.DisplayName);
                    item.SubItems.Add(team.Description);
                    dataList.Items.Add(item);
                }


                dataList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void LoadTeam(string id)
        {

            EditForm temp = new EditForm(id);
            temp.MdiParent = this.MdiParent;
            temp.Show();
        }

        private void FormLoadHandler(object sender, EventArgs e)
        {
            MainForm main = this.MdiParent as MainForm;
            main?.SetStatus("Loaded teams successfully !");
            main?.Show();
        }

        private void dataList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in dataList.CheckedItems)
            {
                item.Checked = false;
            }

            string id = dataList.SelectedItems[0].Text;
            LoadTeam(id);
        }

        private void btnEditHandler(object sender, EventArgs e)
        {
            foreach (ListViewItem item in dataList.CheckedItems)
            {
                LoadTeam(item.Text);
            }
            if(dataList.CheckedItems.Count == 0 && dataList.SelectedItems.Count != 0)
            {
                LoadTeam(dataList.SelectedItems[0].Text);
            }
        }
        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in dataList.CheckedItems)
            {
                item.Checked = false;
            }
        }

        private void btnAddHandler(object sender, EventArgs e)
        {
            Form simpleDialog = new AddTeamForm();
            simpleDialog.MdiParent = this.MdiParent;
            simpleDialog.Show();
            SyncData();
        }

        private void btnDeleteHandler(object sender, EventArgs e)
        {
            List<Command> commands = new List<Command>();
            MainForm main = this.MdiParent as MainForm;

            foreach(ListViewItem item in dataList.CheckedItems)
            {
                Team t = Teams.Where(team => team.Id == item.Text).FirstOrDefault();
                main.commandQueue.AddCommand(new DeleteTeam(t));
            }

            MessageBox.Show("Successfully added delete commands to the Queue !");
        }
    }
}
