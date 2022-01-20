using MediaBazaarProjectKSAsolutions.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
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
            Chart1Implementation();
            Chart2Implementation();
        }
        public void Chart1Implementation()
        {
            int numberOfMales = 0;
            int numberOfFemales = 0;
            int numberOfOthers = 0;
            int totalUsers = 0;
            List<User> users= userManagement.GetUsers();



            radChartView1.Series.Clear();


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


            BarSeries series = new BarSeries();
            series.DataPoints.Add(new CategoricalDataPoint(numberOfMales, "Males"));
            series.DataPoints.Add(new CategoricalDataPoint(numberOfFemales, "Females"));
            series.DataPoints.Add(new CategoricalDataPoint(numberOfOthers, "Others"));
            this.radChartView1.Series.Add(series);


            CategoricalAxis categoricalAxis = radChartView1.Axes[0] as CategoricalAxis;
            categoricalAxis.PlotMode = AxisPlotMode.OnTicksPadded;
            categoricalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
            categoricalAxis.LabelRotationAngle = 310;
            LinearAxis verticalAxis = radChartView1.Axes[1] as LinearAxis;
            verticalAxis.ForeColor = Color.Blue;
            verticalAxis.BorderColor = Color.Purple;
            verticalAxis.MajorStep = 5;
            verticalAxis.Maximum = totalUsers;
            verticalAxis.Minimum = 0;
            verticalAxis.LabelInterval = 2;

        }
        public void Chart2Implementation() //Age
        {
            radChartView2.Series.Clear();

            int yAdults = 0; // 18-29
            int adults = 0; // 30 - 39
            int mAdults = 0; // 40 - 49
            int oAdults = 0; // 50+

            // 18-29
            DateTime datetimeyAdults = new DateTime(2004, 12, 31, 23, 59, 59);
            DateTime datimeyAdults2 = new DateTime(1993, 12, 31, 23, 59, 59);
            // 30 - 39
            DateTime adultsdt = new DateTime(1992, 12, 31, 23, 59, 59);
            DateTime adultsdt2 = new DateTime(1983, 12, 31, 23, 59, 59);
            // 40 - 49
            DateTime mAdultsdt = new DateTime(1982, 12, 31, 23, 59, 59);
            DateTime mAdultsdt2 = new DateTime(1973, 12, 31, 23, 59, 59);
            // 50 +
            DateTime oAdultsdt = new DateTime(1972, 12, 31, 23, 59, 59);
            List<User> users = userManagement.GetUsers();
            foreach (var u in users)
            {

                if (u.Birtyhday >= datetimeyAdults || u.Birtyhday < datimeyAdults2)
                {
                    yAdults++;
                }
                //else if (u.Birtyhday >= adultsdt || u.Birtyhday < adultsdt2)
                //{
                //    adults++;
                //}
                //else if (u.Birtyhday >= mAdultsdt || u.Birtyhday < mAdultsdt2)
                //{
                //    mAdults++;
                //}
                else if (u.Birtyhday >= oAdultsdt)
                {
                    oAdults++;
                }
            }
            this.radChartView2.AreaType = ChartAreaType.Pie;
            PieSeries series = new PieSeries();
            series.DataPoints.Add(new PieDataPoint(yAdults, " 18 - 50 "));
            //series.DataPoints.Add(new PieDataPoint(adults, " 30 - 39 "));
            //series.DataPoints.Add(new PieDataPoint(mAdults, " 40 - 49 "));
            series.DataPoints.Add(new PieDataPoint(oAdults, " 50+ "));
            series.ShowLabels = true;
            this.radChartView2.Series.Add(series);
            this.radChartView2.ShowLegend = true;
            this.radChartView2.LegendTitle = "Age groups";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumberOfEmployees_Click(object sender, EventArgs e)
        {
            radChartView2.Hide();
            Chart1Implementation();
            radChartView1.Show();
            radChartView1.BringToFront();
        }
        
        private void btnAgeOfEmployees_Click(object sender, EventArgs e)
        {
            radChartView1.Hide();
            Chart2Implementation();
            radChartView2.Show();
            radChartView2.BringToFront();
        }
    }
}
