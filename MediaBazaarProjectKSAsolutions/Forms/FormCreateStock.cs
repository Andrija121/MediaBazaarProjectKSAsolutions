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

        public FormCreateStock()
        {
            InitializeComponent();
            sm = new StockManagement();
        }

        private void btnAddStockConfirmation_Click(object sender, EventArgs e)
        {
            try
            {

                string stockName = tbxNewStockName.Text;
                double stockPrice = Convert.ToDouble(tbxNewStockPrice.Text);
                int stockSerialNumber = Convert.ToInt32(tbxNewStockSerialNumber.Text);
                int stockAmount = Convert.ToInt32(tbxNewStockAmount.Text);

                Stock stock = new Stock(0, stockName,stockPrice, stockSerialNumber, stockAmount);
                sm.AddStock(stock);
                MessageBox.Show("Item Created Successfully");


            }
            catch (Exception)
            {

                MessageBox.Show("Input value is not correct");
            }


            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
