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
    public partial class AddSchedule : Form
    {

        ShiftDAL shm;
        private UserManagement user_controller; //Getting the Employee Id from the UserDAL
        private ShiftManagement shift_controllers;
        private FormSchedule schedForm;
        //User u;


        public AddSchedule(FormSchedule schedule)
        {
            InitializeComponent();
            this.schedForm=  schedule;
            shm = new ShiftDAL();

            
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {

            try
            {

                DateTime now = DateTime.UtcNow.Date;
                int idx = dvgEmployees.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dvgEmployees.Rows[idx].Cells[0].Value);
                User u = user_controller.GetUser(id);

                Enum.TryParse(cbxSchedule_Type.Text, out Shift_Type type);

                Shift shift = new Shift(u.Id, 0 ,dtpSchedule.Value, type);
                shift =  shift_controllers.AddSchedule(shift);
                schedForm.displayShifts(now);
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Input value is not correct" + ex);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CreateSchedule_Load(object sender, EventArgs e)
        {
            user_controller = new UserManagement();
            shift_controllers = new ShiftManagement();
            cbxSchedule_Type.DataSource = Enum.GetValues(typeof(Shift_Type));

            //UpdateTable();

        }
        public void UpdateTable()
        {
            this.dvgEmployees.Rows.Clear();
            User[] users = user_controller.GetUsers().ToArray();

            foreach (User user in user_controller.GetUsers())
            {
                var add = user.ToString();
                dvgEmployees.Rows.Add(user.Id, user.UserName, user.Role);
                //user.Id = Convert.ToInt32(tbxUser_Id.Text());
            }
        }

    }
}
