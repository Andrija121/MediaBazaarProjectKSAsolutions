
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormDaysOffRequests
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbDaysOffRequests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSelect.Location = new System.Drawing.Point(41, 292);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(545, 26);
            this.lblSelect.TabIndex = 21;
            this.lblSelect.Text = "Double click the requset you want to approve or decline";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(0, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(613, 74);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbDaysOffRequests
            // 
            this.lbDaysOffRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDaysOffRequests.FormattingEnabled = true;
            this.lbDaysOffRequests.ItemHeight = 26;
            this.lbDaysOffRequests.Location = new System.Drawing.Point(12, 6);
            this.lbDaysOffRequests.Name = "lbDaysOffRequests";
            this.lbDaysOffRequests.Size = new System.Drawing.Size(586, 264);
            this.lbDaysOffRequests.TabIndex = 19;
//            this.lbDaysOffRequests.SelectedIndexChanged += new System.EventHandler(this.lbDaysOffRequests_SelectedIndexChanged);
            this.lbDaysOffRequests.DoubleClick += new System.EventHandler(this.lbDaysOffRequests_DoubleClick);
            // 
            // FormDaysOffRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(613, 418);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbDaysOffRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaysOffRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDaysOffRequests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbDaysOffRequests;
    }
}