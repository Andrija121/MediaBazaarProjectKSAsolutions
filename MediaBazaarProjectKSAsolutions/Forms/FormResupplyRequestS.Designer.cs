
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
            this.SuspendLayout();
            // 
            // lbResupplyRequests
            // 
            this.lbResupplyRequests.FormattingEnabled = true;
            this.lbResupplyRequests.ItemHeight = 30;
            this.lbResupplyRequests.Location = new System.Drawing.Point(159, 63);
            this.lbResupplyRequests.Name = "lbResupplyRequests";
            this.lbResupplyRequests.Size = new System.Drawing.Size(586, 274);
            this.lbResupplyRequests.TabIndex = 0;
            // 
            // FormResupplyRequestS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.lbResupplyRequests);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormResupplyRequestS";
            this.Text = "FormResupplyRequestS";
            this.Load += new System.EventHandler(this.FormResupplyRequestS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbResupplyRequests;
    }
}