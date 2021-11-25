
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.RightYear = new System.Windows.Forms.TextBox();
            this.RightMonth = new System.Windows.Forms.TextBox();
            this.rightDay = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.middleMonth = new System.Windows.Forms.TextBox();
            this.middleYear = new System.Windows.Forms.TextBox();
            this.middleDay = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yearLeft = new System.Windows.Forms.TextBox();
            this.mothLeft = new System.Windows.Forms.TextBox();
            this.dayLeft = new System.Windows.Forms.TextBox();
            this.dvgShift = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnCreateSchedule = new System.Windows.Forms.Button();
            this.btnRefreshSchedule = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.pnlEmployees.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShift)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(852, 626);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 28);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.label1);
            this.pnlEmployees.Controls.Add(this.dateTimePicker1);
            this.pnlEmployees.Controls.Add(this.panel1);
            this.pnlEmployees.Controls.Add(this.dvgShift);
            this.pnlEmployees.Controls.Add(this.btnDeleteSchedule);
            this.pnlEmployees.Controls.Add(this.btnEditSchedule);
            this.pnlEmployees.Controls.Add(this.btnCreateSchedule);
            this.pnlEmployees.Controls.Add(this.btnRefreshSchedule);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(8, -2);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(924, 616);
            this.pnlEmployees.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jump To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(661, 226);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Right);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(44, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 163);
            this.panel1.TabIndex = 7;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.DarkOrchid;
            this.Right.FlatAppearance.BorderSize = 0;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Right.Location = new System.Drawing.Point(769, 52);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(42, 40);
            this.Right.TabIndex = 12;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.DarkOrchid;
            this.Left.FlatAppearance.BorderSize = 0;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Left.Location = new System.Drawing.Point(37, 52);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(42, 40);
            this.Left.TabIndex = 11;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel12.Controls.Add(this.RightYear);
            this.panel12.Controls.Add(this.RightMonth);
            this.panel12.Controls.Add(this.rightDay);
            this.panel12.Location = new System.Drawing.Point(582, 2);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(125, 140);
            this.panel12.TabIndex = 10;
            // 
            // RightYear
            // 
            this.RightYear.Location = new System.Drawing.Point(30, 97);
            this.RightYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightYear.Name = "RightYear";
            this.RightYear.Size = new System.Drawing.Size(45, 23);
            this.RightYear.TabIndex = 14;
            this.RightYear.Text = "2021";
            this.RightYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RightMonth
            // 
            this.RightMonth.Location = new System.Drawing.Point(30, 63);
            this.RightMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightMonth.Name = "RightMonth";
            this.RightMonth.Size = new System.Drawing.Size(45, 23);
            this.RightMonth.TabIndex = 13;
            this.RightMonth.Text = "NOV";
            this.RightMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rightDay
            // 
            this.rightDay.Location = new System.Drawing.Point(30, 32);
            this.rightDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightDay.Name = "rightDay";
            this.rightDay.Size = new System.Drawing.Size(45, 23);
            this.rightDay.TabIndex = 12;
            this.rightDay.Text = "04";
            this.rightDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.middleMonth);
            this.panel3.Controls.Add(this.middleYear);
            this.panel3.Controls.Add(this.middleDay);
            this.panel3.Location = new System.Drawing.Point(366, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 138);
            this.panel3.TabIndex = 9;
            // 
            // middleMonth
            // 
            this.middleMonth.Location = new System.Drawing.Point(39, 62);
            this.middleMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleMonth.Name = "middleMonth";
            this.middleMonth.Size = new System.Drawing.Size(45, 23);
            this.middleMonth.TabIndex = 17;
            this.middleMonth.Text = "NOV";
            // 
            // middleYear
            // 
            this.middleYear.Location = new System.Drawing.Point(39, 94);
            this.middleYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleYear.Name = "middleYear";
            this.middleYear.Size = new System.Drawing.Size(45, 23);
            this.middleYear.TabIndex = 16;
            this.middleYear.Text = "2021";
            // 
            // middleDay
            // 
            this.middleDay.Location = new System.Drawing.Point(39, 30);
            this.middleDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleDay.Name = "middleDay";
            this.middleDay.Size = new System.Drawing.Size(45, 23);
            this.middleDay.TabIndex = 15;
            this.middleDay.Text = "03";
            this.middleDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.yearLeft);
            this.panel2.Controls.Add(this.mothLeft);
            this.panel2.Controls.Add(this.dayLeft);
            this.panel2.Location = new System.Drawing.Point(129, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 140);
            this.panel2.TabIndex = 8;
            // 
            // yearLeft
            // 
            this.yearLeft.Location = new System.Drawing.Point(44, 97);
            this.yearLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearLeft.Name = "yearLeft";
            this.yearLeft.Size = new System.Drawing.Size(45, 23);
            this.yearLeft.TabIndex = 11;
            this.yearLeft.Text = "2021";
            this.yearLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mothLeft
            // 
            this.mothLeft.Location = new System.Drawing.Point(44, 64);
            this.mothLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mothLeft.Name = "mothLeft";
            this.mothLeft.Size = new System.Drawing.Size(45, 23);
            this.mothLeft.TabIndex = 10;
            this.mothLeft.Text = "NOV";
            this.mothLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dayLeft
            // 
            this.dayLeft.Location = new System.Drawing.Point(44, 32);
            this.dayLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayLeft.Name = "dayLeft";
            this.dayLeft.Size = new System.Drawing.Size(45, 23);
            this.dayLeft.TabIndex = 9;
            this.dayLeft.Text = "02";
            this.dayLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dvgShift
            // 
            this.dvgShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.Shift_Type,
            this.Shift_Date,
            this.dataGridViewTextBoxColumn1});
            this.dvgShift.Location = new System.Drawing.Point(25, 295);
            this.dvgShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgShift.Name = "dvgShift";
            this.dvgShift.RowHeadersWidth = 51;
            this.dvgShift.RowTemplate.Height = 29;
            this.dvgShift.Size = new System.Drawing.Size(836, 320);
            this.dvgShift.TabIndex = 6;
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "User_ID";
            this.User_ID.MinimumWidth = 6;
            this.User_ID.Name = "User_ID";
            this.User_ID.Width = 125;
            // 
            // Shift_Type
            // 
            this.Shift_Type.HeaderText = "Shift_Type";
            this.Shift_Type.MinimumWidth = 6;
            this.Shift_Type.Name = "Shift_Type";
            this.Shift_Type.Width = 125;
            // 
            // Shift_Date
            // 
            this.Shift_Date.HeaderText = "Shift_Date";
            this.Shift_Date.MinimumWidth = 6;
            this.Shift_Date.Name = "Shift_Date";
            this.Shift_Date.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Shift-ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDeleteSchedule.FlatAppearance.BorderSize = 0;
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteSchedule.Location = new System.Drawing.Point(685, 258);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(194, 32);
            this.btnDeleteSchedule.TabIndex = 5;
            this.btnDeleteSchedule.Text = "Delete Schdeule";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditSchedule.FlatAppearance.BorderSize = 0;
            this.btnEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditSchedule.Location = new System.Drawing.Point(470, 258);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(194, 32);
            this.btnEditSchedule.TabIndex = 4;
            this.btnEditSchedule.Text = "Edit Schedule";
            this.btnEditSchedule.UseVisualStyleBackColor = false;
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // btnCreateSchedule
            // 
            this.btnCreateSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCreateSchedule.FlatAppearance.BorderSize = 0;
            this.btnCreateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateSchedule.Location = new System.Drawing.Point(262, 258);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(194, 32);
            this.btnCreateSchedule.TabIndex = 3;
            this.btnCreateSchedule.Text = "Create Schedule";
            this.btnCreateSchedule.UseVisualStyleBackColor = false;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click);
            // 
            // btnRefreshSchedule
            // 
            this.btnRefreshSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRefreshSchedule.FlatAppearance.BorderSize = 0;
            this.btnRefreshSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefreshSchedule.Location = new System.Drawing.Point(25, 258);
            this.btnRefreshSchedule.Name = "btnRefreshSchedule";
            this.btnRefreshSchedule.Size = new System.Drawing.Size(194, 32);
            this.btnRefreshSchedule.TabIndex = 2;
            this.btnRefreshSchedule.Text = "Refresh";
            this.btnRefreshSchedule.UseVisualStyleBackColor = false;
            this.btnRefreshSchedule.Click += new System.EventHandler(this.btnRefreshSchedule_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(393, 8);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(127, 31);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Schedule";
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 655);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.Button btnCreateSchedule;
        private System.Windows.Forms.Button btnRefreshSchedule;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox RightYear;
        private System.Windows.Forms.TextBox RightMonth;
        private System.Windows.Forms.TextBox rightDay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox yearLeft;
        private System.Windows.Forms.TextBox mothLeft;
        private System.Windows.Forms.TextBox dayLeft;
        private System.Windows.Forms.DataGridView dvgShift;
        private System.Windows.Forms.TextBox middleMonth;
        private System.Windows.Forms.TextBox middleYear;
        private System.Windows.Forms.TextBox middleDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}