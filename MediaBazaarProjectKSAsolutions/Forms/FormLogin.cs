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
            

            MySqlConnection conn = new MySqlConnection("server = studmysql01.fhict.local; database = dbi454447; uid = root; password = root; ");
            
            string query = "SELECT firstName,password FROM user where firstName = @firstName and password = @password";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@firstName", tbUserName.Text);
            cmd.Parameters.AddWithValue("@password", tbPassword.Text);

            cmd.ExecuteNonQuery();            
            
        }
    }
}
