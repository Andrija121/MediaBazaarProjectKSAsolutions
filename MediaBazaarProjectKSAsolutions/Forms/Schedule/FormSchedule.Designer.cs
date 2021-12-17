
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
            this.jumpTo = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.middleMonth = new System.Windows.Forms.TextBox();
            this.middleYear = new System.Windows.Forms.TextBox();
            this.middleDay = new System.Windows.Forms.TextBox();
            this.dvgShift = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnCreateSchedule = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.pnlEmployees.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShift)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(974, 835);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 37);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.label1);
            this.pnlEmployees.Controls.Add(this.jumpTo);
            this.pnlEmployees.Controls.Add(this.panel1);
            this.pnlEmployees.Controls.Add(this.dvgShift);
            this.pnlEmployees.Controls.Add(this.btnDeleteSchedule);
            this.pnlEmployees.Controls.Add(this.btnEditSchedule);
            this.pnlEmployees.Controls.Add(this.btnCreateSchedule);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(9, -3);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1056, 821);
            this.pnlEmployees.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(670, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Jump To:";
            // 
            // jumpTo
            // 
            this.jumpTo.Location = new System.Drawing.Point(755, 301);
            this.jumpTo.Name = "jumpTo";
            this.jumpTo.Size = new System.Drawing.Size(250, 27);
            this.jumpTo.TabIndex = 10;
            this.jumpTo.ValueChanged += new System.EventHandler(this.jumpTo_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Right);
            this.panel1.Controls.Add(this.Left);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(181, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 234);
            this.panel1.TabIndex = 7;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.DarkOrchid;
            this.Right.FlatAppearance.BorderSize = 0;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Right.Location = new System.Drawing.Point(557, 90);
            this.Right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(48, 53);
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
            this.Left.Location = new System.Drawing.Point(116, 77);
            this.Left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(48, 53);
            this.Left.TabIndex = 11;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.middleMonth);
            this.panel3.Controls.Add(this.middleYear);
            this.panel3.Controls.Add(this.middleDay);
            this.panel3.Location = new System.Drawing.Point(276, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 184);
            this.panel3.TabIndex = 9;
            // 
            // middleMonth
            // 
            this.middleMonth.Location = new System.Drawing.Point(45, 83);
            this.middleMonth.Name = "middleMonth";
            this.middleMonth.Size = new System.Drawing.Size(51, 27);
            this.middleMonth.TabIndex = 17;
            this.middleMonth.Text = "NOV";
            // 
            // middleYear
            // 
            this.middleYear.Location = new System.Drawing.Point(45, 125);
            this.middleYear.Name = "middleYear";
            this.middleYear.Size = new System.Drawing.Size(51, 27);
            this.middleYear.TabIndex = 16;
            this.middleYear.Text = "2021";
            // 
            // middleDay
            // 
            this.middleDay.Location = new System.Drawing.Point(45, 40);
            this.middleDay.Name = "middleDay";
            this.middleDay.Size = new System.Drawing.Size(51, 27);
            this.middleDay.TabIndex = 15;
            this.middleDay.Text = "03";
            this.middleDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dvgShift
            // 
            this.dvgShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeName,
            this.Shift_Type,
            this.ShiftDate});
            this.dvgShift.Location = new System.Drawing.Point(75, 392);
            this.dvgShift.Name = "dvgShift";
            this.dvgShift.RowHeadersWidth = 51;
            this.dvgShift.RowTemplate.Height = 29;
            this.dvgShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvgShift.Size = new System.Drawing.Size(955, 427);
            this.dvgShift.TabIndex = 6;
            this.dvgShift.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgShift_CellClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Visible = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Shift_Type
            // 
            this.Shift_Type.HeaderText = "ShiftType";
            this.Shift_Type.MinimumWidth = 6;
            this.Shift_Type.Name = "Shift_Type";
            // 
            // ShiftDate
            // 
            this.ShiftDate.HeaderText = "ShiftDate";
            this.ShiftDate.MinimumWidth = 6;
            this.ShiftDate.Name = "ShiftDate";
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDeleteSchedule.FlatAppearance.BorderSize = 0;
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteSchedule.Location = new System.Drawing.Point(762, 343);
            this.btnDeleteSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(222, 43);
            this.btnDeleteSchedule.TabIndex = 5;
            this.btnDeleteSchedule.Text = "Delete Schdeule";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditSchedule.FlatAppearance.BorderSize = 0;
            this.btnEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditSchedule.Location = new System.Drawing.Point(387, 344);
            this.btnEditSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(222, 43);
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
            this.btnCreateSchedule.Location = new System.Drawing.Point(29, 343);
            this.btnCreateSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(222, 43);
            this.btnCreateSchedule.TabIndex = 3;
            this.btnCreateSchedule.Text = "Create Schedule";
            this.btnCreateSchedule.UseVisualStyleBackColor = false;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(449, 11);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(160, 39);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Schedule";
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 873);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.Button btnCreateSchedule;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.DateTimePicker jumpTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dvgShift;
        private System.Windows.Forms.TextBox middleMonth;
        private System.Windows.Forms.TextBox middleYear;
        private System.Windows.Forms.TextBox middleDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftDate;
    }
}