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
    public partial class FormApproveOrDeclineRequest : Form
    {
        ResupplyRequest rr;
        RequestResupplyManagement rrm = new RequestResupplyManagement();
        StockManagement sm = new StockManagement();
        User user;
        public FormApproveOrDeclineRequest(ResupplyRequest resupplyRequest,User u)
        {
            InitializeComponent();
            this.rr = resupplyRequest;
            this.user = u;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            int  stockId=rr.Stock.Id;

            foreach (var s in sm.GetAllStock())
            {
                if(s.Id==stockId)
                {
                    s.Amount += rr.AmountRequested;
                    rrm.ApproveRequest(rr, user.Id);
                    MessageBox.Show("Stock was resupplied successfully");
                    this.Close();
                }
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            rrm.DeclineRequest(rr,user.Id);
            MessageBox.Show("Stock resupply declined");
            this.Close();
        }

        private void btnApprovePartially_Click(object sender, EventArgs e)
        {
            if (tbApprovePartially==null)
            {
                MessageBox.Show("The quantity that you want to resupply is incorrect, please ipunt propper one or check with manager");
                return;
            }
            label1.Text = " / " + rr.AmountRequested;
            int amount = rr.AmountFulfilled;
            amount= Convert.ToInt32(tbApprovePartially.Text);
            rrm.PartiallyApproveRquest(rr, user.Id,amount);
        }
    }
}
