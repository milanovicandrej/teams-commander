﻿namespace GUIClient
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.txtTennantId = new System.Windows.Forms.TextBox();
            this.txtFileLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFindFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(144, 16);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(296, 23);
            this.txtClientId.TabIndex = 2;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(144, 56);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(296, 23);
            this.txtClientSecret.TabIndex = 3;
            // 
            // txtTennantId
            // 
            this.txtTennantId.Location = new System.Drawing.Point(144, 96);
            this.txtTennantId.Name = "txtTennantId";
            this.txtTennantId.Size = new System.Drawing.Size(296, 23);
            this.txtTennantId.TabIndex = 4;
            // 
            // txtFileLoc
            // 
            this.txtFileLoc.Location = new System.Drawing.Point(144, 136);
            this.txtFileLoc.Name = "txtFileLoc";
            this.txtFileLoc.Size = new System.Drawing.Size(264, 23);
            this.txtFileLoc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Client Secret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tennant ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Template file location :";
            // 
            // btnFindFile
            // 
            this.btnFindFile.Location = new System.Drawing.Point(416, 136);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(24, 23);
            this.btnFindFile.TabIndex = 11;
            this.btnFindFile.Text = "...";
            this.btnFindFile.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 215);
            this.Controls.Add(this.btnFindFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileLoc);
            this.Controls.Add(this.txtTennantId);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtClientId;
        private TextBox txtClientSecret;
        private TextBox txtTennantId;
        private TextBox txtFileLoc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button btnFindFile;
    }
}