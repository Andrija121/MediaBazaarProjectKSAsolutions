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
        User u;
        UserManagement userManagement;
        public FormEmployee(User user)
        {
            InitializeComponent();
            this.u = user;
            userManagement = new UserManagement();
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            lbUsers.Items.Clear();
            foreach (var u in userManagement.GetUsers())
            {
                lbUsers.Items.Add(u);
            }
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormEmployee FormEmployee = new FormEmployee(u);
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

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(u);
            addUserForm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lbUsers.Items.RemoveAt(u.Id);
        }
    }
}
