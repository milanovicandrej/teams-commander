namespace GUIClient
{
    partial class AddTeamForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.lbCreate = new System.Windows.Forms.ListBox();
            this.createTeamWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 23);
            this.txtName.TabIndex = 0;
            this.txtName.Text = " ";
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team name :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(72, 328);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Create";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.Location = new System.Drawing.Point(152, 328);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(91, 23);
            this.btnAddToQueue.TabIndex = 5;
            this.btnAddToQueue.Text = "Add to Queue";
            this.btnAddToQueue.UseVisualStyleBackColor = true;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Template :";
            // 
            // cbTemplate
            // 
            this.cbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Location = new System.Drawing.Point(88, 296);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(232, 23);
            this.cbTemplate.TabIndex = 7;
            this.cbTemplate.SelectedIndexChanged += new System.EventHandler(this.cbTemplate_SelectedIndexChanged);
            // 
            // lbCreate
            // 
            this.lbCreate.FormattingEnabled = true;
            this.lbCreate.ItemHeight = 15;
            this.lbCreate.Location = new System.Drawing.Point(88, 48);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(232, 229);
            this.lbCreate.TabIndex = 9;
            // 
            // createTeamWorker
            // 
            this.createTeamWorker.WorkerReportsProgress = true;
            this.createTeamWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.createTeamWorker_DoWork);
            this.createTeamWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.createTeamWorker_ProgressChanged);
            this.createTeamWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.createTeamWorker_RunWorkerCompleted);
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 363);
            this.Controls.Add(this.lbCreate);
            this.Controls.Add(this.cbTemplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddToQueue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.AddTeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Button btnOK;
        private Button btnCancel;
        private Button btnAddToQueue;
        private Label label2;
        private ComboBox cbTemplate;
        private ListBox lbCreate;
        private System.ComponentModel.BackgroundWorker createTeamWorker;
    }
}