using System;
using MediaBazaarProjectKSAsolutions.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class FormCreateStock : Form
    {

        StockManagement sm;
        CategoryManagement cm;
        public FormCreateStock()
        {
            InitializeComponent();
            sm = new StockManagement();
            cm = new CategoryManagement();
            RefreshCB();
        }

        public void RefreshCB()
        {
            cbCategories.Items.Clear();
            foreach (var c in cm.GetCategories())
            {
                cbCategories.Items.Add(c);
            }
        }

     

        private void btnAddStockConfirmation_Click(object sender, EventArgs e)
        {
            try
            {
                int categoryId = (int)cbCategories.SelectedItem;
                string stockName = tbxNewStockName.Text;
                double stockPrice = Convert.ToDouble(tbxNewStockPrice.Text);
                int stockSerialNumber = Convert.ToInt32(tbxNewStockSerialNumber.Text);
                int stockAmount = Convert.ToInt32(tbxNewStockAmount.Text);
                

                Stock stock = new Stock(0, stockName,stockPrice, stockSerialNumber, stockAmount,categoryId);
                sm.AddStock(stock);
                MessageBox.Show("Item Created Successfully");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Input value is not correct" + ex);
            }


            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            FormCreateCategory formCreateCategory = new FormCreateCategory();
            formCreateCategory.ShowDialog();
            RefreshCB();
        }
    }
}
