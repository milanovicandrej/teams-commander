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
    public partial class QueueForm : Form
    {
        List<Command> Commands;
        
        public QueueForm()
        {
            InitializeComponent();
            this.Commands= new List<Command>();
        }

        public QueueForm(List<Command> commands)
        {
            InitializeComponent();
            this.Commands = commands;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Run()
        {
            
        }

        public void AddCommand(Command command)
        {
            Commands.Add(command);

            ListViewItem item = new ListViewItem("Queued");
            item.SubItems.Add(command.Description);
            commandList.Items.Add(item);
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnCmd.Enabled = false;
            if(commandList.Items.Count > 0)
                queueWorker.RunWorkerAsync();

        }

        private void batchForm_Load(object sender, EventArgs e)
        {
            commandList.Items.Clear();            
            for(int i = 0; i < Commands.Count; i++)
            {
                ListViewItem item = new ListViewItem("Queued");
                item.SubItems.Add(Commands[i].Description);
                commandList.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            commandList.Items.Clear();
            Commands.Clear();
            pBar.Value = 0;
            btnCmd.Enabled = true;
        }

        private void batchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        internal class UserState
        {
            public int Id;
            public CommandResponse response;
        }

        private void queueWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int percent = 100 / Commands.Count;

            for (int i = 0; i < Commands.Count; i++)
            {
                CommandResponse res = Commands[i].Execute();

                UserState userState = new UserState()
                {
                    Id = i,
                    response = res,
                };

                queueWorker.ReportProgress(percent,userState);
            }
        }

        private void queueWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UserState state =(UserState)(e.UserState);
            commandList.Items[state.Id].Text = state.response.isSuccessful.ToString();
            commandList.Items[state.Id].SubItems[1].Text = state.response.Message;
            pBar.Increment(e.ProgressPercentage);
        }

        private void queueWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnClear.Enabled = true;
            btnCancel.Enabled = true;
            btnCmd.Enabled = true;
        }
    }
}
