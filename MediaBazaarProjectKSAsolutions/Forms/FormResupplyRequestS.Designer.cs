
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormResupplyRequestS
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
            this.lbResupplyRequests = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResupplyRequests
            // 
            this.lbResupplyRequests.FormattingEnabled = true;
            this.lbResupplyRequests.ItemHeight = 25;
            this.lbResupplyRequests.Location = new System.Drawing.Point(12, 37);
            this.lbResupplyRequests.Name = "lbResupplyRequests";
            this.lbResupplyRequests.Size = new System.Drawing.Size(601, 229);
            this.lbResupplyRequests.TabIndex = 0;
            this.lbResupplyRequests.DoubleClick += new System.EventHandler(this.lbResupplyRequests_DoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(0, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(625, 74);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSelect.Location = new System.Drawing.Point(64, 292);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(482, 25);
            this.lblSelect.TabIndex = 18;
            this.lblSelect.Text = "Double click the requset you want to approve or decline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "RequestId - Stock Id - Amount Requested - Request Status";
            // 
            // FormResupplyRequestS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(625, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbResupplyRequests);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormResupplyRequestS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResupplyRequestS";
            this.Load += new System.EventHandler(this.FormResupplyRequestS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResupplyRequests;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label label1;
    }
}