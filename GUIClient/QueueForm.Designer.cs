namespace GUIClient
{
    partial class QueueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.commandList = new System.Windows.Forms.ListView();
            this.statusIcon = new System.Windows.Forms.ColumnHeader();
            this.message = new System.Windows.Forms.ColumnHeader();
            this.btnCmd = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.queueWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // commandList
            // 
            this.commandList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusIcon,
            this.message});
            this.commandList.Location = new System.Drawing.Point(8, 8);
            this.commandList.Name = "commandList";
            this.commandList.Size = new System.Drawing.Size(352, 352);
            this.commandList.TabIndex = 0;
            this.commandList.UseCompatibleStateImageBehavior = false;
            this.commandList.View = System.Windows.Forms.View.Details;
            // 
            // statusIcon
            // 
            this.statusIcon.Text = "Status";
            this.statusIcon.Width = 50;
            // 
            // message
            // 
            this.message.Text = "Message";
            this.message.Width = 298;
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(128, 408);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(75, 23);
            this.btnCmd.TabIndex = 1;
            this.btnCmd.Text = "Run";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // pBar
            // 
            this.pBar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.pBar.Location = new System.Drawing.Point(8, 376);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(352, 23);
            this.pBar.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 408);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // queueWorker
            // 
            this.queueWorker.WorkerReportsProgress = true;
            this.queueWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.queueWorker_DoWork);
            this.queueWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.queueWorker_ProgressChanged);
            this.queueWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.queueWorker_RunWorkerCompleted);
            // 
            // QueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 439);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.btnCmd);
            this.Controls.Add(this.commandList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QueueForm";
            this.Text = "Command Queue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.batchForm_FormClosing);
            this.Load += new System.EventHandler(this.batchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView commandList;
        private ColumnHeader statusIcon;
        private ColumnHeader message;
        private Button btnCmd;
        private ProgressBar pBar;
        private Button btnCancel;
        private Button btnClear;
        private System.ComponentModel.BackgroundWorker queueWorker;
    }
}