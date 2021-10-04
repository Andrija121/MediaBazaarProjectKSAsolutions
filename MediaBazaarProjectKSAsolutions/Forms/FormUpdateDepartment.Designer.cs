
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormUpdateDepartment
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
            this.tbxUpdateDepartmentName = new System.Windows.Forms.TextBox();
            this.btnUpdateDepartmentConfirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(57, 120);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(133, 20);
            this.lblDepartmentName.TabIndex = 22;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(96, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 46);
            this.label3.TabIndex = 21;
            this.label3.Text = "Update Department ";
            // 
            // tbxUpdateDepartmentName
            // 
            this.tbxUpdateDepartmentName.Location = new System.Drawing.Point(206, 117);
            this.tbxUpdateDepartmentName.Name = "tbxUpdateDepartmentName";
            this.tbxUpdateDepartmentName.Size = new System.Drawing.Size(219, 27);
            this.tbxUpdateDepartmentName.TabIndex = 20;
            // 
            // btnUpdateDepartmentConfirmation
            // 
            this.btnUpdateDepartmentConfirmation.Location = new System.Drawing.Point(206, 228);
            this.btnUpdateDepartmentConfirmation.Name = "btnUpdateDepartmentConfirmation";
            this.btnUpdateDepartmentConfirmation.Size = new System.Drawing.Size(104, 38);
            this.btnUpdateDepartmentConfirmation.TabIndex = 19;
            this.btnUpdateDepartmentConfirmation.Text = "Update";
            this.btnUpdateDepartmentConfirmation.UseVisualStyleBackColor = true;
            this.btnUpdateDepartmentConfirmation.Click += new System.EventHandler(this.btnUpdateDepartmentConfirmation_Click);
            // 
            // FormUpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 277);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxUpdateDepartmentName);
            this.Controls.Add(this.btnUpdateDepartmentConfirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUpdateDepartmentName;
        private System.Windows.Forms.Button btnUpdateDepartmentConfirmation;
    }
}