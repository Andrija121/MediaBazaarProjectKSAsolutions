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
        public FormStock()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormEmployee FormEmployee = new FormEmployee();
            FormEmployee.Show();
            Hide();
        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            FormStock FormStock = new FormStock();
            FormStock.Show();
            Hide();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            FormDepartment FormDepartment = new FormDepartment();
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

        private void btnCreateStocks_Click(object sender, EventArgs e)
        {
            FormCreateStock formCreateStock = new FormCreateStock();
            formCreateStock.Show();
        }

        private void btnEditStocks_Click(object sender, EventArgs e)
        {
            FormUpdateStock formUpdateStock = new FormUpdateStock();
            formUpdateStock.Show();
        }
    }
}
