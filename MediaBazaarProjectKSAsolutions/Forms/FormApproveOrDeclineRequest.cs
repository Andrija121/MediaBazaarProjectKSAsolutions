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
        public FormApproveOrDeclineRequest(ResupplyRequest resupplyRequest)
        {
            InitializeComponent();
            this.rr = resupplyRequest;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            rrm.ApproveRequest(rr); // moze metoda sa userom 
            int  stockId=rr.StockId;

            foreach (var s in sm.GetAllStock())
            {
                if(s.Id==stockId)
                {
                    s.Amount += rr.Amount;
                    MessageBox.Show("Stock was resupplied successfully");
                }
                else
                {
                    MessageBox.Show("stock not found");
                }
            }
            

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            rrm.DeclineRequest(rr);
            MessageBox.Show("Stock resupply declined");
        }
    }
}
