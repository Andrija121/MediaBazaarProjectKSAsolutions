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
    public partial class FormResupplyRequestS : Form
    {
        User u;
        RequestResupplyManagement rrm = new RequestResupplyManagement();
        public FormResupplyRequestS(User user)
        {
            InitializeComponent();
            this.u = user;
            RefreshListBox();
           
        }
        public void RefreshListBox()
        {
            
            lbResupplyRequests.Items.Clear();
            foreach (var prr in rrm.GetPendingResupplyRequests())
            {
                lbResupplyRequests.Items.Add(prr);
            }

        }
        private void FormResupplyRequestS_Load(object sender, EventArgs e)
        {
           RefreshListBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            RefreshListBox();
        }

        private void lbResupplyRequests_DoubleClick(object sender, EventArgs e)
        {
            ResupplyRequest resupplyRequest = (ResupplyRequest)lbResupplyRequests.SelectedItem;
            if(resupplyRequest!=null)
            {
                if(u.Role==Role.GENERALMANAGER)
                {
                    MessageBox.Show("Sorry, Only Department Manager can do that (:");
                }
                else
                {
                    ResupplyRequest rr = rrm.GetResupplyRequest(u.Id);
                    resupplyRequest = rrm.GetResupplyRequest(u.Id);
                    FormApproveOrDeclineRequest formApproveOrDeclineRequest = new FormApproveOrDeclineRequest(resupplyRequest, u);
                    formApproveOrDeclineRequest.Show();
                    
                }
            }
            
        }
    }
}
