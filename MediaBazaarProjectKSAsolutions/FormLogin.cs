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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LL_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Main main = new Forms.Main();
            
            main.Show();
            
        }
    }
}
