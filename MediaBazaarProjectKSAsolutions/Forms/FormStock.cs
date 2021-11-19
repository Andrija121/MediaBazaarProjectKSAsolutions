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
        CategoryManagement cm;
        public FormStock()
        {
            InitializeComponent();
            cm = new CategoryManagement();
            RefreshListBox();
            RefreshDVG();
        }

        public void RefreshDVG()
        {
            DVGStock.Rows.Clear();
            foreach (var s in cm.GetCombinedCategories())
            { 
                DVGStock.Rows.Add(s);
            }
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
            RefreshListBox();
        }

        private void btnRefreshStocks_Click(object sender, EventArgs e)
        {
            RefreshListBox();
            RefreshDVG();
        }
       

        private void btnEditStocks_Click(object sender, EventArgs e)
        {
            if (lbStocks.SelectedItem != null)
            {
                Stock stock = (Stock)lbStocks.SelectedItem;
                EditStockForm editStockForm = new EditStockForm(stock);
                editStockForm.ShowDialog();
                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnDelStock_Click(object sender, EventArgs e)
        {
            if (lbStocks.SelectedItem != null)
            {
                Stock stock = (Stock)lbStocks.SelectedItem;
                sm.DeleteStock(stock.Id);
                MessageBox.Show("Stock Deleted Succesfully");
                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }   
        }
    }
}
