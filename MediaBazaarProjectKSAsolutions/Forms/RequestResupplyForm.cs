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
        UserManagement um = new UserManagement();
        StockManagement sm = new StockManagement();
        RequestResupplyManagement rrm = new RequestResupplyManagement();
        public RequestResupplyForm(User user)
        {
            InitializeComponent();
            this.u = user;
        }
        public void GetAllStocks()
        {

            cbStock.Items.Clear();
            foreach (var s in sm.GetAllStock())
            {
                cbStock.Items.Add(s);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestResupplyForm_Load(object sender, EventArgs e)
        {
            tbUserName.Text = u.UserName;
            GetAllStocks();
            FindWHEs();
            tbAmount.Text = 1.ToString();
        }

        private List<User> FindWHEs()
        {
            List<User> warehouseEmployees = new List<User>();
            foreach (var u in um.GetUsers())
            {
                if (u.Role == Role.WAREHOUSEEMPLOYEE)
                {
                    cbDMs.Items.Add(u);
                }
                warehouseEmployees.Add(u);
            }
            return warehouseEmployees;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
             {
                User user = (User)cbDMs.SelectedItem;
                Stock stock = (Stock)cbStock.SelectedItem;
                if(user==null)
                {
                    MessageBox.Show("Please select Department manager you want to send request to");
                    return;
                }
                RequestStatus rs = RequestStatus.PENNDING;
                int amountRequested = Convert.ToInt32(tbAmount.Text);
                ResupplyRequest rr = new ResupplyRequest(0,user, u, stock, amountRequested,0, rs);
                rrm.CreateNewRequest(rr);
                MessageBox.Show("Resupply request was sent succesfully, in short the asnwer will be visble on the dasboard");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Insert Propper values" + ex);
            }
        }
    }
}
