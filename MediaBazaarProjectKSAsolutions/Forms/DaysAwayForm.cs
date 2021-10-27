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
    public partial class DaysAwayForm : Form
    {
        User u;
        UserManagement um = new UserManagement();
        public DaysAwayForm(User user)
        {
            this.u = user;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double daysoff = Convert.ToDouble(nUPDDaysOff.Value);
            um.SetUserStatusToAway(u, daysoff);
            MessageBox.Show("Your request was successfully sent,\n  even, if the request is not yet accepted your next " + daysoff + " days off starts now");

        }
    }
}
