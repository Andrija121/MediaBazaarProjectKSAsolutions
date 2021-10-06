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

        StockManagement sm = new StockManagement();

        public FormCreateStock()
        {
            InitializeComponent();
        }

        private void btnAddStockConfirmation_Click(object sender, EventArgs e)
        {
            try
            {

                string stockName = tbxNewStockName.Text;
                int stockPrice = Convert.ToInt32(tbxNewStockPrice.Text);
                int stockSerialNumber = Convert.ToInt32(tbxNewStockSerialNumber.Text);
                int stockAmount = Convert.ToInt32(tbxNewStockAmount.Text);

                Stock stock = new Stock(0, stockName, stockPrice, stockSerialNumber, stockAmount);
                sm.AddStock(stock);
                MessageBox.Show("Item Created Successfully");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }


            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
