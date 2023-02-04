namespace GUIClient
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.btnRemoveChannel = new System.Windows.Forms.Button();
            this.lbChannel = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 478);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(503, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Channels";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbChannel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 438);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddChannel);
            this.panel2.Controls.Add(this.btnRemoveChannel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddChannel.Location = new System.Drawing.Point(270, 0);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(89, 34);
            this.btnAddChannel.TabIndex = 1;
            this.btnAddChannel.Text = "Add Channel";
            this.btnAddChannel.UseVisualStyleBackColor = true;
            this.btnAddChannel.Click += new System.EventHandler(this.btnAddChannel_Click);
            // 
            // btnRemoveChannel
            // 
            this.btnRemoveChannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveChannel.Location = new System.Drawing.Point(359, 0);
            this.btnRemoveChannel.Name = "btnRemoveChannel";
            this.btnRemoveChannel.Size = new System.Drawing.Size(132, 34);
            this.btnRemoveChannel.TabIndex = 0;
            this.btnRemoveChannel.Text = "Remove Channel(s)";
            this.btnRemoveChannel.UseVisualStyleBackColor = true;
            this.btnRemoveChannel.Click += new System.EventHandler(this.btnRemoveChannel_Click);
            // 
            // lbChannel
            // 
            this.lbChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbChannel.FormattingEnabled = true;
            this.lbChannel.ItemHeight = 15;
            this.lbChannel.Location = new System.Drawing.Point(3, 3);
            this.lbChannel.Name = "lbChannel";
            this.lbChannel.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbChannel.Size = new System.Drawing.Size(491, 392);
            this.lbChannel.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(503, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.txtFilter, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbMembers, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(497, 438);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFilter.Location = new System.Drawing.Point(3, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(221, 23);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lbMembers
            // 
            this.lbMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 15;
            this.lbMembers.Location = new System.Drawing.Point(3, 28);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbMembers.Size = new System.Drawing.Size(491, 367);
            this.lbMembers.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Controls.Add(this.btnRemoveMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddMember.Location = new System.Drawing.Point(279, 0);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(88, 34);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveMember.Location = new System.Drawing.Point(367, 0);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(124, 34);
            this.btnRemoveMember.TabIndex = 0;
            this.btnRemoveMember.Text = "Remove Member(s)";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(503, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tags";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbTags, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(503, 444);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lbTags
            // 
            this.lbTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 15;
            this.lbTags.Location = new System.Drawing.Point(3, 3);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(497, 398);
            this.lbTags.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddTag);
            this.panel3.Controls.Add(this.btnRemoveTag);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 34);
            this.panel3.TabIndex = 1;
            // 
            // btnAddTag
            // 
            this.btnAddTag.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddTag.Location = new System.Drawing.Point(328, 0);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(80, 34);
            this.btnAddTag.TabIndex = 1;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemoveTag.Location = new System.Drawing.Point(408, 0);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(89, 34);
            this.btnRemoveTag.TabIndex = 0;
            this.btnRemoveTag.Text = "Remove Tag";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "editForm";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtFilter;
        private ListBox lbMembers;
        private Panel panel1;
        private Button btnAddMember;
        private Button btnRemoveMember;
        private Panel panel2;
        private Button btnAddChannel;
        private Button btnRemoveChannel;
        private ListBox lbChannel;
        private TableLayoutPanel tableLayoutPanel4;
        private ListBox lbTags;
        private Panel panel3;
        private Button btnAddTag;
        private Button btnRemoveTag;
    }
}