
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class InactiveUsersForm
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
            this.lbInactiveUsers = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.rbInactiveUsers = new System.Windows.Forms.RadioButton();
            this.rbAwayUsers = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbInactiveUsers
            // 
            this.lbInactiveUsers.FormattingEnabled = true;
            this.lbInactiveUsers.ItemHeight = 25;
            this.lbInactiveUsers.Location = new System.Drawing.Point(13, 13);
            this.lbInactiveUsers.Name = "lbInactiveUsers";
            this.lbInactiveUsers.Size = new System.Drawing.Size(775, 379);
            this.lbInactiveUsers.TabIndex = 0;
            this.lbInactiveUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbInactiveUsers_MouseDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(676, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbInactiveUsers
            // 
            this.rbInactiveUsers.AutoSize = true;
            this.rbInactiveUsers.Location = new System.Drawing.Point(13, 404);
            this.rbInactiveUsers.Name = "rbInactiveUsers";
            this.rbInactiveUsers.Size = new System.Drawing.Size(145, 29);
            this.rbInactiveUsers.TabIndex = 18;
            this.rbInactiveUsers.TabStop = true;
            this.rbInactiveUsers.Text = "Inactive Users";
            this.rbInactiveUsers.UseVisualStyleBackColor = true;
            this.rbInactiveUsers.CheckedChanged += new System.EventHandler(this.rbInactiveUsers_CheckedChanged);
            this.rbInactiveUsers.Leave += new System.EventHandler(this.rbInactiveUsers_Leave);
            // 
            // rbAwayUsers
            // 
            this.rbAwayUsers.AutoSize = true;
            this.rbAwayUsers.Location = new System.Drawing.Point(189, 404);
            this.rbAwayUsers.Name = "rbAwayUsers";
            this.rbAwayUsers.Size = new System.Drawing.Size(128, 29);
            this.rbAwayUsers.TabIndex = 19;
            this.rbAwayUsers.TabStop = true;
            this.rbAwayUsers.Text = "Away Users";
            this.rbAwayUsers.UseVisualStyleBackColor = true;
            this.rbAwayUsers.CheckedChanged += new System.EventHandler(this.rbAwayUsers_CheckedChanged);
            this.rbAwayUsers.Leave += new System.EventHandler(this.rbAwayUsers_Leave);
            // 
            // InactiveUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbAwayUsers);
            this.Controls.Add(this.rbInactiveUsers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbInactiveUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InactiveUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InactiveUsersForm";
            this.Load += new System.EventHandler(this.InactiveUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbInactiveUsers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rbInactiveUsers;
        private System.Windows.Forms.RadioButton rbAwayUsers;
    }
}