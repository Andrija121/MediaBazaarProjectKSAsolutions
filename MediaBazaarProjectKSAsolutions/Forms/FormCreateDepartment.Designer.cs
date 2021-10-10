
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
            this.lblDepartmentName.Location = new System.Drawing.Point(61, 149);
            this.lblDepartmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(159, 25);
            this.lblDepartmentName.TabIndex = 18;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 54);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add Department ";
            // 
            // tbxNewDepartmentName
            // 
            this.tbxNewDepartmentName.Location = new System.Drawing.Point(248, 145);
            this.tbxNewDepartmentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNewDepartmentName.Name = "tbxNewDepartmentName";
            this.tbxNewDepartmentName.Size = new System.Drawing.Size(273, 31);
            this.tbxNewDepartmentName.TabIndex = 16;
            // 
            // btnAddDepartmentConfirmation
            // 
            this.btnAddDepartmentConfirmation.Location = new System.Drawing.Point(248, 284);
            this.btnAddDepartmentConfirmation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDepartmentConfirmation.Name = "btnAddDepartmentConfirmation";
            this.btnAddDepartmentConfirmation.Size = new System.Drawing.Size(130, 48);
            this.btnAddDepartmentConfirmation.TabIndex = 15;
            this.btnAddDepartmentConfirmation.Text = "Add";
            this.btnAddDepartmentConfirmation.UseVisualStyleBackColor = true;
            this.btnAddDepartmentConfirmation.Click += new System.EventHandler(this.btnAddDepartmentConfirmation_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(248, 211);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(273, 33);
            this.cbStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(61, 219);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 25);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status";
            // 
            // FormCreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 346);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNewDepartmentName);
            this.Controls.Add(this.btnAddDepartmentConfirmation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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