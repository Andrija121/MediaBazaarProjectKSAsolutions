using MediaBazaarProjectKSAsolutions.Classes;
using MediaBazaarProjectKSAsolutions.Classes.Shift;
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
        }

        public void RefreshDVG()
        {
            DVG_Shift.Rows.Clear();
            foreach(var shift in shm.GetAllShifts())
            {
                DVG_Shift.Rows.Add(shift.Shift_Id, shift.Shift_Date, shift.Shift_Type);

            }
        }
        private void btnRefreshSchedule_Click(object sender, EventArgs e)
        {
            RefreshDVG();
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            CreateSchedule createSchedule = new CreateSchedule();
            createSchedule.ShowDialog();
            RefreshDVG();
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {

            //Shift shift = (shift)DVG_Shift.SelectedCells.
            //if (shift != null)
            //{
            //    EditSchedule editSchedule = new EditSchedule(shift);
            //    editSchedule.ShowDialog();
            //    RefreshDVG();


            //}
            //else
            //    MessageBox.Show("Please slecet the shift you want to edit");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
