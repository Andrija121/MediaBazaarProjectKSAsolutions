using MediaBazaarProjectKSAsolutions.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class RadFormStatistics : Telerik.WinControls.UI.RadForm
    {
        UserManagement userManagement = new UserManagement();
        public RadFormStatistics()
        {
            InitializeComponent();
            Xosa();
        }
        public void Xosa()
        {
            int numberOfMales = 0;
            int numberOfFemales = 0;
            int numberOfOthers = 0;
            int totalUsers = 0;
            List<User> users= userManagement.GetUsers();

            foreach (var u in users)
            {
                totalUsers++;
                if(u.Gender==Gender.MALE)
                {
                    numberOfMales++;
                }
                else if(u.Gender==Gender.FEMALE)
                {
                    numberOfFemales++;
                }
                else
                {
                    numberOfOthers++;
                }

            }
            MessageBox.Show("There is total of " + numberOfMales + " Males, total of " + numberOfFemales + " Females and total of " + numberOfOthers + " others");
            Axis a1 = radChartView1.Axes[1];

        }

    }
}
