using MediaBazaarProjectKSAsolutions.Classes;
using MediaBazaarProjectKSAsolutions.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class FormSchedule : Form
    {
        ShiftManagments shm = new ShiftManagments();
        private int addDay = 0;
        
        public FormSchedule()
        {
            InitializeComponent();
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            //lbSchedule.Items.Clear();
            foreach(var shift in shm.GetAllShifts())
            {
                lbSchedule.Items.Add(shift);
            }
        }
        private void btnRefreshSchedule_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            CreateSchedule createSchedule = new CreateSchedule();
            createSchedule.ShowDialog();
            RefreshListBox();
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            //Shift shift = (Shift)lbSchedule.SelectedItem;
            if (shift != null)
            {
                EditSchedule editSchedule = new EditSchedule(shift);
                editSchedule.ShowDialog();
                RefreshListBox();


            }
            else
                MessageBox.Show("Please slecet the shift you want to edit");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDate(DateTime now)
        {
            this.dateCenter.Text = now.ToString("dd");
            this.monthCenter.Text = now.ToString("MMM").ToUpper();
            this.yearCenter.Text = now.ToString("yyyy").ToUpper();

            DateTime yesterday = now.AddDays(-1);
            this.dateLeft.Text = yesterday.ToString("dd");
            this.monthLeft.Text = yesterday.ToString("MMMM").ToUpper();
            this.yearLeft.Text = yesterday.ToString("yyyy").ToUpper();

            DateTime tommorrow = now.AddDays(+1);
            this.dateRight.Text = tommorrow.ToString("dd");
            this.monthRight.Text = tommorrow.ToString("MMM").ToUpper();
            this.yearRight.Text = tommorrow.ToString("yyyy").ToUpper();
        }

        public void displayShift(DateTime dateTime)
        {
            Shift[] shifts = ShiftManagments.GetShiftByDate(dateTime.Date).ToArray();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            addDay--;
            showDate(DateTime.UtcNow.Date.AddDays(addDay));
            displayShift(DateTime.UtcNow.Date.AddDays(addDay));
        }
    }
}
