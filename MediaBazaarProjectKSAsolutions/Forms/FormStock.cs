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
    public partial class FormStock : Form
    {
        StockManagement sm = new StockManagement();
        User user;
        public FormStock()
        {
            InitializeComponent();
            RefreshListBox();
        }
        public void RefreshListBox()
        {
            lbStocks.Items.Clear();
            foreach (var s in sm.GetAllStock())
            {
                lbStocks.Items.Add(s);
            }
        }
        private void btnCreateStocks_Click(object sender, EventArgs e)
        {
            FormCreateStock formCreateStock = new FormCreateStock();
            formCreateStock.ShowDialog();
        }

        private void btnRefreshStocks_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }
       

        private void btnEditStocks_Click(object sender, EventArgs e)
        {
            Stock stock = (Stock)lbStocks.SelectedItem;
            EditStockForm editStockForm = new EditStockForm(stock);
            editStockForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
