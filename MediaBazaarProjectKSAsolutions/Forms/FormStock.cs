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
        private User loggedIn;
        private ButtonClicks button = new ButtonClicks();

        public FormStock(User user)
        {
            InitializeComponent();
            this.loggedIn = user;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormEmployee FormEmployee = new FormEmployee(loggedIn);
            FormEmployee.Show();
            Hide();
        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            // you are already here silly
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            FormDepartment FormDepartment = new FormDepartment(loggedIn);
            FormDepartment.Show();
            Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently not available.");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently not available.");
        }

        private void btnViewStocks_Click(object sender, EventArgs e)
        {
            
            //foreach (var s in Classes.StockManagement.GetAllStock())
            //{
            //    dgStock.add
            //}
            //Classes.StockManagement.GetAllStock();
        }

        private void btnCreateStocks_Click(object sender, EventArgs e)
        {

        }

        private void pnlEmployees_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
