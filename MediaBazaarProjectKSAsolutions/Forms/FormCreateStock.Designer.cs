
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormCreateStock
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
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNewStockName = new System.Windows.Forms.TextBox();
            this.btnAddStockConfirmation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNewStockPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNewStockSerialNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNewStockAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(67, 76);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(49, 20);
            this.lblDepartmentName.TabIndex = 8;
            this.lblDepartmentName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add Stock";
            // 
            // tbxNewStockName
            // 
            this.tbxNewStockName.Location = new System.Drawing.Point(174, 76);
            this.tbxNewStockName.Name = "tbxNewStockName";
            this.tbxNewStockName.Size = new System.Drawing.Size(219, 27);
            this.tbxNewStockName.TabIndex = 6;
            // 
            // btnAddStockConfirmation
            // 
            this.btnAddStockConfirmation.Location = new System.Drawing.Point(211, 228);
            this.btnAddStockConfirmation.Name = "btnAddStockConfirmation";
            this.btnAddStockConfirmation.Size = new System.Drawing.Size(104, 38);
            this.btnAddStockConfirmation.TabIndex = 5;
            this.btnAddStockConfirmation.Text = "Add";
            this.btnAddStockConfirmation.UseVisualStyleBackColor = true;
            this.btnAddStockConfirmation.Click += new System.EventHandler(this.btnAddStockConfirmation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Price";
            // 
            // tbxNewStockPrice
            // 
            this.tbxNewStockPrice.Location = new System.Drawing.Point(174, 109);
            this.tbxNewStockPrice.Name = "tbxNewStockPrice";
            this.tbxNewStockPrice.Size = new System.Drawing.Size(219, 27);
            this.tbxNewStockPrice.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Serial Number";
            // 
            // tbxNewStockSerialNumber
            // 
            this.tbxNewStockSerialNumber.Location = new System.Drawing.Point(174, 142);
            this.tbxNewStockSerialNumber.Name = "tbxNewStockSerialNumber";
            this.tbxNewStockSerialNumber.Size = new System.Drawing.Size(219, 27);
            this.tbxNewStockSerialNumber.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount";
            // 
            // tbxNewStockAmount
            // 
            this.tbxNewStockAmount.Location = new System.Drawing.Point(174, 175);
            this.tbxNewStockAmount.Name = "tbxNewStockAmount";
            this.tbxNewStockAmount.Size = new System.Drawing.Size(219, 27);
            this.tbxNewStockAmount.TabIndex = 13;
            // 
            // FormCreateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNewStockAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNewStockSerialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNewStockPrice);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNewStockName);
            this.Controls.Add(this.btnAddStockConfirmation);
            this.Name = "FormCreateStock";
            this.Text = "FormCreateStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNewStockName;
        private System.Windows.Forms.Button btnAddStockConfirmation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNewStockPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNewStockSerialNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNewStockAmount;
    }
}