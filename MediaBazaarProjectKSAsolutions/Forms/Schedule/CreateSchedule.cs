using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaarProjectKSAsolutions.Classes;
using MediaBazaarProjectKSAsolutions.Classes.Shift;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class CreateSchedule : Form
    {
        ShiftManagments shm;

        public CreateSchedule()
        {
            InitializeComponent();
            shm = new ShiftManagments();
            cbxSchedule_Type.DataSource = Enum.GetValues(typeof(Shift_Type));
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                int User_Id = Convert.ToInt32( tbxUser_Id.Text);
                DateTime Shift_Date = DTPSchedule.Value;
                Shift_Type shift_Type = (Shift_Type)cbxSchedule_Type.SelectedItem;
                Shift shift = new Shift(0, User_Id, Shift_Date, shift_Type);
                if (shift.Shift_Date.ToString()==String.Empty)
                {
                    MessageBox.Show("Please give Shift a date");
                }
                else
                {
                    shm.AddShift(shift);
                    MessageBox.Show("User Shift has been created Successfully");
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Input value is not correct");
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
