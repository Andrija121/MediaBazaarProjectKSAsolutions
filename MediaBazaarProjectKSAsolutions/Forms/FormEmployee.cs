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
    public partial class FormEmployee : Form
    {
        User u;
        public FormEmployee(User user)
        {
            InitializeComponent();
            this.u = user;
            PanelMovment(btnDashboard);
        }
        public void PanelMovment(Button button)
        {
            pnlNav.Height = button.Height;
            pnlNav.Top = button.Top;
            pnlNav.Left = button.Left;
            button.BackColor = Color.Blue;
        }
        public void ButtonLeave(Button button)
        {
            button.BackColor = Color.DarkOrchid;
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            PanelMovment(btnBack);
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PanelMovment(btnDashboard);
            tcNavigation.SelectedTab = tabPageDashboard;
            

        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            PanelMovment(btnShift);
            tcNavigation.SelectedTab = tabPageShift;
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            ButtonLeave(btnDashboard);
            btnDashboard.BackColor = Color.DarkOrchid;
        }

        private void btnShift_Leave(object sender, EventArgs e)
        {
            ButtonLeave(btnShift);
            btnShift.BackColor = Color.DarkOrchid;
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {

            ButtonLeave(btnProfile);
            btnProfile.BackColor = Color.DarkOrchid;
        }

        private void btnBack_Leave(object sender, EventArgs e)
        {
            ButtonLeave(btnBack);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            PanelMovment(btnProfile);
            tcNavigation.SelectedTab = tabPageProfile;
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            PanelMovment(btnContract);
            tcNavigation.SelectedTab = tabPageContract;
        }

        private void btnContract_Leave(object sender, EventArgs e)
        {
            ButtonLeave(btnContract);
        }
    }
}
