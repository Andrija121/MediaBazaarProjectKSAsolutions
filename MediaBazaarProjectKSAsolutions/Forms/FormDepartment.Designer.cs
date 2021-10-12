
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormDepartment
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
            this.lbDepartments = new System.Windows.Forms.ListBox();
            this.btnDelDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartments = new System.Windows.Forms.Button();
            this.btnCreateDepartments = new System.Windows.Forms.Button();
            this.btnRefreshDepartments = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSeeInactiveUsers = new System.Windows.Forms.Button();
            this.pnlEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.btnSeeInactiveUsers);
            this.pnlEmployees.Controls.Add(this.lbDepartments);
            this.pnlEmployees.Controls.Add(this.btnDelDepartment);
            this.pnlEmployees.Controls.Add(this.btnEditDepartments);
            this.pnlEmployees.Controls.Add(this.btnCreateDepartments);
            this.pnlEmployees.Controls.Add(this.btnRefreshDepartments);
            this.pnlEmployees.Controls.Add(this.label3);
            this.pnlEmployees.Location = new System.Drawing.Point(11, 13);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1321, 540);
            this.pnlEmployees.TabIndex = 12;
            // 
            // lbDepartments
            // 
            this.lbDepartments.FormattingEnabled = true;
            this.lbDepartments.ItemHeight = 25;
            this.lbDepartments.Location = new System.Drawing.Point(19, 217);
            this.lbDepartments.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.Size = new System.Drawing.Size(1284, 279);
            this.lbDepartments.TabIndex = 10;
            // 
            // btnDelDepartment
            // 
            this.btnDelDepartment.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDelDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelDepartment.Location = new System.Drawing.Point(833, 127);
            this.btnDelDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelDepartment.Name = "btnDelDepartment";
            this.btnDelDepartment.Size = new System.Drawing.Size(203, 60);
            this.btnDelDepartment.TabIndex = 9;
            this.btnDelDepartment.Text = "Delete Department";
            this.btnDelDepartment.UseVisualStyleBackColor = false;
            this.btnDelDepartment.Click += new System.EventHandler(this.btnDelDepartment_Click);
            // 
            // btnEditDepartments
            // 
            this.btnEditDepartments.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditDepartments.Location = new System.Drawing.Point(571, 127);
            this.btnEditDepartments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditDepartments.Name = "btnEditDepartments";
            this.btnEditDepartments.Size = new System.Drawing.Size(203, 60);
            this.btnEditDepartments.TabIndex = 8;
            this.btnEditDepartments.Text = "Edit Department";
            this.btnEditDepartments.UseVisualStyleBackColor = false;
            this.btnEditDepartments.Click += new System.EventHandler(this.btnEditDepartments_Click);
            // 
            // btnCreateDepartments
            // 
            this.btnCreateDepartments.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCreateDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateDepartments.Location = new System.Drawing.Point(284, 127);
            this.btnCreateDepartments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateDepartments.Name = "btnCreateDepartments";
            this.btnCreateDepartments.Size = new System.Drawing.Size(203, 60);
            this.btnCreateDepartments.TabIndex = 7;
            this.btnCreateDepartments.Text = "Create Department";
            this.btnCreateDepartments.UseVisualStyleBackColor = false;
            this.btnCreateDepartments.Click += new System.EventHandler(this.btnCreateDepartments_Click);
            // 
            // btnRefreshDepartments
            // 
            this.btnRefreshDepartments.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRefreshDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefreshDepartments.Location = new System.Drawing.Point(19, 127);
            this.btnRefreshDepartments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshDepartments.Name = "btnRefreshDepartments";
            this.btnRefreshDepartments.Size = new System.Drawing.Size(203, 60);
            this.btnRefreshDepartments.TabIndex = 6;
            this.btnRefreshDepartments.Text = "Refresh";
            this.btnRefreshDepartments.UseVisualStyleBackColor = false;
            this.btnRefreshDepartments.Click += new System.EventHandler(this.btnRefreshDepartments_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(536, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departments";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(1189, 562);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 52);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSeeInactiveUsers
            // 
            this.btnSeeInactiveUsers.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSeeInactiveUsers.FlatAppearance.BorderSize = 0;
            this.btnSeeInactiveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeInactiveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeInactiveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeeInactiveUsers.Location = new System.Drawing.Point(1109, 127);
            this.btnSeeInactiveUsers.Name = "btnSeeInactiveUsers";
            this.btnSeeInactiveUsers.Size = new System.Drawing.Size(186, 60);
            this.btnSeeInactiveUsers.TabIndex = 11;
            this.btnSeeInactiveUsers.Text = "See All Inactive Departments";
            this.btnSeeInactiveUsers.UseVisualStyleBackColor = false;
            this.btnSeeInactiveUsers.Click += new System.EventHandler(this.btnSeeInactiveUsers_Click);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1346, 628);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartment";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelDepartment;
        private System.Windows.Forms.Button btnEditDepartments;
        private System.Windows.Forms.Button btnCreateDepartments;
        private System.Windows.Forms.Button btnRefreshDepartments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbDepartments;
        private System.Windows.Forms.Button btnSeeInactiveUsers;
    }
}