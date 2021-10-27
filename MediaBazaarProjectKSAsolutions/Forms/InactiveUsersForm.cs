using System;
using MediaBazaarProjectKSAsolutions.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    
    public partial class InactiveUsersForm : Form
    {
        UserManagement userManagement;
        public InactiveUsersForm()
        {
            InitializeComponent();
            userManagement = new UserManagement();
            RefreshListBox();
            MessageBox.Show("Double click the user to make persons status set to active");
        }
        public void RefreshListBox()
        {
            lbInactiveUsers.Items.Clear();
            foreach (var u in userManagement.GetInactiveUsers())
            {
                lbInactiveUsers.Items.Add(u);
            }
            foreach (var u in userManagement.GetAwayUsers())
            {
                lbInactiveUsers.Items.Add(u);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbAwayUsers_CheckedChanged(object sender, EventArgs e)
        {
            lbInactiveUsers.Items.Clear();
            if(rbAwayUsers.Checked)
            {
                foreach (var u in  userManagement.GetAwayUsers())
                {
                    lbInactiveUsers.Items.Add(u);
                }
            }
        }

        private void rbInactiveUsers_CheckedChanged(object sender, EventArgs e)
        {
            
            if(rbInactiveUsers.Checked)
            {
                foreach (var u in userManagement.GetInactiveUsers())
                {
                    lbInactiveUsers.Items.Add(u);
                }
            }
        }

        private void rbInactiveUsers_Leave(object sender, EventArgs e)
        {
            rbInactiveUsers.Checked = false;
            RefreshListBox();
        }

        private void rbAwayUsers_Leave(object sender, EventArgs e)
        {
            rbAwayUsers.Checked = false;
            RefreshListBox();
        }

        private void lbInactiveUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            User user = (User)lbInactiveUsers.SelectedItem;
            if (user != null)
                userManagement.SetUserStatusToActive(user);
            else
                MessageBox.Show("Please double click the user You want to make active");

            RefreshListBox();
        }

        private void InactiveUsersForm_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
