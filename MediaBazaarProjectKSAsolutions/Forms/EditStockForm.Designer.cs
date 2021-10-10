
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class EditStockForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNewStockAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNewStockSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNewStockPrice = new System.Windows.Forms.TextBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblEditStock = new System.Windows.Forms.Label();
            this.tbxNewStockName = new System.Windows.Forms.TextBox();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(240, 245);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 37);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Amount";
            // 
            // tbxNewStockAmount
            // 
            this.tbxNewStockAmount.Location = new System.Drawing.Point(125, 195);
            this.tbxNewStockAmount.Name = "tbxNewStockAmount";
            this.tbxNewStockAmount.Size = new System.Drawing.Size(219, 27);
            this.tbxNewStockAmount.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Serial Number";
            // 
            // tbxNewStockSerialNumber
            // 
            this.tbxNewStockSerialNumber.Location = new System.Drawing.Point(125, 161);
            this.tbxNewStockSerialNumber.Name = "tbxNewStockSerialNumber";
            this.tbxNewStockSerialNumber.Size = new System.Drawing.Size(219, 27);
            this.tbxNewStockSerialNumber.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Price";
            // 
            // tbxNewStockPrice
            // 
            this.tbxNewStockPrice.Location = new System.Drawing.Point(125, 129);
            this.tbxNewStockPrice.Name = "tbxNewStockPrice";
            this.tbxNewStockPrice.Size = new System.Drawing.Size(219, 27);
            this.tbxNewStockPrice.TabIndex = 20;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(18, 96);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(49, 20);
            this.lblDepartmentName.TabIndex = 19;
            this.lblDepartmentName.Text = "Name";
            this.lblDepartmentName.Click += new System.EventHandler(this.lblDepartmentName_Click);
            // 
            // lblEditStock
            // 
            this.lblEditStock.AutoSize = true;
            this.lblEditStock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEditStock.Location = new System.Drawing.Point(109, 29);
            this.lblEditStock.Name = "lblEditStock";
            this.lblEditStock.Size = new System.Drawing.Size(168, 46);
            this.lblEditStock.TabIndex = 18;
            this.lblEditStock.Text = "Edit Stock";
            // 
            // tbxNewStockName
            // 
            this.tbxNewStockName.Location = new System.Drawing.Point(125, 96);
            this.tbxNewStockName.Name = "tbxNewStockName";
            this.tbxNewStockName.Size = new System.Drawing.Size(219, 27);
            this.tbxNewStockName.TabIndex = 17;
            // 
            // btnEditStock
            // 
            this.btnEditStock.Location = new System.Drawing.Point(125, 245);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(104, 37);
            this.btnEditStock.TabIndex = 16;
            this.btnEditStock.Text = "Save";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // EditStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 304);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNewStockAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNewStockSerialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNewStockPrice);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lblEditStock);
            this.Controls.Add(this.tbxNewStockName);
            this.Controls.Add(this.btnEditStock);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditStockForm";
            this.Text = "EditStockForm";
            this.Load += new System.EventHandler(this.EditStockForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNewStockAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNewStockSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNewStockPrice;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblEditStock;
        private System.Windows.Forms.TextBox tbxNewStockName;
        private System.Windows.Forms.Button btnEditStock;
    }
}