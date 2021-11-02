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
        public FormSchedule()
        {
            InitializeComponent();
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            lbSchedule.Items.Clear();
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
            Shift shift = (Shift)lbSchedule.SelectedItem;
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
    }
}
