namespace GUIClient
{
    partial class AddMemberForm
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
            this.lbAll = new System.Windows.Forms.ListBox();
            this.lbAdd = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMembersWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbAll
            // 
            this.lbAll.FormattingEnabled = true;
            this.lbAll.ItemHeight = 15;
            this.lbAll.Location = new System.Drawing.Point(16, 80);
            this.lbAll.Name = "lbAll";
            this.lbAll.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAll.Size = new System.Drawing.Size(296, 409);
            this.lbAll.TabIndex = 0;
            // 
            // lbAdd
            // 
            this.lbAdd.FormattingEnabled = true;
            this.lbAdd.ItemHeight = 15;
            this.lbAdd.Location = new System.Drawing.Point(376, 80);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAdd.Size = new System.Drawing.Size(296, 409);
            this.lbAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(320, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(320, 280);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(48, 40);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(488, 504);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 31);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(584, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(16, 48);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(296, 23);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search :";
            // 
            // addMembersWorker
            // 
            this.addMembersWorker.WorkerReportsProgress = true;
            this.addMembersWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.addMembersWorker_DoWork);
            this.addMembersWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.addMembersWorker_ProgressChanged);
            this.addMembersWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.addMembersWorker_RunWorkerCompleted);
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.lbAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMemberForm";
            this.Text = "Add Member(s)";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbAll;
        private ListBox lbAdd;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnApply;
        private Button btnCancel;
        private TextBox txtFilter;
        private Label label1;
        private System.ComponentModel.BackgroundWorker addMembersWorker;
    }
}