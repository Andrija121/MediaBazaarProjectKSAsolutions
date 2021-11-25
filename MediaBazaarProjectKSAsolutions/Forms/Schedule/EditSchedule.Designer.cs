
namespace MediaBazaarProjectKSAsolutions.Forms.Schedule
{
    partial class EditSchedule
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
            this.cbxSchedule_Type = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUser_Id = new System.Windows.Forms.TextBox();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.DTPSchedule = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbxSchedule_Type
            // 
            this.cbxSchedule_Type.FormattingEnabled = true;
            this.cbxSchedule_Type.Items.AddRange(new object[] {
            "MORNING,",
            "AFTERNOON,",
            "EVENING,",
            "AVAILABLE"});
            this.cbxSchedule_Type.Location = new System.Drawing.Point(171, 163);
            this.cbxSchedule_Type.Name = "cbxSchedule_Type";
            this.cbxSchedule_Type.Size = new System.Drawing.Size(219, 28);
            this.cbxSchedule_Type.TabIndex = 36;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(286, 227);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 37);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(52, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Shift_Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(52, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Shift_Date";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDepartmentName.Location = new System.Drawing.Point(52, 98);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(67, 20);
            this.lblDepartmentName.TabIndex = 31;
            this.lblDepartmentName.Text = "User_Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(155, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 46);
            this.label3.TabIndex = 30;
            this.label3.Text = "Edit Schedule";
            // 
            // tbxUser_Id
            // 
            this.tbxUser_Id.Location = new System.Drawing.Point(171, 95);
            this.tbxUser_Id.Name = "tbxUser_Id";
            this.tbxUser_Id.Size = new System.Drawing.Size(219, 27);
            this.tbxUser_Id.TabIndex = 29;
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditSchedule.Location = new System.Drawing.Point(116, 227);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(104, 37);
            this.btnEditSchedule.TabIndex = 28;
            this.btnEditSchedule.Text = "Edit";
            this.btnEditSchedule.UseVisualStyleBackColor = false;
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // DTPSchedule
            // 
            this.DTPSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTPSchedule.Location = new System.Drawing.Point(171, 131);
            this.DTPSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.DTPSchedule.Name = "DTPSchedule";
            this.DTPSchedule.Size = new System.Drawing.Size(268, 26);
            this.DTPSchedule.TabIndex = 37;
            // 
            // EditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(443, 293);
            this.Controls.Add(this.DTPSchedule);
            this.Controls.Add(this.cbxSchedule_Type);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxUser_Id);
            this.Controls.Add(this.btnEditSchedule);
            this.Name = "EditSchedule";
            this.Text = "EditSchedule";
            this.Load += new System.EventHandler(this.EditSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSchedule_Type;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUser_Id;
        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.DateTimePicker DTPSchedule;
    }
}