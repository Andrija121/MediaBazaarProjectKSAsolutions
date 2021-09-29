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
    public partial class FormEmployee : Form
    {
        private ButtonClicks button = new ButtonClicks();
        private User loggedIn;
        public FormEmployee(User user)
        {
            InitializeComponent();
            this.loggedIn = user;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            button.btnEmployee(loggedIn);
        }        
        private void btnStock_Click(object sender, EventArgs e)
        {
            button.btnStock(loggedIn);
            Hide();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            button.btnDepartment(loggedIn);
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

        private void btnStocks_Click(object sender, EventArgs e)
        {

        }
    }
}
