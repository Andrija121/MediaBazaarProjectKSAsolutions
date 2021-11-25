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

        ShiftDAL shm;
        private UserManagement user_controller; //Getting the Employee Id from the UserDAL
        private ShiftManagement shift_controllers;
        private FormSchedule schedForm;
        User u;


        public CreateSchedule(User user)
        {
            InitializeComponent();
            this.u = user;
            shm = new ShiftDAL();

            cbxSchedule_Type.DataSource = Enum.GetValues(typeof(Shift_Type));
            user_controller = new UserManagement();
            shift_controllers = new ShiftManagement();
            cbxSchedule_Type.DataSource = Enum.GetValues(typeof(Shift_Type));
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {

            
            try
            {
                DateTime now = DateTime.UtcNow.Date;

                u.Id = Convert.ToInt32(tbxUser_Id.Text);

                Shift_Type shift_Type = (Shift_Type)cbxSchedule_Type.SelectedItem;
                DateTime date = dtpSchedule.Value;
               
               
                
                Shift shift = new Shift(u.Id,0,date, shift_Type);
                shift =  shift_controllers.AddSchedule(shift);
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

        public void UpdateTable()
        {
            this.dvgEmployees.Rows.Clear();
            

            foreach(User user in user_controller.GetUsers())
            {
                var add = user.ToString();
                dvgEmployees.Rows.Add(user.Id, user.UserName, user.Role);
                //user.Id = Convert.ToInt32(tbxUser_Id.Text());
            }
        }
        private void CreateSchedule_Load(object sender, EventArgs e)
        {
            user_controller = new UserManagement();
            shift_controllers = new ShiftManagement();

            //Shift[] shifts = shift_controllers.
            UpdateTable();
 
        }

        private void dvgEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                dvgEmployees.CurrentCell.Selected = true;

                tbxUser_Id.Text = dvgEmployees.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                //int id = Convert.ToInt32(tbxShiftId.Text);
            //    int uid = dvgEmployees.CurrentCell.RowIndex;
            //    int id = Convert.ToInt32(dvgEmployees.Rows[uid].Cells[0].Value);
            }
         
        }
    }
}
