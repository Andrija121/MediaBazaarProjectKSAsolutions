
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class DaysOffAproveOrDeclineForm
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
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecline
            // 
            this.btnDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecline.FlatAppearance.BorderSize = 0;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDecline.Location = new System.Drawing.Point(420, 194);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(196, 63);
            this.btnDecline.TabIndex = 3;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnApprove.Location = new System.Drawing.Point(184, 194);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(192, 63);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Approve ";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // DaysOffAproveOrDeclineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnApprove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaysOffAproveOrDeclineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaysOffAproveOrDeclineForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnApprove;
    }
}