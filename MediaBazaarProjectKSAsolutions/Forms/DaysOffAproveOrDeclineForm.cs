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
    public partial class DaysOffAproveOrDeclineForm : Form
    {
        User u;
        DaysOffManagement doffm = new DaysOffManagement();
        DaysOff doff;
        public DaysOffAproveOrDeclineForm(DaysOff daysOff, User user)
        {
            InitializeComponent();
            this.u = user;
            this.doff = daysOff;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
             
            doffm.ApproveRequest(doff,u.Id);
            MessageBox.Show("Approved successfully");
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            doffm.DeclineRequest(doff, u.Id);
            MessageBox.Show("Declined successfully");
            this.Close();
        }
    }
}
