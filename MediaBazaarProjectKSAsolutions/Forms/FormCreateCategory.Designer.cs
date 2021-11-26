
namespace MediaBazaarProjectKSAsolutions.Forms
{
    partial class FormCreateCategory
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
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.tbWindowClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(29, 78);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(247, 23);
            this.tbCategoryName.TabIndex = 0;
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCategorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorySave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCategorySave.Location = new System.Drawing.Point(294, 78);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySave.TabIndex = 1;
            this.btnCategorySave.Text = "Add Category";
            this.btnCategorySave.UseVisualStyleBackColor = false;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // tbWindowClose
            // 
            this.tbWindowClose.BackColor = System.Drawing.Color.DarkOrchid;
            this.tbWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbWindowClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbWindowClose.Location = new System.Drawing.Point(294, 133);
            this.tbWindowClose.Name = "tbWindowClose";
            this.tbWindowClose.Size = new System.Drawing.Size(75, 23);
            this.tbWindowClose.TabIndex = 2;
            this.tbWindowClose.Text = "Cancel";
            this.tbWindowClose.UseVisualStyleBackColor = false;
            this.tbWindowClose.Click += new System.EventHandler(this.tbWindowClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add Category";
            // 
            // FormCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(406, 193);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWindowClose);
            this.Controls.Add(this.btnCategorySave);
            this.Controls.Add(this.tbCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Button tbWindowClose;
        private System.Windows.Forms.Label label3;
    }
}