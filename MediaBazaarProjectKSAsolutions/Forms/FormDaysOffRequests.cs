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
    public partial class FormDaysOffRequests : Form
    {
        User u;
        DaysOffManagement doffm = new DaysOffManagement();
        public FormDaysOffRequests(User user)
        {
            InitializeComponent();
            this.u = user;
            RefreshListBox();
        }
        public void RefreshListBox()
        {
            lbDaysOffRequests.Items.Clear();
            foreach (var item in doffm.GetRequestsForDaysOff())
            {
                lbDaysOffRequests.Items.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbDaysOffRequests_DoubleClick(object sender, EventArgs e)
        {
            DaysOff doff = doffm.GetDayOff(u.Id);

            if (doff==null)
            {
                MessageBox.Show("Please Select request you want to approve");
            }
            else
            {
            DaysOffAproveOrDeclineForm daysOffAproveOrDeclineForm = new DaysOffAproveOrDeclineForm(doff,u);
            daysOffAproveOrDeclineForm.ShowDialog();
                RefreshListBox();
            }
        }
    }
}
