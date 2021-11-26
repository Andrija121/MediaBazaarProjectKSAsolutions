
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
            this.DVGStock = new System.Windows.Forms.DataGridView();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbStocks = new System.Windows.Forms.ListBox();
            this.btnDelStock = new System.Windows.Forms.Button();
            this.btnEditStocks = new System.Windows.Forms.Button();
            this.btnCreateStocks = new System.Windows.Forms.Button();
            this.btnRefreshStocks = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.DVGStock);
            this.pnlEmployees.Controls.Add(this.lbStocks);
            this.pnlEmployees.Controls.Add(this.btnDelStock);
            this.pnlEmployees.Controls.Add(this.btnEditStocks);
            this.pnlEmployees.Controls.Add(this.btnCreateStocks);
            this.pnlEmployees.Controls.Add(this.btnRefreshStocks);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(10, 11);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1044, 641);
            this.pnlEmployees.TabIndex = 12;
            // 
            // DVGStock
            // 
            this.DVGStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockName,
            this.StockPrice,
            this.StockSerialNumber,
            this.StockAmount,
            this.StockCategory});
            this.DVGStock.Location = new System.Drawing.Point(11, 221);
            this.DVGStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DVGStock.Name = "DVGStock";
            this.DVGStock.RowHeadersWidth = 51;
            this.DVGStock.RowTemplate.Height = 25;
            this.DVGStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DVGStock.Size = new System.Drawing.Size(1015, 397);
            this.DVGStock.TabIndex = 7;
            // 
            // StockName
            // 
            this.StockName.HeaderText = "Name";
            this.StockName.MinimumWidth = 170;
            this.StockName.Name = "StockName";
            this.StockName.Width = 170;
            // 
            // StockPrice
            // 
            this.StockPrice.HeaderText = "Price";
            this.StockPrice.MinimumWidth = 158;
            this.StockPrice.Name = "StockPrice";
            this.StockPrice.Width = 170;
            // 
            // StockSerialNumber
            // 
            this.StockSerialNumber.HeaderText = "Serial Number";
            this.StockSerialNumber.MinimumWidth = 170;
            this.StockSerialNumber.Name = "StockSerialNumber";
            this.StockSerialNumber.Width = 170;
            // 
            // StockAmount
            // 
            this.StockAmount.HeaderText = "Amount";
            this.StockAmount.MinimumWidth = 170;
            this.StockAmount.Name = "StockAmount";
            this.StockAmount.Width = 170;
            // 
            // StockCategory
            // 
            this.StockCategory.HeaderText = "Category";
            this.StockCategory.MinimumWidth = 170;
            this.StockCategory.Name = "StockCategory";
            this.StockCategory.Width = 170;
            // 
            // lbStocks
            // 
            this.lbStocks.FormattingEnabled = true;
            this.lbStocks.ItemHeight = 20;
            this.lbStocks.Location = new System.Drawing.Point(11, 173);
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
            this.btnDelStock.Size = new System.Drawing.Size(222, 41);
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
            this.btnEditStocks.Size = new System.Drawing.Size(222, 41);
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
            this.btnCreateStocks.Size = new System.Drawing.Size(222, 41);
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
            this.btnRefreshStocks.Size = new System.Drawing.Size(222, 41);
            this.btnRefreshStocks.TabIndex = 2;
            this.btnRefreshStocks.Text = "Refresh";
            this.btnRefreshStocks.UseVisualStyleBackColor = false;
            this.btnRefreshStocks.Click += new System.EventHandler(this.btnRefreshStocks_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(449, 11);
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
            this.btnBack.Location = new System.Drawing.Point(935, 657);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 37);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1061, 705);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStock";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGStock)).EndInit();
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
        private System.Windows.Forms.DataGridView DVGStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCategory;
    }
}