
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormCreateDepartment
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
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNewDepartmentName = new System.Windows.Forms.TextBox();
            this.btnAddDepartmentConfirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(49, 119);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(133, 20);
            this.lblDepartmentName.TabIndex = 18;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add Department ";
            // 
            // tbxNewDepartmentName
            // 
            this.tbxNewDepartmentName.Location = new System.Drawing.Point(198, 116);
            this.tbxNewDepartmentName.Name = "tbxNewDepartmentName";
            this.tbxNewDepartmentName.Size = new System.Drawing.Size(219, 27);
            this.tbxNewDepartmentName.TabIndex = 16;
            // 
            // btnAddDepartmentConfirmation
            // 
            this.btnAddDepartmentConfirmation.Location = new System.Drawing.Point(198, 227);
            this.btnAddDepartmentConfirmation.Name = "btnAddDepartmentConfirmation";
            this.btnAddDepartmentConfirmation.Size = new System.Drawing.Size(104, 38);
            this.btnAddDepartmentConfirmation.TabIndex = 15;
            this.btnAddDepartmentConfirmation.Text = "Add";
            this.btnAddDepartmentConfirmation.UseVisualStyleBackColor = true;
            this.btnAddDepartmentConfirmation.Click += new System.EventHandler(this.btnAddDepartmentConfirmation_Click);
            // 
            // FormCreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 277);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNewDepartmentName);
            this.Controls.Add(this.btnAddDepartmentConfirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNewDepartmentName;
        private System.Windows.Forms.Button btnAddDepartmentConfirmation;
    }
}