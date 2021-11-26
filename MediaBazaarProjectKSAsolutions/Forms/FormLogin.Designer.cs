namespace MediaBazaarProjectKSAsolutions
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureboxLogo = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPasswordForget = new System.Windows.Forms.Button();
            this.LL_Login = new System.Windows.Forms.LinkLabel();
            this.lblMediaBazzar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxLogo
            // 
            this.pictureboxLogo.Image = global::MediaBazaarProjectKSAsolutions.Properties.Resources.Logo;
            this.pictureboxLogo.Location = new System.Drawing.Point(138, 81);
            this.pictureboxLogo.Name = "pictureboxLogo";
            this.pictureboxLogo.Size = new System.Drawing.Size(256, 173);
            this.pictureboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxLogo.TabIndex = 8;
            this.pictureboxLogo.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserName.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblUserName.Location = new System.Drawing.Point(51, 286);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(191, 26);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name / Email";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUserName.Location = new System.Drawing.Point(51, 317);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(433, 42);
            this.tbUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPassword.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblPassword.Location = new System.Drawing.Point(51, 392);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 26);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(51, 423);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(433, 42);
            this.tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.Location = new System.Drawing.Point(51, 525);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(264, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPasswordForget
            // 
            this.btnPasswordForget.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnPasswordForget.FlatAppearance.BorderSize = 0;
            this.btnPasswordForget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordForget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPasswordForget.Location = new System.Drawing.Point(324, 525);
            this.btnPasswordForget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPasswordForget.Name = "btnPasswordForget";
            this.btnPasswordForget.Size = new System.Drawing.Size(176, 38);
            this.btnPasswordForget.TabIndex = 6;
            this.btnPasswordForget.Text = "Forgot Password?";
            this.btnPasswordForget.UseVisualStyleBackColor = false;
            this.btnPasswordForget.Click += new System.EventHandler(this.btnPasswordForget_Click);
            // 
            // LL_Login
            // 
            this.LL_Login.AutoSize = true;
            this.LL_Login.Location = new System.Drawing.Point(51, 575);
            this.LL_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LL_Login.Name = "LL_Login";
            this.LL_Login.Size = new System.Drawing.Size(116, 25);
            this.LL_Login.TabIndex = 7;
            this.LL_Login.TabStop = true;
            this.LL_Login.Text = "Login Bypass";
            this.LL_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Login_LinkClicked);
            // 
            // lblMediaBazzar
            // 
            this.lblMediaBazzar.AutoSize = true;
            this.lblMediaBazzar.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMediaBazzar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMediaBazzar.Location = new System.Drawing.Point(138, 9);
            this.lblMediaBazzar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMediaBazzar.Name = "lblMediaBazzar";
            this.lblMediaBazzar.Size = new System.Drawing.Size(256, 60);
            this.lblMediaBazzar.TabIndex = 2;
            this.lblMediaBazzar.Text = "Welcome back to Media bazaar \r\n\r\nPlease Login to Your Account\r\n";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 674);
            this.Controls.Add(this.lblMediaBazzar);
            this.Controls.Add(this.pictureboxLogo);
            this.Controls.Add(this.LL_Login);
            this.Controls.Add(this.btnPasswordForget);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureboxLogo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPasswordForget;
        private System.Windows.Forms.LinkLabel LL_Login;
        private System.Windows.Forms.Label lblMediaBazzar;
    }
}

