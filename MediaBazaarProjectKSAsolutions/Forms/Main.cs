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
    public partial class Main : Form
    {
        User u;

        public Main(User user)
        {
            InitializeComponent();
            u = user;
            lblHi.Text = "Hi, "+u.FirstName;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
          
        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            //FormStock FormStock = new FormStock();
            //FormStock.Show();
            //Hide();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            FormEmployee FormEmployee = new FormEmployee(u);
            FormEmployee.Show();
            Hide();
        }

        private void btnDepartments_Click_1(object sender, EventArgs e)
        {
            FormDepartment FormDepartment = new FormDepartment();
            FormDepartment.Show();
            Hide();
        }
    }
}
