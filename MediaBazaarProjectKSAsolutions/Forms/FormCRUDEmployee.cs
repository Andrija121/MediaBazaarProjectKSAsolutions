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
    public partial class FormCRUDEmployee : Form
    {
        User u;
        UserManagement userManagement;
        public FormCRUDEmployee(User user)
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
        private void btnAddUser_Click(object sender, EventArgs e)
        {

            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
            RefreshListBox();

        }

        private void btnMakeUserInactive_Click(object sender, EventArgs e)
        {
            User user = (User)lbUsers.SelectedItem;
            if (user != null)
            {
                userManagement.SetUserStatusToInactive(user);
                RefreshListBox();
                MessageBox.Show("User Made Inactive Successfully");
            }
            else
                MessageBox.Show("Please select the user you want to make inactive");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            User user = (User)lbUsers.SelectedItem;
            if (user != null)
            {
                EditUserForm editUserForm = new EditUserForm(user);
                editUserForm.ShowDialog();
                RefreshListBox();
            }
            else
                MessageBox.Show("Please select the user you want to edit");
        }

        private void btnSeeInactiveUsers_Click(object sender, EventArgs e)
        {
            InactiveUsersForm inactiveUsersForm = new InactiveUsersForm();
            inactiveUsersForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
