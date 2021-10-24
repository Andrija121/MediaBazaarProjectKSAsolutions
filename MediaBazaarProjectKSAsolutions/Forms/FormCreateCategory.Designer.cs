
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
            this.btnCategorySave.Location = new System.Drawing.Point(294, 78);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySave.TabIndex = 1;
            this.btnCategorySave.Text = "Add Category";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // tbWindowClose
            // 
            this.tbWindowClose.Location = new System.Drawing.Point(294, 133);
            this.tbWindowClose.Name = "tbWindowClose";
            this.tbWindowClose.Size = new System.Drawing.Size(75, 23);
            this.tbWindowClose.TabIndex = 2;
            this.tbWindowClose.Text = "Cancel";
            this.tbWindowClose.UseVisualStyleBackColor = true;
            this.tbWindowClose.Click += new System.EventHandler(this.tbWindowClose_Click);
            // 
            // FormCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 193);
            this.Controls.Add(this.tbWindowClose);
            this.Controls.Add(this.btnCategorySave);
            this.Controls.Add(this.tbCategoryName);
            this.Name = "FormCreateCategory";
            this.Text = "FormCreateCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Button tbWindowClose;
    }
}