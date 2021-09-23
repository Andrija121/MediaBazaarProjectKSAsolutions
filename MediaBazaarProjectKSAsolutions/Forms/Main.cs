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
            u= user;
            lblHi.Text = "Hi, "+u.FirstName;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlEmployees.Visible = true;
            pnlStocks.Visible = false;
            pnlDepartments.Visible = false;
            pnlSchedule.Visible = false;
            pnlStatistics.Visible = false;
        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            pnlEmployees.Visible = false;
            pnlStocks.Visible = true;
            pnlDepartments.Visible = false;
            pnlSchedule.Visible = false;
            pnlStatistics.Visible = false;
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            pnlEmployees.Visible = false;
            pnlStocks.Visible = false;
            pnlDepartments.Visible = true;
            pnlSchedule.Visible = false;
            pnlStatistics.Visible = false;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            pnlEmployees.Visible = false;
            pnlStocks.Visible = false;
            pnlDepartments.Visible = false;
            pnlSchedule.Visible = true;
            pnlStatistics.Visible = false;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            pnlEmployees.Visible = false;
            pnlStocks.Visible = false;
            pnlDepartments.Visible = false;
            pnlSchedule.Visible = false;
            pnlStatistics.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
