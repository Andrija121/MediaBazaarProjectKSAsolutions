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
        DaysOffManagement doffm = new DaysOffManagement();
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
            try
            {
                User user = (User)cbHrManagers.SelectedItem;
                if(user==null)
                {
                    MessageBox.Show("Please Select HR Manager who will receive the request");
                    return;
                }
                else
                {
                    
                    DateTime startDate = dtpStartDate.Value;
                    DateTime endDate = dtpEndDate.Value;
                    string reason = tbReason.Text;
                    DaysOff daysOff = new DaysOff(0, user.Id, startDate, endDate, reason, RequestStatus.PENNDING);
                    if(DateTime.Now<startDate && startDate <endDate)
                    {
                        doffm.CreateDaysOffRequest(daysOff);
                        MessageBox.Show("You have succesfully created request");
                    }
                    else
                    {
                        MessageBox.Show("Start Date is not valid");
                    }
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DaysAwayForm_Load(object sender, EventArgs e)
        {
            tbUserName.Text = u.UserName;
            FindHRManagers();

        }
        private List<User> FindHRManagers()
        {
            List<User> hrManagers = new List<User>();
            foreach (var hr in um.GetUsers())
            {
                if(hr.Role==Role.HRMANAGER)
                {
                    cbHrManagers.Items.Add(hr);
                }
            }
            return hrManagers;
        }
    }
}
