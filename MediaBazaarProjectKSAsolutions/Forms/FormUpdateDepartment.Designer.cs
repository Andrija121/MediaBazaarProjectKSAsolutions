
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDepartmentName.Location = new System.Drawing.Point(50, 90);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(123, 17);
            this.lblDepartmentName.TabIndex = 22;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(84, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "Update Department ";
            // 
            // tbxUpdateDepartmentName
            // 
            this.tbxUpdateDepartmentName.Location = new System.Drawing.Point(181, 88);
            this.tbxUpdateDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUpdateDepartmentName.Name = "tbxUpdateDepartmentName";
            this.tbxUpdateDepartmentName.Size = new System.Drawing.Size(192, 23);
            this.tbxUpdateDepartmentName.TabIndex = 20;
            // 
            // btnUpdateDepartmentConfirmation
            // 
            this.btnUpdateDepartmentConfirmation.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnUpdateDepartmentConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDepartmentConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateDepartmentConfirmation.Location = new System.Drawing.Point(181, 171);
            this.btnUpdateDepartmentConfirmation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDepartmentConfirmation.Name = "btnUpdateDepartmentConfirmation";
            this.btnUpdateDepartmentConfirmation.Size = new System.Drawing.Size(91, 29);
            this.btnUpdateDepartmentConfirmation.TabIndex = 19;
            this.btnUpdateDepartmentConfirmation.Text = "Update";
            this.btnUpdateDepartmentConfirmation.UseVisualStyleBackColor = false;
            this.btnUpdateDepartmentConfirmation.Click += new System.EventHandler(this.btnUpdateDepartmentConfirmation_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(50, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(181, 127);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(192, 23);
            this.cbStatus.TabIndex = 23;
            // 
            // FormUpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(421, 208);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxUpdateDepartmentName);
            this.Controls.Add(this.btnUpdateDepartmentConfirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUpdateDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateDepartment";
            this.Load += new System.EventHandler(this.FormUpdateDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUpdateDepartmentName;
        private System.Windows.Forms.Button btnUpdateDepartmentConfirmation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}