
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormStock
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
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.btnDelStock = new System.Windows.Forms.Button();
            this.btnEditStocks = new System.Windows.Forms.Button();
            this.btnCreateStocks = new System.Windows.Forms.Button();
            this.btnRefreshStocks = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.btnDelStock);
            this.pnlEmployees.Controls.Add(this.btnEditStocks);
            this.pnlEmployees.Controls.Add(this.btnCreateStocks);
            this.pnlEmployees.Controls.Add(this.btnRefreshStocks);
            this.pnlEmployees.Controls.Add(this.dataGridView3);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(295, 16);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1044, 982);
            this.pnlEmployees.TabIndex = 12;
            // 
            // btnDelStock
            // 
            this.btnDelStock.Location = new System.Drawing.Point(805, 119);
            this.btnDelStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelStock.Name = "btnDelStock";
            this.btnDelStock.Size = new System.Drawing.Size(222, 31);
            this.btnDelStock.TabIndex = 5;
            this.btnDelStock.Text = "Delete Stock";
            this.btnDelStock.UseVisualStyleBackColor = true;
            // 
            // btnEditStocks
            // 
            this.btnEditStocks.Location = new System.Drawing.Point(543, 119);
            this.btnEditStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditStocks.Name = "btnEditStocks";
            this.btnEditStocks.Size = new System.Drawing.Size(222, 31);
            this.btnEditStocks.TabIndex = 4;
            this.btnEditStocks.Text = "Edit Stock";
            this.btnEditStocks.UseVisualStyleBackColor = true;
            //this.btnEditStocks.Click += new System.EventHandler(this.btnEditStocks_Click);
            // 
            // btnCreateStocks
            // 
            this.btnCreateStocks.Location = new System.Drawing.Point(275, 119);
            this.btnCreateStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateStocks.Name = "btnCreateStocks";
            this.btnCreateStocks.Size = new System.Drawing.Size(222, 31);
            this.btnCreateStocks.TabIndex = 3;
            this.btnCreateStocks.Text = "Create Stock";
            this.btnCreateStocks.UseVisualStyleBackColor = true;
            this.btnCreateStocks.Click += new System.EventHandler(this.btnCreateStocks_Click);
            // 
            // btnRefreshStocks
            // 
            this.btnRefreshStocks.Location = new System.Drawing.Point(11, 119);
            this.btnRefreshStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshStocks.Name = "btnRefreshStocks";
            this.btnRefreshStocks.Size = new System.Drawing.Size(222, 31);
            this.btnRefreshStocks.TabIndex = 2;
            this.btnRefreshStocks.Text = "Refresh";
            this.btnRefreshStocks.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(11, 157);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1015, 807);
            this.dataGridView3.TabIndex = 1;
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(429, 21);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(116, 46);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Stocks";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnStatistics);
            this.panel1.Controls.Add(this.btnSchedule);
            this.panel1.Controls.Add(this.btnDepartments);
            this.panel1.Controls.Add(this.btnStocks);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Location = new System.Drawing.Point(14, 291);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 707);
            this.panel1.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(11, 659);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(251, 31);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(11, 176);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(251, 31);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(11, 136);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(251, 31);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.Location = new System.Drawing.Point(11, 96);
            this.btnDepartments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(251, 31);
            this.btnDepartments.TabIndex = 3;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(11, 56);
            this.btnStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(251, 31);
            this.btnStocks.TabIndex = 2;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = true;
            this.btnStocks.Click += new System.EventHandler(this.Stocks_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(11, 16);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(251, 31);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 267);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 1015);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelStock;
        private System.Windows.Forms.Button btnEditStocks;
        private System.Windows.Forms.Button btnCreateStocks;
        private System.Windows.Forms.Button btnRefreshStocks;
    }
}