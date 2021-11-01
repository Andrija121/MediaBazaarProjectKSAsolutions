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
        }
        public void RefreshListBox()
        {
            lbResupplyRequests.Items.Clear();

        }
        private void FormResupplyRequestS_Load(object sender, EventArgs e)
        {
            ResupplyRequest rr = rrm.GetResupplyRequest(u.Id);
            
            lbResupplyRequests.Items.Add(rr);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbResupplyRequests_DoubleClick(object sender, EventArgs e)
        {
            ResupplyRequest resupplyRequest = (ResupplyRequest)lbResupplyRequests.SelectedItem;

            if(resupplyRequest!=null)
            {
                FormApproveOrDeclineRequest formApproveOrDeclineRequest = new FormApproveOrDeclineRequest(resupplyRequest);
                formApproveOrDeclineRequest.Show();
            }
        }
    }
}
