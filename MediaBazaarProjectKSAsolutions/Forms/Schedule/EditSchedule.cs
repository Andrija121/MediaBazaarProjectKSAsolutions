using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaarProjectKSAsolutions.Classes;
namespace MediaBazaarProjectKSAsolutions.Forms.Schedule
{
    public partial class EditSchedule : Form
    {
        Shift sh;
        ShiftManagments shm;
        public EditSchedule( Shift shift)
        {
            InitializeComponent();
            this.sh = shift;
            shm = new ShiftManagments();
            cbxSchedule_Type.DataSource = Enum.GetValues(typeof(Shift_Type));
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                sh.User_Id = Convert.ToInt32(tbxUser_Id.Text);
                sh.Shift_Date = DTPSchedule.Value;
                sh.Shift_Type = (Shift_Type)cbxSchedule_Type.SelectedItem;

                if(sh.Shift_Date == null)
                {
                    MessageBox.Show("Please give Shift a date");
                }
                else
                {
                    shm.UpdateShifts(sh);
                    MessageBox.Show("You Successfully Edited the shift");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void EditSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                tbxUser_Id.Text = sh.User_Id.ToString();
                DTPSchedule.Value = sh.Shift_Date;
                cbxSchedule_Type.SelectedItem = sh.Shift_Type;

            }
            catch(Exception)
            {
                MessageBox.Show("Shift has been succfully Loaded");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
