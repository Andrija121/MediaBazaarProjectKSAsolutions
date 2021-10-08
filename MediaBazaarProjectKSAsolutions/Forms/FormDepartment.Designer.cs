
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.lbDepartments);
            this.pnlEmployees.Controls.Add(this.btnDelDepartment);
            this.pnlEmployees.Controls.Add(this.btnEditDepartments);
            this.pnlEmployees.Controls.Add(this.btnCreateDepartments);
            this.pnlEmployees.Controls.Add(this.btnRefreshDepartments);
            this.pnlEmployees.Controls.Add(this.dataGridView3);
            this.pnlEmployees.Controls.Add(this.label3);
            this.pnlEmployees.Location = new System.Drawing.Point(10, 11);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1056, 433);
            this.pnlEmployees.TabIndex = 12;
            // 
            // lbDepartments
            // 
            this.lbDepartments.FormattingEnabled = true;
            this.lbDepartments.ItemHeight = 20;
            this.lbDepartments.Location = new System.Drawing.Point(50, 173);
            this.lbDepartments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.Size = new System.Drawing.Size(938, 224);
            this.lbDepartments.TabIndex = 10;
            // 
            // btnDelDepartment
            // 
            this.btnDelDepartment.Location = new System.Drawing.Point(820, 119);
            this.btnDelDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelDepartment.Name = "btnDelDepartment";
            this.btnDelDepartment.Size = new System.Drawing.Size(222, 31);
            this.btnDelDepartment.TabIndex = 9;
            this.btnDelDepartment.Text = "Delete Department";
            this.btnDelDepartment.UseVisualStyleBackColor = true;
            // 
            // btnEditDepartments
            // 
            this.btnEditDepartments.Location = new System.Drawing.Point(549, 119);
            this.btnEditDepartments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditDepartments.Name = "btnEditDepartments";
            this.btnEditDepartments.Size = new System.Drawing.Size(222, 31);
            this.btnEditDepartments.TabIndex = 8;
            this.btnEditDepartments.Text = "Edit Department";
            this.btnEditDepartments.UseVisualStyleBackColor = true;
            this.btnEditDepartments.Click += new System.EventHandler(this.btnEditDepartments_Click);
            // 
            // btnCreateDepartments
            // 
            this.btnCreateDepartments.Location = new System.Drawing.Point(277, 119);
            this.btnCreateDepartments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateDepartments.Name = "btnCreateDepartments";
            this.btnCreateDepartments.Size = new System.Drawing.Size(222, 31);
            this.btnCreateDepartments.TabIndex = 7;
            this.btnCreateDepartments.Text = "Create Department";
            this.btnCreateDepartments.UseVisualStyleBackColor = true;
            this.btnCreateDepartments.Click += new System.EventHandler(this.btnCreateDepartments_Click);
            // 
            // btnRefreshDepartments
            // 
            this.btnRefreshDepartments.Location = new System.Drawing.Point(14, 119);
            this.btnRefreshDepartments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshDepartments.Name = "btnRefreshDepartments";
            this.btnRefreshDepartments.Size = new System.Drawing.Size(222, 31);
            this.btnRefreshDepartments.TabIndex = 6;
            this.btnRefreshDepartments.Text = "Refresh";
            this.btnRefreshDepartments.UseVisualStyleBackColor = true;
            this.btnRefreshDepartments.Click += new System.EventHandler(this.btnRefreshDepartments_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(14, 158);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1028, 259);
            this.dataGridView3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(429, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departments";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(950, 450);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 502);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartment";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnDelDepartment;
        private System.Windows.Forms.Button btnEditDepartments;
        private System.Windows.Forms.Button btnCreateDepartments;
        private System.Windows.Forms.Button btnRefreshDepartments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbDepartments;
    }
}