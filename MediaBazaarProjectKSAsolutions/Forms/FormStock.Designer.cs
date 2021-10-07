
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.lbStocks);
            this.pnlEmployees.Controls.Add(this.btnDelStock);
            this.pnlEmployees.Controls.Add(this.btnEditStocks);
            this.pnlEmployees.Controls.Add(this.btnCreateStocks);
            this.pnlEmployees.Controls.Add(this.btnRefreshStocks);
            this.pnlEmployees.Controls.Add(this.dataGridView3);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(13, 14);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1305, 800);
            this.pnlEmployees.TabIndex = 12;
            // 
            // lbStocks
            // 
            this.lbStocks.FormattingEnabled = true;
            this.lbStocks.ItemHeight = 25;
            this.lbStocks.Location = new System.Drawing.Point(29, 217);
            this.lbStocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStocks.Name = "lbStocks";
            this.lbStocks.Size = new System.Drawing.Size(1235, 554);
            this.lbStocks.TabIndex = 6;
            // 
            // btnDelStock
            // 
            this.btnDelStock.Location = new System.Drawing.Point(1006, 148);
            this.btnDelStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelStock.Name = "btnDelStock";
            this.btnDelStock.Size = new System.Drawing.Size(277, 38);
            this.btnDelStock.TabIndex = 5;
            this.btnDelStock.Text = "Delete Stock";
            this.btnDelStock.UseVisualStyleBackColor = true;
            // 
            // btnEditStocks
            // 
            this.btnEditStocks.Location = new System.Drawing.Point(679, 148);
            this.btnEditStocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditStocks.Name = "btnEditStocks";
            this.btnEditStocks.Size = new System.Drawing.Size(277, 38);
            this.btnEditStocks.TabIndex = 4;
            this.btnEditStocks.Text = "Edit Stock";
            this.btnEditStocks.UseVisualStyleBackColor = true;
            this.btnEditStocks.Click += new System.EventHandler(this.btnEditStocks_Click);
            // 
            // btnCreateStocks
            // 
            this.btnCreateStocks.Location = new System.Drawing.Point(344, 148);
            this.btnCreateStocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateStocks.Name = "btnCreateStocks";
            this.btnCreateStocks.Size = new System.Drawing.Size(277, 38);
            this.btnCreateStocks.TabIndex = 3;
            this.btnCreateStocks.Text = "Create Stock";
            this.btnCreateStocks.UseVisualStyleBackColor = true;
            this.btnCreateStocks.Click += new System.EventHandler(this.btnCreateStocks_Click);
            // 
            // btnRefreshStocks
            // 
            this.btnRefreshStocks.Location = new System.Drawing.Point(14, 148);
            this.btnRefreshStocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefreshStocks.Name = "btnRefreshStocks";
            this.btnRefreshStocks.Size = new System.Drawing.Size(277, 38);
            this.btnRefreshStocks.TabIndex = 2;
            this.btnRefreshStocks.Text = "Refresh";
            this.btnRefreshStocks.UseVisualStyleBackColor = true;
            this.btnRefreshStocks.Click += new System.EventHandler(this.btnRefreshStocks_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(14, 197);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1269, 596);
            this.dataGridView3.TabIndex = 1;
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(536, 27);
            this.Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(135, 54);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Stocks";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1168, 822);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 47);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 881);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStock";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnBack;
    }
}