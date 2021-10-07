
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormEmployee
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
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.btnSeeInactiveUsers = new System.Windows.Forms.Button();
            this.btnMakeUserInactive = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.btnSeeInactiveUsers);
            this.pnlEmployees.Controls.Add(this.btnMakeUserInactive);
            this.pnlEmployees.Controls.Add(this.btnEdit);
            this.pnlEmployees.Controls.Add(this.btnAddUser);
            this.pnlEmployees.Controls.Add(this.lbUsers);
            this.pnlEmployees.Controls.Add(this.dataGridView3);
            this.pnlEmployees.Controls.Add(this.lblEmployees);
            this.pnlEmployees.Location = new System.Drawing.Point(13, 14);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1306, 752);
            this.pnlEmployees.TabIndex = 15;
            // 
            // btnSeeInactiveUsers
            // 
            this.btnSeeInactiveUsers.Location = new System.Drawing.Point(1059, 160);
            this.btnSeeInactiveUsers.Name = "btnSeeInactiveUsers";
            this.btnSeeInactiveUsers.Size = new System.Drawing.Size(211, 66);
            this.btnSeeInactiveUsers.TabIndex = 6;
            this.btnSeeInactiveUsers.Text = "See All Inactive Users";
            this.btnSeeInactiveUsers.UseVisualStyleBackColor = true;
            this.btnSeeInactiveUsers.Click += new System.EventHandler(this.btnSeeInactiveUsers_Click);
            // 
            // btnMakeUserInactive
            // 
            this.btnMakeUserInactive.Location = new System.Drawing.Point(749, 160);
            this.btnMakeUserInactive.Name = "btnMakeUserInactive";
            this.btnMakeUserInactive.Size = new System.Drawing.Size(211, 66);
            this.btnMakeUserInactive.TabIndex = 5;
            this.btnMakeUserInactive.Text = "Make User Inactive";
            this.btnMakeUserInactive.UseVisualStyleBackColor = true;
            this.btnMakeUserInactive.Click += new System.EventHandler(this.btnMakeUserInactive_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(374, 160);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(211, 66);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit User";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(33, 160);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(211, 66);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 25;
            this.lbUsers.Location = new System.Drawing.Point(33, 232);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(1237, 479);
            this.lbUsers.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(14, 148);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1269, 589);
            this.dataGridView3.TabIndex = 1;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployees.Location = new System.Drawing.Point(536, 27);
            this.lblEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(212, 54);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "Employees";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1207, 774);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 825);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployee";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnMakeUserInactive;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSeeInactiveUsers;
        private System.Windows.Forms.Button btnBack;
    }
}