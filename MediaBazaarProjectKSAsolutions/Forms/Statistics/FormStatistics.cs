using System;
using MediaBazaarProjectKSAsolutions.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaarProjectKSAsolutions.Classes.Statistics;

namespace MediaBazaarProjectKSAsolutions.Forms.Statistics
{
    public partial class FormStatistics : Form
    {
        User u;
        private SalesManager salesManager = new SalesManager();
        public FormStatistics(User user)
        {
            InitializeComponent();

            this.u = user;
           

        }
        private void UpdateAmoutChart()
        {

            switch (u.Role)
            {
                case:
                    List<Sales> list = SalesManager.LoadQuantityChart();
                    charQuanity.DataSource = list
            }

        }
        private void UpdatePriceChart()
        {

        }


    }
}
