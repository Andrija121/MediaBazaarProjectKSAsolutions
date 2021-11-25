
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
            this.lbSchedule = new System.Windows.Forms.ListBox();
            this.btnDelSchedule = new System.Windows.Forms.Button();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnCreateSchedule = new System.Windows.Forms.Button();
            this.btnRefreshSchedule = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.pnlEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(932, 643);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 38);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployees.Controls.Add(this.lbSchedule);
            this.pnlEmployees.Controls.Add(this.btnDelSchedule);
            this.pnlEmployees.Controls.Add(this.btnEditSchedule);
            this.pnlEmployees.Controls.Add(this.btnCreateSchedule);
            this.pnlEmployees.Controls.Add(this.btnRefreshSchedule);
            this.pnlEmployees.Controls.Add(this.Stock);
            this.pnlEmployees.Location = new System.Drawing.Point(9, -3);
            this.pnlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(1044, 640);
            this.pnlEmployees.TabIndex = 14;
            // 
            // lbSchedule
            // 
            this.lbSchedule.FormattingEnabled = true;
            this.lbSchedule.ItemHeight = 20;
            this.lbSchedule.Location = new System.Drawing.Point(11, 174);
            this.lbSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(1014, 444);
            this.lbSchedule.TabIndex = 6;
            // 
            // btnDelSchedule
            // 
            this.btnDelSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDelSchedule.FlatAppearance.BorderSize = 0;
            this.btnDelSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelSchedule.Location = new System.Drawing.Point(805, 108);
            this.btnDelSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelSchedule.Name = "btnDelSchedule";
            this.btnDelSchedule.Size = new System.Drawing.Size(222, 42);
            this.btnDelSchedule.TabIndex = 5;
            this.btnDelSchedule.Text = "Delete Schdeule";
            this.btnDelSchedule.UseVisualStyleBackColor = false;
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditSchedule.FlatAppearance.BorderSize = 0;
            this.btnEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditSchedule.Location = new System.Drawing.Point(543, 108);
            this.btnEditSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(222, 42);
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
            this.btnCreateSchedule.Location = new System.Drawing.Point(275, 108);
            this.btnCreateSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(222, 42);
            this.btnCreateSchedule.TabIndex = 3;
            this.btnCreateSchedule.Text = "Create Schedule";
            this.btnCreateSchedule.UseVisualStyleBackColor = false;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click);
            // 
            // btnRefreshSchedule
            // 
            this.btnRefreshSchedule.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRefreshSchedule.FlatAppearance.BorderSize = 0;
            this.btnRefreshSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefreshSchedule.Location = new System.Drawing.Point(11, 108);
            this.btnRefreshSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshSchedule.Name = "btnRefreshSchedule";
            this.btnRefreshSchedule.Size = new System.Drawing.Size(222, 42);
            this.btnRefreshSchedule.TabIndex = 2;
            this.btnRefreshSchedule.Text = "Refresh";
            this.btnRefreshSchedule.UseVisualStyleBackColor = false;
            this.btnRefreshSchedule.Click += new System.EventHandler(this.btnRefreshSchedule_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stock.Location = new System.Drawing.Point(449, 10);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(160, 39);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Schedule";
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 679);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSchedule";
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.ListBox lbSchedule;
        private System.Windows.Forms.Button btnDelSchedule;
        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.Button btnCreateSchedule;
        private System.Windows.Forms.Button btnRefreshSchedule;
        private System.Windows.Forms.Label Stock;
    }
}