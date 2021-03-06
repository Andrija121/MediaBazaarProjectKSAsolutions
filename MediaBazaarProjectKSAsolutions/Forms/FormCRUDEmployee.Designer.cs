
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
            this.timer7Years = new System.Windows.Forms.Timer(this.components);
            this.panelDMandGM = new System.Windows.Forms.Panel();
            this.btnSeeResupplyRequests = new System.Windows.Forms.Button();
            this.DGVId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDaysOffRequests = new System.Windows.Forms.Button();
            this.panelHRorGM = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPage.SuspendLayout();
            this.panelDMandGM.SuspendLayout();
            this.panelHRorGM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(886, 485);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 27);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelPage
            // 
            this.panelPage.BackColor = System.Drawing.Color.DarkOrchid;
            this.panelPage.Controls.Add(this.lblPage);
            this.panelPage.Location = new System.Drawing.Point(0, 8);
            this.panelPage.Margin = new System.Windows.Forms.Padding(2);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(246, 64);
            this.panelPage.TabIndex = 17;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPage.Location = new System.Drawing.Point(18, 14);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(210, 37);
            this.lblPage.TabIndex = 18;
            this.lblPage.Text = "Employees Page";
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 15;
            this.lbUsers.Location = new System.Drawing.Point(44, 134);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(859, 289);
            this.lbUsers.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddUser.Location = new System.Drawing.Point(44, 89);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(148, 40);
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
            this.btnEdit.Location = new System.Drawing.Point(265, 90);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 40);
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
            this.btnMakeUserInactive.Location = new System.Drawing.Point(516, 90);
            this.btnMakeUserInactive.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeUserInactive.Name = "btnMakeUserInactive";
            this.btnMakeUserInactive.Size = new System.Drawing.Size(148, 40);
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
            this.btnSeeInactiveUsers.Location = new System.Drawing.Point(747, 89);
            this.btnSeeInactiveUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeInactiveUsers.Name = "btnSeeInactiveUsers";
            this.btnSeeInactiveUsers.Size = new System.Drawing.Size(173, 40);
            this.btnSeeInactiveUsers.TabIndex = 6;
            this.btnSeeInactiveUsers.Text = "Inactive and Away Users";
            this.btnSeeInactiveUsers.UseVisualStyleBackColor = false;
            this.btnSeeInactiveUsers.Click += new System.EventHandler(this.btnSeeInactiveUsers_Click);
            // 
            // panelDMandGM
            // 
            this.panelDMandGM.Controls.Add(this.btnSeeResupplyRequests);
            this.panelDMandGM.Enabled = false;
            this.panelDMandGM.Location = new System.Drawing.Point(296, 8);
            this.panelDMandGM.Margin = new System.Windows.Forms.Padding(2);
            this.panelDMandGM.Name = "panelDMandGM";
            this.panelDMandGM.Size = new System.Drawing.Size(196, 56);
            this.panelDMandGM.TabIndex = 18;
            this.panelDMandGM.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDMandGM_Paint);
            // 
            // btnSeeResupplyRequests
            // 
            this.btnSeeResupplyRequests.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSeeResupplyRequests.FlatAppearance.BorderSize = 0;
            this.btnSeeResupplyRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeResupplyRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeResupplyRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeeResupplyRequests.Location = new System.Drawing.Point(2, 8);
            this.btnSeeResupplyRequests.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeResupplyRequests.Name = "btnSeeResupplyRequests";
            this.btnSeeResupplyRequests.Size = new System.Drawing.Size(192, 40);
            this.btnSeeResupplyRequests.TabIndex = 4;
            this.btnSeeResupplyRequests.Text = "Make Resupply Request";
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
            this.btnDaysOffRequests.Location = new System.Drawing.Point(2, 6);
            this.btnDaysOffRequests.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaysOffRequests.Name = "btnDaysOffRequests";
            this.btnDaysOffRequests.Size = new System.Drawing.Size(192, 40);
            this.btnDaysOffRequests.TabIndex = 5;
            this.btnDaysOffRequests.Text = "See Days off Requests";
            this.btnDaysOffRequests.UseVisualStyleBackColor = false;
            this.btnDaysOffRequests.Click += new System.EventHandler(this.btnDaysOffRequests_Click);
            // 
            // panelHRorGM
            // 
            this.panelHRorGM.Controls.Add(this.btnDaysOffRequests);
            this.panelHRorGM.Enabled = false;
            this.panelHRorGM.Location = new System.Drawing.Point(516, 9);
            this.panelHRorGM.Margin = new System.Windows.Forms.Padding(2);
            this.panelHRorGM.Name = "panelHRorGM";
            this.panelHRorGM.Size = new System.Drawing.Size(196, 56);
            this.panelHRorGM.TabIndex = 19;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.FirstName,
            this.LastName,
            this.Password,
            this.Email,
            this.Birthday,
            this.BSN,
            this.Address,
            this.ZipCode,
            this.Gender,
            this.Role});
            this.dgvUsers.Location = new System.Drawing.Point(25, 134);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 33;
            this.dgvUsers.Size = new System.Drawing.Size(939, 347);
            this.dgvUsers.TabIndex = 20;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Username";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Firstname";
            this.FirstName.MinimumWidth = 8;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Lastname";
            this.LastName.MinimumWidth = 8;
            this.LastName.Name = "LastName";
            this.LastName.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.MinimumWidth = 8;
            this.Birthday.Name = "Birthday";
            this.Birthday.Width = 150;
            // 
            // BSN
            // 
            this.BSN.HeaderText = "BSN";
            this.BSN.MinimumWidth = 8;
            this.BSN.Name = "BSN";
            this.BSN.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // ZipCode
            // 
            this.ZipCode.HeaderText = "ZipCode";
            this.ZipCode.MinimumWidth = 8;
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Width = 150;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            this.Gender.Width = 150;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            this.Role.Width = 150;
            // 
            // FormCRUDEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 523);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panelHRorGM);
            this.Controls.Add(this.panelDMandGM);
            this.Controls.Add(this.btnSeeInactiveUsers);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.btnMakeUserInactive);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lbUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormCRUDEmployee_Load);
            this.panelPage.ResumeLayout(false);
            this.panelPage.PerformLayout();
            this.panelDMandGM.ResumeLayout(false);
            this.panelHRorGM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
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
        private System.Windows.Forms.Timer timer7Years;
        private System.Windows.Forms.Panel panelDMandGM;
        private System.Windows.Forms.Button btnSeeResupplyRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVId;
        private System.Windows.Forms.Button btnDaysOffRequests;
        private System.Windows.Forms.Panel panelHRorGM;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}