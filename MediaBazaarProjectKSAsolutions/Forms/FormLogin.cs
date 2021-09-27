using MediaBazaarProjectKSAsolutions.Classes;
using MediaBazaarProjectKSAsolutions.Forms;
using MySql.Data.MySqlClient;
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
        Classes.UserManagement userManagement;
        public FormLogin()
        {
            InitializeComponent();
            userManagement = new Classes.UserManagement();
        }

        private void LL_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userNameOrEmail = tbUserName.Text;
            string password = tbPassword.Text;
            User user;
            foreach (var u in userManagement.GetUsers())
            {
                if (u.UserName==userNameOrEmail || u.Email==userNameOrEmail  && u.Password == password)
                {
                        user = u;
                        Main main = new Main(user);
                        main.Show();
                        this.Hide();
                }
                else
                    MessageBox.Show("Wrong credentials");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void btnPasswordForget_Click(object sender, EventArgs e)
        {

        }
    }
}
