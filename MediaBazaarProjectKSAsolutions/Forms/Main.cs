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
            this.u = user;
            if (u.Role == Role.GENERALMANAGER)
            {
            }
            else if (u.Role == Role.DEPARTMENTMANAGER)
            {
                btnStatistics.Hide();
                btnStocks.Hide();

            }
            else
                btnStatistics.Hide();

            lblHi.Text = "Welcome back, " + u.FirstName;
        }
        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            FormCRUDEmployee FormEmployee = new FormCRUDEmployee(u);
            FormEmployee.ShowDialog();
          
        }

        private void btnDepartments_Click_1(object sender, EventArgs e)
        {
            FormDepartment FormDepartment = new FormDepartment();
            FormDepartment.ShowDialog();
          
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();
            formStock.ShowDialog();
            

        }

        private void btnSchedule_Click_1(object sender, EventArgs e)
        {

            FormSchedule formSchedule = new FormSchedule(u);
            formSchedule.ShowDialog();
        }


        private void btnStatistics_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Currently not available. ");
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
