namespace GUIClient
{
    partial class TemplateBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateBuilder));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbTemplates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbChannels = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.btnDeleteChannel = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mgChannelMentions = new System.Windows.Forms.CheckBox();
            this.mgAllowTeamMentions = new System.Windows.Forms.CheckBox();
            this.mgAllowOwner = new System.Windows.Forms.CheckBox();
            this.mgAllowDelete = new System.Windows.Forms.CheckBox();
            this.mgAllowEdit = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msAllowConnectors = new System.Windows.Forms.CheckBox();
            this.msAllowApps = new System.Windows.Forms.CheckBox();
            this.msAllowDeleteChannel = new System.Windows.Forms.CheckBox();
            this.msAllowCreateChannel = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 564);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cbTemplates);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(360, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(496, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbTemplates
            // 
            this.cbTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplates.FormattingEnabled = true;
            this.cbTemplates.Location = new System.Drawing.Point(72, 16);
            this.cbTemplates.Name = "cbTemplates";
            this.cbTemplates.Size = new System.Drawing.Size(280, 23);
            this.cbTemplates.TabIndex = 1;
            this.cbTemplates.SelectedValueChanged += new System.EventHandler(this.cbTemplates_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Template:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 49);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Template Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 23);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 448);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Channel List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbChannels, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 414);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbChannels
            // 
            this.lbChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbChannels.FormattingEnabled = true;
            this.lbChannels.ItemHeight = 15;
            this.lbChannels.Location = new System.Drawing.Point(3, 23);
            this.lbChannels.Name = "lbChannels";
            this.lbChannels.Size = new System.Drawing.Size(543, 358);
            this.lbChannels.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Channels :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddChannel);
            this.panel3.Controls.Add(this.btnDeleteChannel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 24);
            this.panel3.TabIndex = 4;
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddChannel.Location = new System.Drawing.Point(347, 0);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(96, 24);
            this.btnAddChannel.TabIndex = 1;
            this.btnAddChannel.Text = "Add Channel";
            this.btnAddChannel.UseVisualStyleBackColor = true;
            this.btnAddChannel.Click += new System.EventHandler(this.btnAddChannel_Click);
            // 
            // btnDeleteChannel
            // 
            this.btnDeleteChannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteChannel.Location = new System.Drawing.Point(443, 0);
            this.btnDeleteChannel.Name = "btnDeleteChannel";
            this.btnDeleteChannel.Size = new System.Drawing.Size(100, 24);
            this.btnDeleteChannel.TabIndex = 0;
            this.btnDeleteChannel.Text = "Delete Channel";
            this.btnDeleteChannel.UseVisualStyleBackColor = true;
            this.btnDeleteChannel.Click += new System.EventHandler(this.btnDeleteChannel_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mgChannelMentions);
            this.tabPage3.Controls.Add(this.mgAllowTeamMentions);
            this.tabPage3.Controls.Add(this.mgAllowOwner);
            this.tabPage3.Controls.Add(this.mgAllowDelete);
            this.tabPage3.Controls.Add(this.mgAllowEdit);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.msAllowConnectors);
            this.tabPage3.Controls.Add(this.msAllowApps);
            this.tabPage3.Controls.Add(this.msAllowDeleteChannel);
            this.tabPage3.Controls.Add(this.msAllowCreateChannel);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(555, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Team Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mgChannelMentions
            // 
            this.mgChannelMentions.AutoSize = true;
            this.mgChannelMentions.Location = new System.Drawing.Point(16, 280);
            this.mgChannelMentions.Name = "mgChannelMentions";
            this.mgChannelMentions.Size = new System.Drawing.Size(154, 19);
            this.mgChannelMentions.TabIndex = 10;
            this.mgChannelMentions.Text = "Allow channel mentions";
            this.mgChannelMentions.UseVisualStyleBackColor = true;
            this.mgChannelMentions.CheckedChanged += new System.EventHandler(this.mgChannelMentions_CheckedChanged);
            // 
            // mgAllowTeamMentions
            // 
            this.mgAllowTeamMentions.AutoSize = true;
            this.mgAllowTeamMentions.Location = new System.Drawing.Point(16, 256);
            this.mgAllowTeamMentions.Name = "mgAllowTeamMentions";
            this.mgAllowTeamMentions.Size = new System.Drawing.Size(139, 19);
            this.mgAllowTeamMentions.TabIndex = 9;
            this.mgAllowTeamMentions.Text = "Allow team mentions";
            this.mgAllowTeamMentions.UseVisualStyleBackColor = true;
            this.mgAllowTeamMentions.CheckedChanged += new System.EventHandler(this.mgAllowTeamMentions_CheckedChanged);
            // 
            // mgAllowOwner
            // 
            this.mgAllowOwner.AutoSize = true;
            this.mgAllowOwner.Location = new System.Drawing.Point(16, 232);
            this.mgAllowOwner.Name = "mgAllowOwner";
            this.mgAllowOwner.Size = new System.Drawing.Size(215, 19);
            this.mgAllowOwner.TabIndex = 8;
            this.mgAllowOwner.Text = "Allow the owner to delete messages";
            this.mgAllowOwner.UseVisualStyleBackColor = true;
            this.mgAllowOwner.CheckedChanged += new System.EventHandler(this.mgAllowOwner_CheckedChanged);
            // 
            // mgAllowDelete
            // 
            this.mgAllowDelete.AutoSize = true;
            this.mgAllowDelete.Location = new System.Drawing.Point(16, 208);
            this.mgAllowDelete.Name = "mgAllowDelete";
            this.mgAllowDelete.Size = new System.Drawing.Size(189, 19);
            this.mgAllowDelete.TabIndex = 7;
            this.mgAllowDelete.Text = "Allow users to delete messages";
            this.mgAllowDelete.UseVisualStyleBackColor = true;
            this.mgAllowDelete.CheckedChanged += new System.EventHandler(this.mgAllowDelete_CheckedChanged);
            // 
            // mgAllowEdit
            // 
            this.mgAllowEdit.AutoSize = true;
            this.mgAllowEdit.Location = new System.Drawing.Point(16, 184);
            this.mgAllowEdit.Name = "mgAllowEdit";
            this.mgAllowEdit.Size = new System.Drawing.Size(177, 19);
            this.mgAllowEdit.TabIndex = 6;
            this.mgAllowEdit.Text = "Allow users to edit messages";
            this.mgAllowEdit.UseVisualStyleBackColor = true;
            this.mgAllowEdit.CheckedChanged += new System.EventHandler(this.mgAllowEdit_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Messaging settings :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Member settings :";
            // 
            // msAllowConnectors
            // 
            this.msAllowConnectors.AutoSize = true;
            this.msAllowConnectors.Location = new System.Drawing.Point(16, 120);
            this.msAllowConnectors.Name = "msAllowConnectors";
            this.msAllowConnectors.Size = new System.Drawing.Size(316, 19);
            this.msAllowConnectors.TabIndex = 3;
            this.msAllowConnectors.Text = "Allow members to Create/Update/Remove connectors ";
            this.msAllowConnectors.UseVisualStyleBackColor = true;
            this.msAllowConnectors.CheckedChanged += new System.EventHandler(this.msAllowConnectors_CheckedChanged);
            // 
            // msAllowApps
            // 
            this.msAllowApps.AutoSize = true;
            this.msAllowApps.Location = new System.Drawing.Point(16, 96);
            this.msAllowApps.Name = "msAllowApps";
            this.msAllowApps.Size = new System.Drawing.Size(227, 19);
            this.msAllowApps.TabIndex = 2;
            this.msAllowApps.Text = "Allow members to Add/Remove apps ";
            this.msAllowApps.UseVisualStyleBackColor = true;
            this.msAllowApps.CheckedChanged += new System.EventHandler(this.msAllowApps_CheckedChanged);
            // 
            // msAllowDeleteChannel
            // 
            this.msAllowDeleteChannel.AutoSize = true;
            this.msAllowDeleteChannel.Location = new System.Drawing.Point(16, 72);
            this.msAllowDeleteChannel.Name = "msAllowDeleteChannel";
            this.msAllowDeleteChannel.Size = new System.Drawing.Size(208, 19);
            this.msAllowDeleteChannel.TabIndex = 1;
            this.msAllowDeleteChannel.Text = "Allow members to delete channels";
            this.msAllowDeleteChannel.UseVisualStyleBackColor = true;
            this.msAllowDeleteChannel.CheckedChanged += new System.EventHandler(this.msAllowDeleteChannel_CheckedChanged);
            // 
            // msAllowCreateChannel
            // 
            this.msAllowCreateChannel.AutoSize = true;
            this.msAllowCreateChannel.Location = new System.Drawing.Point(16, 48);
            this.msAllowCreateChannel.Name = "msAllowCreateChannel";
            this.msAllowCreateChannel.Size = new System.Drawing.Size(271, 19);
            this.msAllowCreateChannel.TabIndex = 0;
            this.msAllowCreateChannel.Text = "Allow members to create and update channels";
            this.msAllowCreateChannel.UseVisualStyleBackColor = true;
            this.msAllowCreateChannel.CheckedChanged += new System.EventHandler(this.msAllowCreateChannel_CheckedChanged);
            // 
            // TemplateBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemplateBuilder";
            this.Text = "Template Builder";
            this.Load += new System.EventHandler(this.TemplateBuilder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox cbTemplates;
        private Label label1;
        private Button btnSave;
        private Button btnAdd;
        private Button btnDelete;
        private Panel panel2;
        private Label label2;
        private TextBox txtName;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage tabPage3;
        private ListBox lbChannels;
        private Label label3;
        private Panel panel3;
        private Button btnAddChannel;
        private Button btnDeleteChannel;
        private CheckBox msAllowApps;
        private CheckBox msAllowDeleteChannel;
        private CheckBox msAllowCreateChannel;
        private Label label4;
        private CheckBox msAllowConnectors;
        private CheckBox mgAllowEdit;
        private Label label5;
        private CheckBox mgChannelMentions;
        private CheckBox mgAllowTeamMentions;
        private CheckBox mgAllowOwner;
        private CheckBox mgAllowDelete;
    }
}