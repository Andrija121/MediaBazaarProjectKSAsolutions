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
        }
        public void RefreshListBox()
        {
            lbInactiveUsers.Items.Clear();
            foreach (var u in userManagement.GetInactiveUsers())
            {
                lbInactiveUsers.Items.Add(u);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
