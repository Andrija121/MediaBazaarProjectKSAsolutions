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
            tbPassword.PasswordChar = '*';
        }

        private void LL_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Feature in progress");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {

                string userNameOrEmail = tbUserName.Text;
                string password = tbPassword.Text;
                User user = null;
                if (userNameOrEmail != "" && password != "")
                {
                    foreach (var u in userManagement.GetUsers())
                    {
                        if (u.UserName == userNameOrEmail || u.Email == userNameOrEmail && u.Password == password)
                        {
                            if (u.Role == Role.GENERALMANAGER || u.Role == Role.HRMANAGER || u.Role == Role.DEPARTMENTMANAGER)
                            {
                                user = u;
                                Main main = new Main(user);
                                main.Show();
                                this.Hide();
                                break;
                            }
                            else if(u.Role==Role.STOREEMPLOYEE || u.Role==Role.WAREHOUSEEMPLOYEE)

                            {
                                user = u;
                                FormEmployee formEmployee = new FormEmployee(user);
                                formEmployee.Show();
                                this.Hide();
                                break;
                            }
                        }
                    }
                    if (user == null)
                    {
                            MessageBox.Show("Wrong Credentials");   
                    }
                }
                else
                    MessageBox.Show("Please fill out the values");
            }
            
            catch (Exception)
            {

                throw;
            }
            
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void btnPasswordForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature in progress");
        }
    }
}
