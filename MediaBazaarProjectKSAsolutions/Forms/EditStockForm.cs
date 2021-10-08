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
    public partial class EditStockForm : Form
    {
        Stock s;
        StockManagement sm;
        public EditStockForm(Stock stock)
        {
            InitializeComponent();
            this.s = stock;
            sm = new StockManagement();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStockForm_Load(object sender, EventArgs e)
        {
            tbxNewStockName.Text = s.ProductName;
            tbxNewStockPrice.Text = s.Price.ToString();
            tbxNewStockSerialNumber.Text = s.SerialNumber.ToString();
            tbxNewStockAmount.Text = s.Amount.ToString();
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        {
            s.ProductName = tbxNewStockName.Text;
            s.Price = Convert.ToInt32(tbxNewStockPrice.Text);
            s.SerialNumber = Convert.ToInt32(tbxNewStockSerialNumber.Text);
            s.Amount = Convert.ToInt32(tbxNewStockAmount.Text);

            sm.EditStock(s);

            MessageBox.Show("Successfully Edited Stock");


        }

        private void lblDepartmentName_Click(object sender, EventArgs e)
        {

        }
    }
}
