using MediaBazaarProjectKSAsolutions.Classes;
using MediaBazaarProjectKSAsolutions.Classes.Shift;
using MediaBazaarProjectKSAsolutions.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaarProjectKSAsolutions.Forms
{
    public partial class FormSchedule : Form
    {
        User u;
        private ShiftManagement shiftM;
        private UserManagement userM;
        ShiftDAL shiftD; 


        private List<User> users = new List<User>(); //Getting a List of Users
        private List<Shift_Type> shiftTypes = new List<Shift_Type>(); //Calling the Object of the shift type

        private int addDays = 0;
        private DateTime now = DateTime.UtcNow.Date;

        public FormSchedule(User user)

        {
            InitializeComponent();
            this.u = user;

        }

        public void RefreshDVG() //This Automatically refreshing the Datagrid view
        {
            this.dvgShift.Rows.Clear();
            
            foreach (var s in shiftM.GetAllShifts())
            {
                if(this.u.Role == Classes.Role.GENERALMANAGER)
                {
                    
                    dvgShift.Rows.Add(s.Shift_Id, s.User_Id,s.Shift_Type, s.Shift_Date);
                }
            }
        }
        public void ShowShifts (DateTime dateTime) //This is suppose to show the already made shifts when the system is loaded
        {
            this.dvgShift.Rows.Clear();
             shiftM.GetAllShifts();
            //Shift[] shift = shiftM.GetShiftByDate( dateTime.Date).ToArray();

            foreach (var s in shiftM.GetAllShifts())
            {
                if(this.u.Role == Classes.Role.GENERALMANAGER)
                {
                    var add = ToString();
                    dvgShift.Rows.Add(s.Shift_Id, s.User_Id, s.Shift_Type, s.Shift_Date);
                }
            }
        }
        public void ShowDate (DateTime now) //This is for moving the tables
        {
            DateTime yesterday = now.AddDays(-1);
            this.dayLeft.Text = now.ToString("dd");
            this.mothLeft.Text = now.ToString("MMM");
            this.yearLeft.Text = now.ToString("yyyy");

            this.middleDay.Text = now.ToString("dd");
            this.middleMonth.Text = now.ToString("MMM");
            this.middleYear.Text = now.ToString("yyyy");

            DateTime tommorrow = now.AddDays(+1);
            this.rightDay.Text = now.ToString("dd");
            this.RightMonth.Text = now.ToString("MMM");
            this.RightYear.Text = now.ToString("yyyy");
        }
     
        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            CreateSchedule createSchedule = new CreateSchedule(u);
            createSchedule.ShowDialog();
            RefreshDVG();
            
        }
        public void Accesscibility() //This checks for the accessibilty role of the user. If you're general manager then you should be able 
            //to create shits.
        {
            if(this.u.Role == Classes.Role.GENERALMANAGER)
            {
                users = WorkerList();
                
            }
        }

        private void btnEditSchedule_Click(object sender, EventArgs e) //Yet to be done.
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
        public List<User> WorkerList() //This holds a list of user
        {
            List<User> employeeList = new List<User>();
            foreach(User u in  this.users)
            {
                if (u.Role == Classes.Role.STOREEMPLOYEE && u.Role == Classes.Role.STOREEMPLOYEE ) //Allow the General Manager to only create shifts for store employee and warhouse
                    employeeList.Add(u);

            }
            return employeeList;
        }

        private void FormSchedule_Load(object sender, EventArgs e) //Initializing the Methods wheneber the FormSchedule is loaded
        {
            userM = new UserManagement();
            shiftD = new ShiftDAL();
            shiftM = new ShiftManagement();
            WorkerList();
            ShowDate(now);
            ShowShifts(now);

        }

        private void Left_Click(object sender, EventArgs e)
        {
            addDays--;
            ShowDate(DateTime.UtcNow.Date.AddDays(addDays));
            ShowShifts(DateTime.UtcNow.Date.AddDays(addDays));
        }

        private void Right_Click(object sender, EventArgs e)
        {
            addDays++;
            ShowDate(DateTime.UtcNow.Date.AddDays(addDays));
            ShowShifts(DateTime.UtcNow.Date.AddDays(addDays));
        }


        private void jumpTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = jumpTo.Value;

            DateTime yesterday = now.AddDays(-1);
            this.dayLeft.Text = now.ToString("dd");
            this.mothLeft.Text = now.ToString("MMM");
            this.yearLeft.Text = now.ToString("yyyy");

            this.middleDay.Text = now.ToString("dd");
            this.middleMonth.Text = now.ToString("MMM");
            this.middleYear.Text = now.ToString("yyyy");

            DateTime tommorrow = now.AddDays(+1);
            this.rightDay.Text = now.ToString("dd");
            this.RightMonth.Text = now.ToString("MMM");
            this.RightYear.Text = now.ToString("yyyy");
            ShowShifts(now);
        }


        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewColumn column = new DataGridViewColumn();
            int cIndex = Convert.ToInt32(column.Index);
            int rIndex = Convert.ToInt32(row.Index);

            DataGridViewCellEventArgs dataGridViewCellEventArgs = new DataGridViewCellEventArgs(cIndex,rIndex);
            dvgShift_CellClick(sender, dataGridViewCellEventArgs);
        }

        private void dvgShift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            if (dvgShift.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                return;
            }
            else
            DeleteSelectedShift(e);

            }
            catch (Exception)
            {

                MessageBox.Show("Ups please selct proper value");
            }
        }

        private void DeleteSelectedShift(DataGridViewCellEventArgs e)
        {
            dvgShift.CurrentCell.Selected = true;

            string id = dvgShift.Rows[e.RowIndex].Cells["User_ID"].FormattedValue.ToString();
            var st = (from s in shiftM.GetAllShifts()
                      where s.Shift_Id == int.Parse(id)
                      select s).First();
            shiftM.DeleteShift(st);
            RefreshDVG();
            MessageBox.Show("It works");
            //int id = Convert.ToInt32(tbxShiftId.Text);
            //int uid = dvgEmployees.CurrentCell.RowIndex;
            //int id = Convert.ToInt32(dvgEmployees.Rows[uid].Cells[0].Value);
        }
    }
}
