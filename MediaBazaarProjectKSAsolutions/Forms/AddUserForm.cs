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
    public partial class AddUserForm : Form
    {

        UserManagement um = new UserManagement();
        
        public AddUserForm()
        {
            InitializeComponent();
            
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cbRole.DataSource = Enum.GetValues(typeof(Role));
            cbStatus.DataSource = Enum.GetValues(typeof(Status));
        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                
                string userName = tbUserName.Text;
                string firstName = tbFirstName.Text;
                string lastName = tbLastName.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;
                DateTime birthday = DTPBirthday.Value;
                int bsn = Convert.ToInt32(tbBSN.Text);
                string zipCode = tbZipCode.Text;
                string address = tbAddress.Text;
                Gender gender = (Gender)cbGender.SelectedItem;
                Role role = (Role)cbRole.SelectedItem;
                Status status = (Status)cbStatus.SelectedItem;
                if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(bsn.ToString()) )
                {
                    MessageBox.Show("Fields are empty");

                }
                else if (um.CheckIfUserAlreadyExist(userName,email,bsn))
                {
                    MessageBox.Show("Values already exist");
                }
                else
                {
                    User user = new User(0, userName, firstName, lastName, email, password, birthday, bsn, zipCode, address, gender, role, status);
                    um.AddUser(user);
                    MessageBox.Show("User Created Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill in all the values " + ex.Message);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
