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
    public partial class RequestResupplyForm : Form
    {
        User u;
        Stock s;
        UserManagement um = new UserManagement();
        RequestResupplyManagement rrm = new RequestResupplyManagement();
        public RequestResupplyForm(User user,Stock stock)
        {
            InitializeComponent();
            this.u = user;
            this.s = stock;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestResupplyForm_Load(object sender, EventArgs e)
        {
            tbUserName.Text = u.UserName;
            tbStock.Text = s.ProductName;
            FindDeparmentManagers();
            tbAmount.Text = 1.ToString();
        }

        private List<User> FindDeparmentManagers()
        {
            List<User> departmentManagers = new List<User>();
            foreach (var u in um.GetUsers())
            {
                if (u.Role == Role.DEPARTMENTMANAGER)
                {
                    cbDMs.Items.Add(u);
                }
                departmentManagers.Add(u);
            }
            return departmentManagers;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
             {
                User user = (User)cbDMs.SelectedItem;
                RequestStatus rs = RequestStatus.PENNDING;
                int amount = Convert.ToInt32(tbAmount.Text);
                ResupplyRequest rr = new ResupplyRequest(u.Id, user.Id, s.Id, amount, rs);
  //              rrm.CreateNewRequest(rr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Propper values" + ex);
            }
        }
    }
}
