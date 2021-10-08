
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
            this.pnlEmployees.Location = new System.Drawing.Point(12, 14);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1320, 541);
            this.pnlEmployees.TabIndex = 12;
            // 
            // lbDepartments
            // 
            this.lbDepartments.FormattingEnabled = true;
            this.lbDepartments.ItemHeight = 25;
            this.lbDepartments.Location = new System.Drawing.Point(62, 216);
            this.lbDepartments.Margin = new System.Windows.Forms.Padding(2);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.Size = new System.Drawing.Size(1172, 279);
            this.lbDepartments.TabIndex = 10;
            // 
            // btnDelDepartment
            // 
            this.btnDelDepartment.Location = new System.Drawing.Point(1025, 149);
            this.btnDelDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelDepartment.Name = "btnDelDepartment";
            this.btnDelDepartment.Size = new System.Drawing.Size(278, 39);
            this.btnDelDepartment.TabIndex = 9;
            this.btnDelDepartment.Text = "Delete Department";
            this.btnDelDepartment.UseVisualStyleBackColor = true;
            this.btnDelDepartment.Click += new System.EventHandler(this.btnDelDepartment_Click);
            // 
            // btnEditDepartments
            // 
            this.btnEditDepartments.Location = new System.Drawing.Point(686, 149);
            this.btnEditDepartments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditDepartments.Name = "btnEditDepartments";
            this.btnEditDepartments.Size = new System.Drawing.Size(278, 39);
            this.btnEditDepartments.TabIndex = 8;
            this.btnEditDepartments.Text = "Edit Department";
            this.btnEditDepartments.UseVisualStyleBackColor = true;
            this.btnEditDepartments.Click += new System.EventHandler(this.btnEditDepartments_Click);
            // 
            // btnCreateDepartments
            // 
            this.btnCreateDepartments.Location = new System.Drawing.Point(346, 149);
            this.btnCreateDepartments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateDepartments.Name = "btnCreateDepartments";
            this.btnCreateDepartments.Size = new System.Drawing.Size(278, 39);
            this.btnCreateDepartments.TabIndex = 7;
            this.btnCreateDepartments.Text = "Create Department";
            this.btnCreateDepartments.UseVisualStyleBackColor = true;
            this.btnCreateDepartments.Click += new System.EventHandler(this.btnCreateDepartments_Click);
            // 
            // btnRefreshDepartments
            // 
            this.btnRefreshDepartments.Location = new System.Drawing.Point(18, 149);
            this.btnRefreshDepartments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshDepartments.Name = "btnRefreshDepartments";
            this.btnRefreshDepartments.Size = new System.Drawing.Size(278, 39);
            this.btnRefreshDepartments.TabIndex = 6;
            this.btnRefreshDepartments.Text = "Refresh";
            this.btnRefreshDepartments.UseVisualStyleBackColor = true;
            this.btnRefreshDepartments.Click += new System.EventHandler(this.btnRefreshDepartments_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(18, 198);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1285, 324);
            this.dataGridView3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(536, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departments";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1188, 562);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 52);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 628);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartment";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
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