
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
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDepartmentName.Location = new System.Drawing.Point(43, 89);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(123, 17);
            this.lblDepartmentName.TabIndex = 18;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(92, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add Department ";
            // 
            // tbxNewDepartmentName
            // 
            this.tbxNewDepartmentName.Location = new System.Drawing.Point(174, 87);
            this.tbxNewDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNewDepartmentName.Name = "tbxNewDepartmentName";
            this.tbxNewDepartmentName.Size = new System.Drawing.Size(192, 23);
            this.tbxNewDepartmentName.TabIndex = 16;
            // 
            // btnAddDepartmentConfirmation
            // 
            this.btnAddDepartmentConfirmation.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAddDepartmentConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartmentConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDepartmentConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddDepartmentConfirmation.Location = new System.Drawing.Point(174, 170);
            this.btnAddDepartmentConfirmation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDepartmentConfirmation.Name = "btnAddDepartmentConfirmation";
            this.btnAddDepartmentConfirmation.Size = new System.Drawing.Size(91, 29);
            this.btnAddDepartmentConfirmation.TabIndex = 15;
            this.btnAddDepartmentConfirmation.Text = "Add";
            this.btnAddDepartmentConfirmation.UseVisualStyleBackColor = false;
            this.btnAddDepartmentConfirmation.Click += new System.EventHandler(this.btnAddDepartmentConfirmation_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(174, 127);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(192, 23);
            this.cbStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStatus.Location = new System.Drawing.Point(43, 131);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status";
            // 
            // FormCreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(421, 208);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNewDepartmentName);
            this.Controls.Add(this.btnAddDepartmentConfirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}