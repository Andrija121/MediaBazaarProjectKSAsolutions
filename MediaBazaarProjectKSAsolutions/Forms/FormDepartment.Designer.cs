
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
            this.btnSeeInactiveUsers = new System.Windows.Forms.Button();
            this.lbDepartments = new System.Windows.Forms.ListBox();
            this.btnDelDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartments = new System.Windows.Forms.Button();
            this.btnCreateDepartments = new System.Windows.Forms.Button();
            this.btnRefreshDepartments = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.pnlEmployees.Location = new System.Drawing.Point(8, 8);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(925, 325);
            this.pnlEmployees.TabIndex = 12;
            this.pnlEmployees.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployees_Paint);
            // 
            // btnSeeInactiveUsers
            // 
            this.btnSeeInactiveUsers.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSeeInactiveUsers.FlatAppearance.BorderSize = 0;
            this.btnSeeInactiveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeInactiveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeeInactiveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeeInactiveUsers.Location = new System.Drawing.Point(776, 76);
            this.btnSeeInactiveUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeeInactiveUsers.Name = "btnSeeInactiveUsers";
            this.btnSeeInactiveUsers.Size = new System.Drawing.Size(130, 36);
            this.btnSeeInactiveUsers.TabIndex = 11;
            this.btnSeeInactiveUsers.Text = "See All Inactive Departments";
            this.btnSeeInactiveUsers.UseVisualStyleBackColor = false;
            this.btnSeeInactiveUsers.Click += new System.EventHandler(this.btnSeeInactiveUsers_Click);
            // 
            // lbDepartments
            // 
            this.lbDepartments.FormattingEnabled = true;
            this.lbDepartments.ItemHeight = 15;
            this.lbDepartments.Location = new System.Drawing.Point(13, 130);
            this.lbDepartments.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.Size = new System.Drawing.Size(900, 169);
            this.lbDepartments.TabIndex = 10;
            // 
            // btnDelDepartment
            // 
            this.btnDelDepartment.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDelDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelDepartment.Location = new System.Drawing.Point(583, 76);
            this.btnDelDepartment.Name = "btnDelDepartment";
            this.btnDelDepartment.Size = new System.Drawing.Size(142, 36);
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
            this.btnEditDepartments.Location = new System.Drawing.Point(400, 76);
            this.btnEditDepartments.Name = "btnEditDepartments";
            this.btnEditDepartments.Size = new System.Drawing.Size(142, 36);
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
            this.btnCreateDepartments.Location = new System.Drawing.Point(199, 76);
            this.btnCreateDepartments.Name = "btnCreateDepartments";
            this.btnCreateDepartments.Size = new System.Drawing.Size(142, 36);
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
            this.btnRefreshDepartments.Location = new System.Drawing.Point(13, 76);
            this.btnRefreshDepartments.Name = "btnRefreshDepartments";
            this.btnRefreshDepartments.Size = new System.Drawing.Size(142, 36);
            this.btnRefreshDepartments.TabIndex = 6;
            this.btnRefreshDepartments.Text = "Refresh";
            this.btnRefreshDepartments.UseVisualStyleBackColor = false;
            this.btnRefreshDepartments.Click += new System.EventHandler(this.btnRefreshDepartments_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(375, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departments";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(832, 337);
            this.btnBack.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 31);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 377);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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