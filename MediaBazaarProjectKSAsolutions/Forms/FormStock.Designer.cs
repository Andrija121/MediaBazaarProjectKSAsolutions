
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
            this.pnlEmployees.SuspendLayout();
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
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(9, 8);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(914, 481);
            this.pnlEmployees.TabIndex = 12;
            // 
            // lbStocks
            // 
            this.lbStocks.FormattingEnabled = true;
            this.lbStocks.ItemHeight = 15;
            this.lbStocks.Location = new System.Drawing.Point(10, 130);
            this.lbStocks.Name = "lbStocks";
            this.lbStocks.Size = new System.Drawing.Size(888, 334);
            this.lbStocks.TabIndex = 6;
            // 
            // btnDelStock
            // 
            this.btnDelStock.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDelStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelStock.Location = new System.Drawing.Point(704, 81);
            this.btnDelStock.Name = "btnDelStock";
            this.btnDelStock.Size = new System.Drawing.Size(194, 31);
            this.btnDelStock.TabIndex = 5;
            this.btnDelStock.Text = "Delete Stock";
            this.btnDelStock.UseVisualStyleBackColor = false;
            this.btnDelStock.Click += new System.EventHandler(this.btnDelStock_Click);
            // 
            // btnEditStocks
            // 
            this.btnEditStocks.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditStocks.Location = new System.Drawing.Point(475, 81);
            this.btnEditStocks.Name = "btnEditStocks";
            this.btnEditStocks.Size = new System.Drawing.Size(194, 31);
            this.btnEditStocks.TabIndex = 4;
            this.btnEditStocks.Text = "Edit Stock";
            this.btnEditStocks.UseVisualStyleBackColor = false;
            this.btnEditStocks.Click += new System.EventHandler(this.btnEditStocks_Click);
            // 
            // btnCreateStocks
            // 
            this.btnCreateStocks.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCreateStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateStocks.Location = new System.Drawing.Point(241, 81);
            this.btnCreateStocks.Name = "btnCreateStocks";
            this.btnCreateStocks.Size = new System.Drawing.Size(194, 31);
            this.btnCreateStocks.TabIndex = 3;
            this.btnCreateStocks.Text = "Create Stock";
            this.btnCreateStocks.UseVisualStyleBackColor = false;
            this.btnCreateStocks.Click += new System.EventHandler(this.btnCreateStocks_Click);
            // 
            // btnRefreshStocks
            // 
            this.btnRefreshStocks.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRefreshStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefreshStocks.Location = new System.Drawing.Point(10, 81);
            this.btnRefreshStocks.Name = "btnRefreshStocks";
            this.btnRefreshStocks.Size = new System.Drawing.Size(194, 31);
            this.btnRefreshStocks.TabIndex = 2;
            this.btnRefreshStocks.Text = "Refresh";
            this.btnRefreshStocks.UseVisualStyleBackColor = false;
            this.btnRefreshStocks.Click += new System.EventHandler(this.btnRefreshStocks_Click);
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(818, 493);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 28);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(928, 529);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}