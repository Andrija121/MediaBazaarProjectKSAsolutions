using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaarProjectKSAsolutions.Classes.Shift;
using MediaBazaarProjectKSAsolutions.Classes;

namespace MediaBazaarProjectKSAsolutions.Forms.Schedule
{
    public partial class UpdateShift : Form
    {
        private User user;
        private UserManagement userManagement;
        private ShiftManagement shiftManagement;

        private Shift shift;
        private FormSchedule home;
        private int id;

        public UpdateShift(Shift shift, FormSchedule home)
        {
            shiftManagement = new ShiftManagement();
            this.shift = shift;
            this.home = home;
            
            dtpSchedule.Value = this.shift.Shift_Date;

            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            Enum.TryParse(cbxSchedule_Type.Text, out Shift_Type types);
            shift.Shift_Type = types;
            shift.Shift_Date = dtpSchedule.Value;
            shiftManagement.UpdateSHift(shift);
            home.displayShifts(shift.Shift_Date);

            this.Close();
        }

        private void UpdateShift_Load(object sender, EventArgs e)
        {
            userManagement = new UserManagement();
            shiftManagement = new ShiftManagement();
        }
    }
}
