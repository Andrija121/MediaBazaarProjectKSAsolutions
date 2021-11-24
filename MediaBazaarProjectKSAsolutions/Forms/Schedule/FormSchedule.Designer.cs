
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormSchedule
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
            this.Stock = new System.Windows.Forms.Label();
            this.btnRefreshSchedule = new System.Windows.Forms.Button();
            this.btnCreateSchedule = new System.Windows.Forms.Button();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnDelSchedule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftDateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Left = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateRight = new System.Windows.Forms.TextBox();
            this.monthLeft = new System.Windows.Forms.TextBox();
            this.yearRight = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateCenter = new System.Windows.Forms.TextBox();
            this.monthCenter = new System.Windows.Forms.TextBox();
            this.yearCenter = new System.Windows.Forms.TextBox();
            this.Right = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateLeft = new System.Windows.Forms.TextBox();
            this.monthRight = new System.Windows.Forms.TextBox();
            this.yearLeft = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlEmployees.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(449, 10);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(160, 39);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Schedule";
            // 
            // btnRefreshSchedule
            // 
            this.btnRefreshSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRefreshSchedule.FlatAppearance.BorderSize = 0;
            this.btnRefreshSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefreshSchedule.Location = new System.Drawing.Point(177, 364);
            this.btnRefreshSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshSchedule.Name = "btnRefreshSchedule";
            this.btnRefreshSchedule.Size = new System.Drawing.Size(132, 42);
            this.btnRefreshSchedule.TabIndex = 2;
            this.btnRefreshSchedule.Text = "Refresh";
            this.btnRefreshSchedule.UseVisualStyleBackColor = false;
            this.btnRefreshSchedule.Click += new System.EventHandler(this.btnRefreshSchedule_Click);
            // 
            // btnCreateSchedule
            // 
            this.btnCreateSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCreateSchedule.FlatAppearance.BorderSize = 0;
            this.btnCreateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateSchedule.Location = new System.Drawing.Point(356, 364);
            this.btnCreateSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(146, 42);
            this.btnCreateSchedule.TabIndex = 3;
            this.btnCreateSchedule.Text = "Create Schedule";
            this.btnCreateSchedule.UseVisualStyleBackColor = false;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click);
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditSchedule.FlatAppearance.BorderSize = 0;
            this.btnEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditSchedule.Location = new System.Drawing.Point(537, 364);
            this.btnEditSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(132, 42);
            this.btnEditSchedule.TabIndex = 4;
            this.btnEditSchedule.Text = "Edit Schedule";
            this.btnEditSchedule.UseVisualStyleBackColor = false;
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // btnDelSchedule
            // 
            this.btnDelSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDelSchedule.FlatAppearance.BorderSize = 0;
            this.btnDelSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelSchedule.Location = new System.Drawing.Point(718, 364);
            this.btnDelSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelSchedule.Name = "btnDelSchedule";
            this.btnDelSchedule.Size = new System.Drawing.Size(112, 42);
            this.btnDelSchedule.TabIndex = 5;
            this.btnDelSchedule.Text = "Delete Schdeule";
            this.btnDelSchedule.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
            this.ShiftType,
            this.ShiftDateDate});
            this.dataGridView1.Location = new System.Drawing.Point(177, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(653, 371);
            this.dataGridView1.TabIndex = 6;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.MinimumWidth = 6;
            this.Employee.Name = "Employee";
            this.Employee.Width = 200;
            // 
            // ShiftType
            // 
            this.ShiftType.HeaderText = "Type";
            this.ShiftType.MinimumWidth = 6;
            this.ShiftType.Name = "ShiftType";
            this.ShiftType.Width = 200;
            // 
            // ShiftDateDate
            // 
            this.ShiftDateDate.HeaderText = "ShiftDate";
            this.ShiftDateDate.MinimumWidth = 6;
            this.ShiftDateDate.Name = "ShiftDateDate";
            this.ShiftDateDate.Width = 200;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(934, 783);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 38);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.dateTimePicker1);
            this.pnlEmployees.Controls.Add(this.label1);
            this.pnlEmployees.Controls.Add(this.panel4);
            this.pnlEmployees.Controls.Add(this.btnBack);
            this.pnlEmployees.Controls.Add(this.dataGridView1);
            this.pnlEmployees.Controls.Add(this.btnDelSchedule);
            this.pnlEmployees.Controls.Add(this.btnEditSchedule);
            this.pnlEmployees.Controls.Add(this.btnCreateSchedule);
            this.pnlEmployees.Controls.Add(this.btnRefreshSchedule);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(7, 13);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1126, 850);
            this.pnlEmployees.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(498, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Jump to:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Left);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.Right);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(186, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 178);
            this.panel4.TabIndex = 30;
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(37, 68);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(44, 29);
            this.Left.TabIndex = 16;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.dateRight);
            this.panel1.Controls.Add(this.monthLeft);
            this.panel1.Controls.Add(this.yearRight);
            this.panel1.Location = new System.Drawing.Point(111, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 125);
            this.panel1.TabIndex = 27;
            // 
            // dateRight
            // 
            this.dateRight.Location = new System.Drawing.Point(24, 3);
            this.dateRight.Name = "dateRight";
            this.dateRight.Size = new System.Drawing.Size(43, 27);
            this.dateRight.TabIndex = 18;
            this.dateRight.Text = "02";
            this.dateRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthLeft
            // 
            this.monthLeft.Location = new System.Drawing.Point(24, 36);
            this.monthLeft.Name = "monthLeft";
            this.monthLeft.Size = new System.Drawing.Size(43, 27);
            this.monthLeft.TabIndex = 21;
            this.monthLeft.Text = "NOV";
            this.monthLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearRight
            // 
            this.yearRight.Location = new System.Drawing.Point(24, 78);
            this.yearRight.Name = "yearRight";
            this.yearRight.Size = new System.Drawing.Size(43, 27);
            this.yearRight.TabIndex = 24;
            this.yearRight.Text = "2021";
            this.yearRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.dateCenter);
            this.panel3.Controls.Add(this.monthCenter);
            this.panel3.Controls.Add(this.yearCenter);
            this.panel3.Location = new System.Drawing.Point(280, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 125);
            this.panel3.TabIndex = 29;
            // 
            // dateCenter
            // 
            this.dateCenter.Location = new System.Drawing.Point(23, 3);
            this.dateCenter.Name = "dateCenter";
            this.dateCenter.Size = new System.Drawing.Size(43, 27);
            this.dateCenter.TabIndex = 19;
            this.dateCenter.Text = "03";
            this.dateCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthCenter
            // 
            this.monthCenter.Location = new System.Drawing.Point(23, 36);
            this.monthCenter.Name = "monthCenter";
            this.monthCenter.Size = new System.Drawing.Size(43, 27);
            this.monthCenter.TabIndex = 22;
            this.monthCenter.Text = "NOV";
            this.monthCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearCenter
            // 
            this.yearCenter.Location = new System.Drawing.Point(23, 78);
            this.yearCenter.Name = "yearCenter";
            this.yearCenter.Size = new System.Drawing.Size(43, 27);
            this.yearCenter.TabIndex = 25;
            this.yearCenter.Text = "2021";
            this.yearCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(571, 69);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(43, 29);
            this.Right.TabIndex = 17;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.dateLeft);
            this.panel2.Controls.Add(this.monthRight);
            this.panel2.Controls.Add(this.yearLeft);
            this.panel2.Location = new System.Drawing.Point(450, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 125);
            this.panel2.TabIndex = 28;
            // 
            // dateLeft
            // 
            this.dateLeft.Location = new System.Drawing.Point(30, 14);
            this.dateLeft.Name = "dateLeft";
            this.dateLeft.Size = new System.Drawing.Size(43, 27);
            this.dateLeft.TabIndex = 20;
            this.dateLeft.Text = "04";
            // 
            // monthRight
            // 
            this.monthRight.Location = new System.Drawing.Point(30, 47);
            this.monthRight.Name = "monthRight";
            this.monthRight.Size = new System.Drawing.Size(43, 27);
            this.monthRight.TabIndex = 23;
            this.monthRight.Text = "NOV";
            this.monthRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yearLeft
            // 
            this.yearLeft.Location = new System.Drawing.Point(30, 89);
            this.yearLeft.Name = "yearLeft";
            this.yearLeft.Size = new System.Drawing.Size(43, 27);
            this.yearLeft.TabIndex = 26;
            this.yearLeft.Text = "2021";
            this.yearLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 846);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Button btnRefreshSchedule;
        private System.Windows.Forms.Button btnCreateSchedule;
        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.Button btnDelSchedule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftDateDate;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dateRight;
        private System.Windows.Forms.TextBox monthLeft;
        private System.Windows.Forms.TextBox yearRight;
        private System.Windows.Forms.TextBox yearLeft;
        private System.Windows.Forms.TextBox yearCenter;
        private System.Windows.Forms.TextBox monthRight;
        private System.Windows.Forms.TextBox monthCenter;
        private System.Windows.Forms.TextBox dateLeft;
        private System.Windows.Forms.TextBox dateCenter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}