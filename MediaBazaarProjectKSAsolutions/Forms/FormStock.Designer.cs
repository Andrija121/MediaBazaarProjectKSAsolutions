
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
            this.lbStocks = new System.Windows.Forms.ListBox();
            this.btnDelStock = new System.Windows.Forms.Button();
            this.btnEditStocks = new System.Windows.Forms.Button();
            this.btnCreateStocks = new System.Windows.Forms.Button();
            this.btnRefreshStocks = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbxSearchBar_Stocks = new System.Windows.Forms.TextBox();
            this.lblSearchBar = new System.Windows.Forms.Label();
            this.pnlEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.lblSearchBar);
            this.pnlEmployees.Controls.Add(this.tbxSearchBar_Stocks);
            this.pnlEmployees.Controls.Add(this.lbStocks);
            this.pnlEmployees.Controls.Add(this.btnDelStock);
            this.pnlEmployees.Controls.Add(this.btnEditStocks);
            this.pnlEmployees.Controls.Add(this.btnCreateStocks);
            this.pnlEmployees.Controls.Add(this.btnRefreshStocks);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(10, 10);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1044, 640);
            this.pnlEmployees.TabIndex = 12;
            // 
            // lbStocks
            // 
            this.lbStocks.FormattingEnabled = true;
            this.lbStocks.ItemHeight = 20;
            this.lbStocks.Location = new System.Drawing.Point(11, 174);
            this.lbStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbStocks.Name = "lbStocks";
            this.lbStocks.Size = new System.Drawing.Size(1014, 444);
            this.lbStocks.TabIndex = 6;
            // 
            // btnDelStock
            // 
            this.btnDelStock.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDelStock.FlatAppearance.BorderSize = 0;
            this.btnDelStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelStock.Location = new System.Drawing.Point(805, 108);
            this.btnDelStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelStock.Name = "btnDelStock";
            this.btnDelStock.Size = new System.Drawing.Size(222, 42);
            this.btnDelStock.TabIndex = 5;
            this.btnDelStock.Text = "Delete Stock";
            this.btnDelStock.UseVisualStyleBackColor = false;
            this.btnDelStock.Click += new System.EventHandler(this.btnDelStock_Click);
            // 
            // btnEditStocks
            // 
            this.btnEditStocks.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditStocks.FlatAppearance.BorderSize = 0;
            this.btnEditStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditStocks.Location = new System.Drawing.Point(543, 108);
            this.btnEditStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditStocks.Name = "btnEditStocks";
            this.btnEditStocks.Size = new System.Drawing.Size(222, 42);
            this.btnEditStocks.TabIndex = 4;
            this.btnEditStocks.Text = "Edit Stock";
            this.btnEditStocks.UseVisualStyleBackColor = false;
            this.btnEditStocks.Click += new System.EventHandler(this.btnEditStocks_Click);
            // 
            // btnCreateStocks
            // 
            this.btnCreateStocks.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCreateStocks.FlatAppearance.BorderSize = 0;
            this.btnCreateStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateStocks.Location = new System.Drawing.Point(275, 108);
            this.btnCreateStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateStocks.Name = "btnCreateStocks";
            this.btnCreateStocks.Size = new System.Drawing.Size(222, 42);
            this.btnCreateStocks.TabIndex = 3;
            this.btnCreateStocks.Text = "Create Stock";
            this.btnCreateStocks.UseVisualStyleBackColor = false;
            this.btnCreateStocks.Click += new System.EventHandler(this.btnCreateStocks_Click);
            // 
            // btnRefreshStocks
            // 
            this.btnRefreshStocks.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRefreshStocks.FlatAppearance.BorderSize = 0;
            this.btnRefreshStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefreshStocks.Location = new System.Drawing.Point(11, 108);
            this.btnRefreshStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshStocks.Name = "btnRefreshStocks";
            this.btnRefreshStocks.Size = new System.Drawing.Size(222, 42);
            this.btnRefreshStocks.TabIndex = 2;
            this.btnRefreshStocks.Text = "Refresh";
            this.btnRefreshStocks.UseVisualStyleBackColor = false;
            this.btnRefreshStocks.Click += new System.EventHandler(this.btnRefreshStocks_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(449, 10);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(119, 39);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Stocks";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(935, 658);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 38);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbxSearchBar_Stocks
            // 
            this.tbxSearchBar_Stocks.Location = new System.Drawing.Point(805, 58);
            this.tbxSearchBar_Stocks.Name = "tbxSearchBar_Stocks";
            this.tbxSearchBar_Stocks.Size = new System.Drawing.Size(220, 27);
            this.tbxSearchBar_Stocks.TabIndex = 7;
            this.tbxSearchBar_Stocks.TextChanged += new System.EventHandler(this.tbxSearchBar_Stocks_TextChanged);
            // 
            // lblSearchBar
            // 
            this.lblSearchBar.AutoSize = true;
            this.lblSearchBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchBar.Location = new System.Drawing.Point(805, 35);
            this.lblSearchBar.Name = "lblSearchBar";
            this.lblSearchBar.Size = new System.Drawing.Size(83, 20);
            this.lblSearchBar.TabIndex = 8;
            this.lblSearchBar.Text = "Search Bar";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1061, 706);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStock";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Button btnDelStock;
        private System.Windows.Forms.Button btnEditStocks;
        private System.Windows.Forms.Button btnCreateStocks;
        private System.Windows.Forms.Button btnRefreshStocks;
        private System.Windows.Forms.ListBox lbStocks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearchBar;
        private System.Windows.Forms.TextBox tbxSearchBar_Stocks;
    }
}