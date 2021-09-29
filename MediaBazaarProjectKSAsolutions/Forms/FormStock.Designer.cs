
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
            this.btnDelStocks = new System.Windows.Forms.Button();
            this.btnEditStocks = new System.Windows.Forms.Button();
            this.btnCreateStocks = new System.Windows.Forms.Button();
            this.btnViewStocks = new System.Windows.Forms.Button();
            this.dgStock = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.btnDelStocks);
            this.pnlEmployees.Controls.Add(this.btnEditStocks);
            this.pnlEmployees.Controls.Add(this.btnCreateStocks);
            this.pnlEmployees.Controls.Add(this.btnViewStocks);
            this.pnlEmployees.Controls.Add(this.dgStock);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(258, 12);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(914, 737);
            this.pnlEmployees.TabIndex = 12;
            this.pnlEmployees.Visible = false;
            // 
            // btnDelStocks
            // 
            this.btnDelStocks.Location = new System.Drawing.Point(704, 89);
            this.btnDelStocks.Name = "btnDelStocks";
            this.btnDelStocks.Size = new System.Drawing.Size(194, 23);
            this.btnDelStocks.TabIndex = 5;
            this.btnDelStocks.Text = "Delete Stock";
            this.btnDelStocks.UseVisualStyleBackColor = true;
            // 
            // btnEditStocks
            // 
            this.btnEditStocks.Location = new System.Drawing.Point(475, 89);
            this.btnEditStocks.Name = "btnEditStocks";
            this.btnEditStocks.Size = new System.Drawing.Size(194, 23);
            this.btnEditStocks.TabIndex = 4;
            this.btnEditStocks.Text = "Edit Stock";
            this.btnEditStocks.UseVisualStyleBackColor = true;
            // 
            // btnCreateStocks
            // 
            this.btnCreateStocks.Location = new System.Drawing.Point(241, 89);
            this.btnCreateStocks.Name = "btnCreateStocks";
            this.btnCreateStocks.Size = new System.Drawing.Size(194, 23);
            this.btnCreateStocks.TabIndex = 3;
            this.btnCreateStocks.Text = "Create Stock";
            this.btnCreateStocks.UseVisualStyleBackColor = true;
            this.btnCreateStocks.Click += new System.EventHandler(this.btnCreateStocks_Click);
            // 
            // btnViewStocks
            // 
            this.btnViewStocks.Location = new System.Drawing.Point(10, 89);
            this.btnViewStocks.Name = "btnViewStocks";
            this.btnViewStocks.Size = new System.Drawing.Size(194, 23);
            this.btnViewStocks.TabIndex = 2;
            this.btnViewStocks.Text = "Load Stock";
            this.btnViewStocks.UseVisualStyleBackColor = true;
            this.btnViewStocks.Click += new System.EventHandler(this.btnViewStocks_Click);
            // 
            // dgStock
            // 
            this.dgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStock.Location = new System.Drawing.Point(10, 118);
            this.dgStock.Name = "dgStock";
            this.dgStock.RowHeadersWidth = 62;
            this.dgStock.RowTemplate.Height = 25;
            this.dgStock.Size = new System.Drawing.Size(888, 605);
            this.dgStock.TabIndex = 1;
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(375, 16);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(91, 37);
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
            this.panel1.Location = new System.Drawing.Point(12, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 531);
            this.panel1.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(10, 494);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(10, 132);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(220, 23);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(10, 102);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(220, 23);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.Location = new System.Drawing.Point(10, 72);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(220, 23);
            this.btnDepartments.TabIndex = 3;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(10, 42);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(220, 23);
            this.btnStocks.TabIndex = 2;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = true;
            this.btnStocks.Click += new System.EventHandler(this.Stocks_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(10, 12);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(220, 23);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 200);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelStocks;
        private System.Windows.Forms.Button btnEditStocks;
        private System.Windows.Forms.Button btnCreateStocks;
        private System.Windows.Forms.Button btnViewStocks;
    }
}