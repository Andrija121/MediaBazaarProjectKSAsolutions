
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, -83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 706);
            this.panel2.TabIndex = 5;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(10, 132);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(220, 22);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(240, 532);
            this.panel1.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(10, 494);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 22);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(10, 102);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(220, 22);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnDepartments
            // 
            this.btnDepartments.Location = new System.Drawing.Point(10, 72);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(220, 22);
            this.btnDepartments.TabIndex = 3;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click_1);
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(10, 42);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(220, 22);
            this.btnStocks.TabIndex = 2;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = true;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(10, 12);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(220, 22);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 180);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Location = new System.Drawing.Point(12, 8);
            this.lblHi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(0, 15);
            this.lblHi.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 630);
            this.Controls.Add(this.lblHi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHi;
    }
}