
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class EditDepartment
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbEditStatus = new System.Windows.Forms.ComboBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEditDepartmentName = new System.Windows.Forms.TextBox();
            this.btnEditDepartmentConfirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(17, 192);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // cbEditStatus
            // 
            this.cbEditStatus.FormattingEnabled = true;
            this.cbEditStatus.Location = new System.Drawing.Point(167, 186);
            this.cbEditStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbEditStatus.Name = "cbEditStatus";
            this.cbEditStatus.Size = new System.Drawing.Size(219, 28);
            this.cbEditStatus.TabIndex = 25;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDepartmentName.Location = new System.Drawing.Point(17, 136);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(146, 20);
            this.lblDepartmentName.TabIndex = 24;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 46);
            this.label3.TabIndex = 23;
            this.label3.Text = "Edit Department ";
            // 
            // tbxEditDepartmentName
            // 
            this.tbxEditDepartmentName.Location = new System.Drawing.Point(167, 133);
            this.tbxEditDepartmentName.Name = "tbxEditDepartmentName";
            this.tbxEditDepartmentName.Size = new System.Drawing.Size(219, 27);
            this.tbxEditDepartmentName.TabIndex = 22;
            // 
            // btnEditDepartmentConfirmation
            // 
            this.btnEditDepartmentConfirmation.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditDepartmentConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDepartmentConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditDepartmentConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditDepartmentConfirmation.Location = new System.Drawing.Point(167, 244);
            this.btnEditDepartmentConfirmation.Name = "btnEditDepartmentConfirmation";
            this.btnEditDepartmentConfirmation.Size = new System.Drawing.Size(104, 39);
            this.btnEditDepartmentConfirmation.TabIndex = 21;
            this.btnEditDepartmentConfirmation.Text = "Edit";
            this.btnEditDepartmentConfirmation.UseVisualStyleBackColor = false;
            this.btnEditDepartmentConfirmation.Click += new System.EventHandler(this.btnEditDepartmentConfirmation_Click);
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(453, 295);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbEditStatus);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxEditDepartmentName);
            this.Controls.Add(this.btnEditDepartmentConfirmation);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbEditStatus;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEditDepartmentName;
        private System.Windows.Forms.Button btnEditDepartmentConfirmation;
    }
}