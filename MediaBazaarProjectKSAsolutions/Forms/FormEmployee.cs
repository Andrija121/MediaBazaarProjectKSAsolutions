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
        UserManagement um;
        public FormEmployee(User user)
        {
            InitializeComponent();
            this.u = user;
            this.um = new UserManagement();
            PanelMovment(btnDashboard);
            lblHi.Text = "Welcome Back, " + u.FirstName + "\n You are currently logged in as: \n " + u.Role.ToString().ToLower();
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cbRole.DataSource = Enum.GetValues(typeof(Role));
            
        }
        public void PanelMovment(Button button)
        {
            pnlNav.Height = button.Height;
            pnlNav.Top = button.Top;
            pnlNav.Left = button.Left;
            button.BackColor = Color.Black;
        }
        public void ButtonLeaveChangeColor(Button button)
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
            tcNavigation.SelectedTab = tabPageDashboard;
            PanelMovment(btnDashboard);
            Contract contract= um.GetContract(u.Id);
                lblApproximateEarning.Text =contract.SalaryPerHour * 120 + " $ - " + contract.SalaryPerHour * 240 + " $ ";

        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            tcNavigation.SelectedTab = tabPageShift;
            PanelMovment(btnShift);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            ButtonLeaveChangeColor(btnDashboard);
        }

        private void btnShift_Leave(object sender, EventArgs e)
        {
            ButtonLeaveChangeColor(btnShift);
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            ButtonLeaveChangeColor(btnProfile);
        }

        private void btnBack_Leave(object sender, EventArgs e)
        {
            ButtonLeaveChangeColor(btnBack);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            tcNavigation.SelectedTab = tabPageProfile;
            PanelMovment(btnProfile);

            tbUserName.Text = u.UserName;
            tbFirstName.Text = u.FirstName;
            tbLastName.Text = u.LastName;
            tbEmail.Text = u.Email;
            tbPassword.Text = u.Password;
            DTPBirthday.Value = u.Birtyhday;
            cbGender.SelectedItem= u.Gender.ToString();
            cbRole.Text= u.Role.ToString();
            tbBSN.Text = u.BSN.ToString();
            tbAddress.Text = u.Address;
            tbZipCode.Text = u.ZipCode;
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            tcNavigation.SelectedTab = tabPageContract;
            PanelMovment(btnContract);

           Contract contract= um.GetContract(u.Id);
            tbStartDate.Text = contract.StartDate.ToString();
            tbEndDate.Text = contract.EndDate.ToString();
            tbContractType.Text = contract.ContractType.ToString();
            tbSalaryPerHour.Text = contract.SalaryPerHour.ToString();
            
        }

        private void btnContract_Leave(object sender, EventArgs e)
        {
            ButtonLeaveChangeColor(btnContract);
        }

        private void btnSetUserAway_Click(object sender, EventArgs e)
        {

            
            DaysAwayForm daysAwayForm = new DaysAwayForm(u);
            daysAwayForm.ShowDialog();
            
        }

        private void btnSaveUserInformation_Click(object sender, EventArgs e)
        {
            try
            {
                u.UserName = tbUserName.Text;
                u.FirstName = tbFirstName.Text;
                u.LastName = tbLastName.Text;
                u.Email = tbEmail.Text;
                u.Birtyhday = DTPBirthday.Value;
                u.BSN = Convert.ToInt32(tbBSN.Text);
                u.ZipCode = tbZipCode.Text;
                u.Address = tbAddress.Text;
                u.Gender = (Gender)cbGender.SelectedItem;
                u.Role = (Role)cbRole.SelectedItem;


                if (u.Password == null || u.UserName == null || u.BSN.ToString() == null || u.FirstName == null || u.LastName == null)
                {
                    MessageBox.Show("Input value is not correct");
                }
                else
                {
                    um.EditUser(u);
                    MessageBox.Show("Successfully Edited User");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }
    }
}
