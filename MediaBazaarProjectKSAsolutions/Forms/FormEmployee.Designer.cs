
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.btnMakeUserInactive = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.btnMakeUserInactive);
            this.pnlEmployees.Controls.Add(this.btnEdit);
            this.pnlEmployees.Controls.Add(this.btnAddUser);
            this.pnlEmployees.Controls.Add(this.lbUsers);
            this.pnlEmployees.Controls.Add(this.dataGridView3);
            this.pnlEmployees.Controls.Add(this.lblEmployees);
            this.pnlEmployees.Location = new System.Drawing.Point(369, 20);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1305, 1227);
            this.pnlEmployees.TabIndex = 15;
            // 
            // btnMakeUserInactive
            // 
            this.btnMakeUserInactive.Location = new System.Drawing.Point(1059, 160);
            this.btnMakeUserInactive.Name = "btnMakeUserInactive";
            this.btnMakeUserInactive.Size = new System.Drawing.Size(211, 66);
            this.btnMakeUserInactive.TabIndex = 5;
            this.btnMakeUserInactive.Text = "Make User Inactive";
            this.btnMakeUserInactive.UseVisualStyleBackColor = true;
            this.btnMakeUserInactive.Click += new System.EventHandler(this.btnMakeUserInactive_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(536, 160);
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
            this.dataGridView3.Size = new System.Drawing.Size(1269, 1057);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnStatistics);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnDepartments);
            this.panel1.Controls.Add(this.btnStocks);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Location = new System.Drawing.Point(17, 363);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 884);
            this.panel1.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(14, 823);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(314, 38);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(14, 220);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(314, 38);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(14, 170);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(314, 38);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.Location = new System.Drawing.Point(14, 120);
            this.btnDepartments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(314, 38);
            this.btnDepartments.TabIndex = 3;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(14, 70);
            this.btnStocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(314, 38);
            this.btnStocks.TabIndex = 2;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(14, 20);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(314, 38);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 333);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 1050);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnMakeUserInactive;
        private System.Windows.Forms.Button btnEdit;
    }
}