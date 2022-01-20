
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class RequestResupplyForm
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.cbDMs = new System.Windows.Forms.ComboBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblIsSendingRequest = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblforStock = new System.Windows.Forms.Label();
            this.lblOfTheTotalAmount = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Location = new System.Drawing.Point(89, 47);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(179, 29);
            this.tbUserName.TabIndex = 0;
            // 
            // cbDMs
            // 
            this.cbDMs.FormattingEnabled = true;
            this.cbDMs.Location = new System.Drawing.Point(89, 116);
            this.cbDMs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDMs.Name = "cbDMs";
            this.cbDMs.Size = new System.Drawing.Size(218, 30);
            this.cbDMs.TabIndex = 1;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(97, 267);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(179, 29);
            this.tbAmount.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(25, 50);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(48, 22);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // lblIsSendingRequest
            // 
            this.lblIsSendingRequest.AutoSize = true;
            this.lblIsSendingRequest.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIsSendingRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblIsSendingRequest.Location = new System.Drawing.Point(90, 85);
            this.lblIsSendingRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsSendingRequest.Name = "lblIsSendingRequest";
            this.lblIsSendingRequest.Size = new System.Drawing.Size(162, 22);
            this.lblIsSendingRequest.TabIndex = 5;
            this.lblIsSendingRequest.Text = "Is sending request";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTo.Location = new System.Drawing.Point(43, 119);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 22);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "to";
            // 
            // lblforStock
            // 
            this.lblforStock.AutoSize = true;
            this.lblforStock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblforStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblforStock.Location = new System.Drawing.Point(134, 152);
            this.lblforStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblforStock.Name = "lblforStock";
            this.lblforStock.Size = new System.Drawing.Size(83, 22);
            this.lblforStock.TabIndex = 7;
            this.lblforStock.Text = "for stock";
            // 
            // lblOfTheTotalAmount
            // 
            this.lblOfTheTotalAmount.AutoSize = true;
            this.lblOfTheTotalAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOfTheTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOfTheTotalAmount.Location = new System.Drawing.Point(99, 237);
            this.lblOfTheTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfTheTotalAmount.Name = "lblOfTheTotalAmount";
            this.lblOfTheTotalAmount.Size = new System.Drawing.Size(162, 22);
            this.lblOfTheTotalAmount.TabIndex = 8;
            this.lblOfTheTotalAmount.Text = "of the total amout";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUnits.Location = new System.Drawing.Point(285, 273);
            this.lblUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(54, 22);
            this.lblUnits.TabIndex = 9;
            this.lblUnits.Text = "Units";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(0, 436);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(372, 82);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSend.Location = new System.Drawing.Point(0, 354);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(372, 82);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbStock
            // 
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Location = new System.Drawing.Point(97, 193);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(179, 30);
            this.cbStock.TabIndex = 13;
            // 
            // RequestResupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(372, 518);
            this.Controls.Add(this.cbStock);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblOfTheTotalAmount);
            this.Controls.Add(this.lblforStock);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblIsSendingRequest);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.cbDMs);
            this.Controls.Add(this.tbUserName);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RequestResupplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestResupplyForm";
            this.Load += new System.EventHandler(this.RequestResupplyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.ComboBox cbDMs;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblIsSendingRequest;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblforStock;
        private System.Windows.Forms.Label lblOfTheTotalAmount;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbStock;
    }
}