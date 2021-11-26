using MediaBazaarProjectKSAsolutions.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class FormCreateCategory : Form
    {
        CategoryManagement cm = new CategoryManagement();
        
        public FormCreateCategory()
        {
            InitializeComponent();
        }

        private void tbWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            string categoryName = tbCategoryName.Text;
            Category category = new Category(0, categoryName);
            if (category.CategoryName == string.Empty)
            {
                MessageBox.Show("Invalid category name.");
            }
            else
            {
                cm.AddCategory(category);
                MessageBox.Show("Category Created");
                this.Close();
            }
        }
    }
}
