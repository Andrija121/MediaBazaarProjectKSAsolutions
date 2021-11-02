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
    public partial class FormEarnings : Form
    {
        User u;
        UserManagement um = new UserManagement();
        public FormEarnings(User user)
        {
            InitializeComponent();
            this.u = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double sph = Convert.ToDouble(tbSalary.Text);
            int hours = Convert.ToInt32(NUDHours.Text);

            int potentialEarning = (int)(sph * hours);

            MessageBox.Show("Potentional monthly earning : \n" + potentialEarning);


        }

        private void FormEarnings_Load(object sender, EventArgs e)
        {
            Contract contract = um.GetContract(u.Id);
            tbSalary.Text = contract.SalaryPerHour.ToString();
          
        }
    }
}
