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
                dgvUsers.Rows.Add(u.Id, u.UserName, u.FirstName, u.LastName, u.Password, u.Email);
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
            RefreshListBox();
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

                if (u.Role == Role.GENERALMANAGER || u.Role == Role.DEPARTMENTMANAGER)
                {
                    panelDMandGM.Enabled = true;
                }
                else
                {
                    panelDMandGM.Enabled = false;
                }
            return u;
        }
        private User CheckIfUserHRorGM()
        {
                if (u.Role == Role.GENERALMANAGER || u.Role == Role.HRMANAGER)
                {
                    panelHRorGM.Enabled = true;
                }
            else
            {
                panelHRorGM.Enabled = false;
            }
            return u;
        }
        

        private void BtnSeeResupplyRequests_Click(object sender, EventArgs e)
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
    }
}
