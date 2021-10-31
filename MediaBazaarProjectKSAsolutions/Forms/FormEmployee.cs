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
        RequestResupplyManagement rrm;
        StockManagement sm;
        Contract c;
        public FormEmployee(User user)
        {
            InitializeComponent();
            this.u = user;
            this.um = new UserManagement();
            this.sm = new StockManagement();
            this.c = um.GetContract(u.Id);
            this.rrm = new RequestResupplyManagement();
            PanelMovment(btnDashboard);
            lblHi.Text = "Welcome Back, " + u.FirstName + "\n You are currently logged in as: \n " + u.Role.ToString().ToLower();
            lblApproximateEarning.Text = c.SalaryPerHour * 120 + " $ - " + c.SalaryPerHour * 240 + " $ ";
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cbRole.DataSource = Enum.GetValues(typeof(Role));
            RefreshListBox(lbStocks);
            
        }
        public void NotifyWareHouseEmployees()
        {
            //Add info button or some "House Rules"
        }

        public void RefreshListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var item in sm.GetAllStock())
            {
                listBox.Items.Add(item);

            }

        }
        public void PanelMovment(Button button)
        {
            pnlNav.Height = button.Height;
            pnlNav.Top = button.Top;
            pnlNav.Left = button.Left;
            button.BackColor = Color.Black;
        }
        public void NavigationPanelMovment(Button button)
        {
            pnlNav.Height = button.Height;
            pnlNav.Top = button.Top;
            button.BackColor = Color.Black;
        }
        public void ButtonLeaveChangeColor(Button button)
        {
            button.BackColor = Color.DarkOrchid;
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            NavigationPanelMovment(btnBack);
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            tcNavigation.SelectedTab = tabPageDashboard;
            PanelMovment(btnDashboard);

        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            tcNavigation.SelectedTab = tabPageShift;
            NavigationPanelMovment(btnShift);
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            tcNavigation.SelectedTab = tabPageProfile;
            NavigationPanelMovment(btnProfile);

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
            NavigationPanelMovment(btnContract);

            StartDatedateTimePicker.Value = c.StartDate;
            EndDatedateTimePicker.Value = c.EndDate;
            tbContractType.Text = c.ContractType.ToString();
            tbSalaryPerHour.Text = c.SalaryPerHour.ToString();
            
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
        private void btnContract_Leave(object sender, EventArgs e)
        {
            ButtonLeaveChangeColor(btnContract);
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

        private void lbStocks_DoubleClick(object sender, EventArgs e)
        {
            
            Stock stock = (Stock)lbStocks.SelectedItem;
            //ResupplyRequest rr = new ResupplyRequest(u.Id,, stock.Id, double, requestStatus);
            if (stock != null)
            {
                if (u.Role == Role.WAREHOUSEEMPLOYEE)
                {
                    RequestResupplyForm requestResupplyForm = new RequestResupplyForm(u,stock);
                    requestResupplyForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You are not Warehouse employee, you can not ask for resupply");
                }

            }
            else
                MessageBox.Show("Please select the stock you want to edit");

        }
    }
}
