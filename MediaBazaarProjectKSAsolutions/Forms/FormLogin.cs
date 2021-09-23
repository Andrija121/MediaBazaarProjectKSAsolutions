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
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            User user = null;
            foreach (var u in userManagement.GetUsers())
            {
                if(u.FirstName==userName && u.Password==password)
                {
                    
                    if((GeneralManager)user==u)
                    { 
                    Main main = new Main(user);
                    main.Show();
                    this.Hide();
                    }
                    else if((HRManager)user == u)
                    {
                        Main main = new Main(user);
                        main.Show();
                        this.Hide();
                    }
                   else if ((DepartmentManager)user == u)
                    {
                        Main main = new Main(user);
                        main.Show();
                        this.Hide();
                    }
                    else if((StoreEmployee)user == u)
                    {
                        Main main = new Main(user);
                        main.Show();
                        this.Hide();
                    }
                    else if ((WarehouseEmployee)user == u)
                    {
                        Main main = new Main(user);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Test");
                    }
                }
                else
                    MessageBox.Show("Wrong credentials");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            userManagement.AddUser(new User(1, "aa", "aa", "aa", "asad", Geneder.MALE, DateTime.Now, 123, "asad", "asad"));
        }

        private void btnPasswordForget_Click(object sender, EventArgs e)
        {

        }
    }
}
