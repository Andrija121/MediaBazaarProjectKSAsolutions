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
        EventDTO eventDTO;
        public FormEmployee(User user)
        {
            InitializeComponent();
            this.u = user;
            this.um = new UserManagement();
            this.sm = new StockManagement();
            this.c = um.GetContract(u.Id);
            this.rrm = new RequestResupplyManagement();
            this.eventDTO = new EventDTO();
            PanelMovment(btnDashboard);
            lblHi.Text = "Welcome Back, " + u.FirstName + "\n You are currently logged in as: \n " + u.Role.ToString().ToLower();
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cbRole.DataSource = Enum.GetValues(typeof(Role));
            RefreshListBox(lbStocks);
            RefreshEventLoggerWithResupplyRequests(lbEventLogger);
            RefreshEventLoggerWithDaysOffRequests(lbDayOffEvents);
            if (c == null)
            {
                MessageBox.Show("Contract does not exist");
                return;
            }
            else
            {
                lblApproximateEarning.Text = "100 $ - " + c.SalaryPerHour * 156 + " $ ";
            }  
        }

        public void RefreshListBox(ListBox listBox)
        {
            
            listBox.Items.Clear();
            foreach (var item in sm.GetAllStock())
            {
                listBox.Items.Add(item);
            }

        }
        public void RefreshEventLoggerWithResupplyRequests(ListBox listbox)
        {
            
            listbox.Items.Clear();
            foreach (var resupplyRequest in eventDTO.GetAllResupplyEvents())
            {
                listbox.Items.Add(resupplyRequest);
            }
        }
        public void RefreshEventLoggerWithDaysOffRequests(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var item in eventDTO.GetAllAnsweredRequestsOFDaysOff())
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
        {   if(c==null)
            {
                MessageBox.Show("Curent User does not have a contract");
            }
            else
            {
                tcNavigation.SelectedTab = tabPageContract;
                NavigationPanelMovment(btnContract);

                StartDatedateTimePicker.Value = c.StartDate;
                EndDatedateTimePicker.Value = c.EndDate;
                tbContractType.Text = c.ContractType.ToString();
                tbSalaryPerHour.Text = c.SalaryPerHour.ToString();
            }
            
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
            if (stock != null)
            {
                if (u.Role == Role.WAREHOUSEEMPLOYEE)
                {
                    FormResupplyRequestS requestResupplyForm = new FormResupplyRequestS(u);
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

        private void lblApproximateEarning_Click(object sender, EventArgs e)
        {
            if(c==null)
            {
                MessageBox.Show("Contract Is null");
                return;
            }
            else
            {
                FormEarnings formEarnings = new FormEarnings(u);
                formEarnings.ShowDialog();
            }
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            tcNavigation.SelectedTab = tabPageAnnouncements;
            PanelMovment(btnAnnouncement);
        }

        private void btnSeeResupplyRequests_Click(object sender, EventArgs e)
        {
            if (u.Role == Role.WAREHOUSEEMPLOYEE)
            {
                FormResupplyRequestS requestResupplyForm = new FormResupplyRequestS(u);
                requestResupplyForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not Warehouse employee, you can not ask for resupply");
            }

        }

        private void pnlStocks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
