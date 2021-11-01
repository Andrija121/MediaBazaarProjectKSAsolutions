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

            rrm.ApproveRequest(rr, user.Id); 
            int  stockId=rr.StockId;

            foreach (var s in sm.GetAllStock())
            {
                if(s.Id==stockId)
                {
                    s.Amount += rr.Amount;
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
    }
}
