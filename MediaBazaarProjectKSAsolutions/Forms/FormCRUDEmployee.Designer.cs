﻿
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormCRUDEmployee
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
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelPage = new System.Windows.Forms.Panel();
            this.lblPage = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMakeUserInactive = new System.Windows.Forms.Button();
            this.btnSeeInactiveUsers = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.timer7Years = new System.Windows.Forms.Timer(this.components);
            this.panelDMandGM = new System.Windows.Forms.Panel();
            this.btnSeeResupplyRequests = new System.Windows.Forms.Button();
            this.DGVId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDaysOffRequests = new System.Windows.Forms.Button();
            this.panelHRorGM = new System.Windows.Forms.Panel();
            this.panelPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panelDMandGM.SuspendLayout();
            this.panelHRorGM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(1218, 725);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 45);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.Color.DarkOrchid;
            this.panelPage.Controls.Add(this.lblPage);
            this.panelPage.Location = new System.Drawing.Point(0, 12);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(337, 107);
            this.panelPage.TabIndex = 17;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPage.Location = new System.Drawing.Point(26, 23);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(309, 54);
            this.lblPage.TabIndex = 18;
            this.lblPage.Text = "Employees Page";
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 25;
            this.lbUsers.Location = new System.Drawing.Point(62, 222);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(1225, 479);
            this.lbUsers.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddUser.Location = new System.Drawing.Point(63, 150);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(211, 67);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.Location = new System.Drawing.Point(379, 150);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(211, 67);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMakeUserInactive
            // 
            this.btnMakeUserInactive.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMakeUserInactive.FlatAppearance.BorderSize = 0;
            this.btnMakeUserInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeUserInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMakeUserInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMakeUserInactive.Location = new System.Drawing.Point(738, 150);
            this.btnMakeUserInactive.Name = "btnMakeUserInactive";
            this.btnMakeUserInactive.Size = new System.Drawing.Size(211, 67);
            this.btnMakeUserInactive.TabIndex = 5;
            this.btnMakeUserInactive.Text = "Make User Inactive";
            this.btnMakeUserInactive.UseVisualStyleBackColor = false;
            this.btnMakeUserInactive.Click += new System.EventHandler(this.btnMakeUserInactive_Click);
            // 
            // btnSeeInactiveUsers
            // 
            this.btnSeeInactiveUsers.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSeeInactiveUsers.FlatAppearance.BorderSize = 0;
            this.btnSeeInactiveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeInactiveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeInactiveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeeInactiveUsers.Location = new System.Drawing.Point(1076, 149);
            this.btnSeeInactiveUsers.Name = "btnSeeInactiveUsers";
            this.btnSeeInactiveUsers.Size = new System.Drawing.Size(211, 67);
            this.btnSeeInactiveUsers.TabIndex = 6;
            this.btnSeeInactiveUsers.Text = "Inactive and Away Users";
            this.btnSeeInactiveUsers.UseVisualStyleBackColor = false;
            this.btnSeeInactiveUsers.Click += new System.EventHandler(this.btnSeeInactiveUsers_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(36, 127);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1279, 588);
            this.dataGridView3.TabIndex = 1;
            // 
            // panelDMandGM
            // 
            this.panelDMandGM.Controls.Add(this.btnSeeResupplyRequests);
            this.panelDMandGM.Enabled = false;
            this.panelDMandGM.Location = new System.Drawing.Point(422, 13);
            this.panelDMandGM.Name = "panelDMandGM";
            this.panelDMandGM.Size = new System.Drawing.Size(280, 93);
            this.panelDMandGM.TabIndex = 18;
            // 
            // btnSeeResupplyRequests
            // 
            this.btnSeeResupplyRequests.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSeeResupplyRequests.FlatAppearance.BorderSize = 0;
            this.btnSeeResupplyRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeResupplyRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeResupplyRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeeResupplyRequests.Location = new System.Drawing.Point(21, 12);
            this.btnSeeResupplyRequests.Name = "btnSeeResupplyRequests";
            this.btnSeeResupplyRequests.Size = new System.Drawing.Size(211, 67);
            this.btnSeeResupplyRequests.TabIndex = 4;
            this.btnSeeResupplyRequests.Text = "See Resupply Requests";
            this.btnSeeResupplyRequests.UseVisualStyleBackColor = false;
            this.btnSeeResupplyRequests.Click += new System.EventHandler(this.btnSeeResupplyRequests_Click);
            // 
            // DGVId
            // 
            this.DGVId.HeaderText = "Id";
            this.DGVId.MinimumWidth = 8;
            this.DGVId.Name = "DGVId";
            this.DGVId.ReadOnly = true;
            this.DGVId.Width = 150;
            // 
            // btnDaysOffRequests
            // 
            this.btnDaysOffRequests.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDaysOffRequests.FlatAppearance.BorderSize = 0;
            this.btnDaysOffRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaysOffRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDaysOffRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDaysOffRequests.Location = new System.Drawing.Point(26, 10);
            this.btnDaysOffRequests.Name = "btnDaysOffRequests";
            this.btnDaysOffRequests.Size = new System.Drawing.Size(211, 67);
            this.btnDaysOffRequests.TabIndex = 5;
            this.btnDaysOffRequests.Text = "See Days off Requests";
            this.btnDaysOffRequests.UseVisualStyleBackColor = false;
            this.btnDaysOffRequests.Click += new System.EventHandler(this.btnDaysOffRequests_Click);
            // 
            // panelHRorGM
            // 
            this.panelHRorGM.Controls.Add(this.btnDaysOffRequests);
            this.panelHRorGM.Enabled = false;
            this.panelHRorGM.Location = new System.Drawing.Point(738, 15);
            this.panelHRorGM.Name = "panelHRorGM";
            this.panelHRorGM.Size = new System.Drawing.Size(280, 93);
            this.panelHRorGM.TabIndex = 19;
            // 
            // FormCRUDEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 782);
            this.Controls.Add(this.panelHRorGM);
            this.Controls.Add(this.panelDMandGM);
            this.Controls.Add(this.btnSeeInactiveUsers);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.btnMakeUserInactive);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCRUDEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormCRUDEmployee_Load);
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panelDMandGM.ResumeLayout(false);
            this.panelHRorGM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMakeUserInactive;
        private System.Windows.Forms.Button btnSeeInactiveUsers;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Timer timer7Years;
        private System.Windows.Forms.Panel panelDMandGM;
        private System.Windows.Forms.Button btnSeeResupplyRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVId;
        private System.Windows.Forms.Button btnDaysOffRequests;
        private System.Windows.Forms.Panel panelHRorGM;
    }
}