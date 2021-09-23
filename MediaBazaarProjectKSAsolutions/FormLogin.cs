using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions
{
    public partial class FormLogin : Form
    {
        Class.UserManagement userManagement;
        public FormLogin()
        {
            InitializeComponent();
            userManagement = new Class.UserManagement();
        }

        private void LL_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName=tb
            foreach (var u in userManagement.GetUsers())
            {
                if(u.Id==)
            }
        }
    }
}
