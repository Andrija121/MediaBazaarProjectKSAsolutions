
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormApproveOrDeclineRequest
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
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnApprovePartially = new System.Windows.Forms.Button();
            this.tbApprovePartially = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnApprove.Location = new System.Drawing.Point(12, 30);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(192, 63);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve ";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecline.FlatAppearance.BorderSize = 0;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDecline.Location = new System.Drawing.Point(256, 51);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(196, 63);
            this.btnDecline.TabIndex = 1;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnApprovePartially
            // 
            this.btnApprovePartially.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprovePartially.FlatAppearance.BorderSize = 0;
            this.btnApprovePartially.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprovePartially.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApprovePartially.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnApprovePartially.Location = new System.Drawing.Point(21, 139);
            this.btnApprovePartially.Name = "btnApprovePartially";
            this.btnApprovePartially.Size = new System.Drawing.Size(192, 63);
            this.btnApprovePartially.TabIndex = 2;
            this.btnApprovePartially.Text = "Approve partially";
            this.btnApprovePartially.UseVisualStyleBackColor = true;
            this.btnApprovePartially.Click += new System.EventHandler(this.btnApprovePartially_Click);
            // 
            // tbApprovePartially
            // 
            this.tbApprovePartially.Location = new System.Drawing.Point(231, 158);
            this.tbApprovePartially.Name = "tbApprovePartially";
            this.tbApprovePartially.Size = new System.Drawing.Size(170, 23);
            this.tbApprovePartially.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // FormApproveOrDeclineRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(494, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbApprovePartially);
            this.Controls.Add(this.btnApprovePartially);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnApprove);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormApproveOrDeclineRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApproveOrDeclineRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnApprovePartially;
        private System.Windows.Forms.TextBox tbApprovePartially;
        private System.Windows.Forms.Label label1;
    }
}