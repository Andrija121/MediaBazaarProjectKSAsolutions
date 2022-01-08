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
            RefreshDGV();
        }

        public void RefreshListBox()
        {
            lbUsers.Items.Clear();
            foreach (var u in userManagement.GetUsers())
            {
                lbUsers.Items.Add(u);
            }
        }
        public void RefreshDGV()
        {
            dgvUsers.Rows.Clear();
            foreach (var u in userManagement.GetUsers())
            {
                dgvUsers.Rows.Add(u.Id, u.UserName, u.FirstName, u.LastName, u.Password, u.Email, u.Birtyhday, u.BSN, u.ZipCode, u.Address, u.Gender, u.Role);
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
                timer7Years.Start();
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
                Contract contract = userManagement.GetContract(user.Id);
                EditUserForm editUserForm = new EditUserForm(user,contract);
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
            RefreshDGV();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FormCRUDEmployee_Load(object sender, EventArgs e)
        {
           ChekcIfUserDMorGM();
           CheckIfUserHRorGM();
        }

        private User ChekcIfUserDMorGM()
        {

            foreach (var u in userManagement.GetUsers())
            {
                if (u.Role == Classes.Role.GENERALMANAGER|| u.Role == Classes.Role.DEPARTMENTMANAGER)
                {
                    panelDMandGM.Enabled = true;
                }
            }
            return u;
        }
        private User CheckIfUserHRorGM()
        {
            foreach (var u in userManagement.GetUsers())
            {
                if (u.Role == Classes.Role.GENERALMANAGER || u.Role==Classes.Role.HRMANAGER)
                {
                    panelHRorGM.Enabled = true;
                }
            }
            return u;
        }

        private void btnSeeResupplyRequests_Click(object sender, EventArgs e)
        {
            //FormResupplyRequestS formResupplyRequestS = new FormResupplyRequestS(u);
            //formResupplyRequestS.ShowDialog();
            RequestResupplyForm rrf = new RequestResupplyForm(u);
            rrf.ShowDialog();
        }

        private void btnDaysOffRequests_Click(object sender, EventArgs e)
        {
            FormDaysOffRequests formDaysOffRequests = new FormDaysOffRequests(u);
            formDaysOffRequests.ShowDialog();
        }

        private void panelDMandGM_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
