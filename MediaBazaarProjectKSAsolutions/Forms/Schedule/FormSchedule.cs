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
            shiftM = new ShiftManagement();

        }

        public void UpdateTable (DateTime dateTime) //This Automatically refreshing the Datagrid view
        {
            
            this.dvgShift.Rows.Clear();
            //shiftM.GetAllShifts();
            //Shift[] shifts = shiftM.GetShiftByDate(dateTime.Date).ToArray();

            //foreach (Shift shift in shifts)
            //{
            //    var add = shift.GetInfo();
            //    dvgShift.Rows.Add(add);

            //}
            foreach(var s in shiftM.GetAllShifts() )
            {
                dvgShift.Rows.Add(s.GetInfo());
            }

        }
        public void displayShifts (DateTime dateTime) //This is suppose to show the already made shifts when the system is loaded
        {
            this.dvgShift.Rows.Clear();
            Shift[] shifts = shiftM.GetAllShifts().ToArray();

            foreach (Shift shift in shifts)
            {
                if (this.u.Role == Classes.Role.GENERALMANAGER) //General Manager can create shift
                {
                    var add = shift.GetInfo();
                    dvgShift.Rows.Add(add);
                }
                else if (this.u.Role == Classes.Role.HRMANAGER) //HR Manager can create shift
                {
                    var add = shift.GetInfo();
                    dvgShift.Rows.Add(add);
                }
            }
        }
        public void ShowDate (DateTime now) //This is for moving the tables
        {
            //DateTime yesterday = now.AddDays(-1);
            //this.dayLeft.Text = now.ToString("dd");
            //this.mothLeft.Text = now.ToString("MMM");
            //this.yearLeft.Text = now.ToString("yyyy");

            this.middleDay.Text = now.ToString("dd");
            this.middleMonth.Text = now.ToString("MMM");
            this.middleYear.Text = now.ToString("yyyy");

            //DateTime tommorrow = now.AddDays(+1);
            //this.rightDay.Text = now.ToString("dd");
            //this.RightMonth.Text = now.ToString("MMM");
            //this.RightYear.Text = now.ToString("yyyy");
        }
     
        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule up = new AddSchedule(this);
            up.Show();
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEditSchedule_Click(object sender, EventArgs e) //Yet to be done.
        {
            int idx = dvgShift.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dvgShift.Rows[idx].Cells[0].Value);

            Shift shift = shiftM.GetShiftById(id);
            UpdateShift up = new UpdateShift(shift,this);
            up.Show();
            //displayShifts(now);


        }

       

        private void FormSchedule_Load(object sender, EventArgs e) //Initializing the Methods wheneber the FormSchedule is loaded
        {
            userM = new UserManagement();
            shiftD = new ShiftDAL();
            shiftM = new ShiftManagement();
            
            ShowDate(now);

            displayShifts(now);

        }
        

        private void Left_Click(object sender, EventArgs e)
        {
            addDays--;
            ShowDate(DateTime.UtcNow.Date.AddDays(addDays));
            displayShifts (DateTime.UtcNow.Date.AddDays(addDays));
        }

        private void Right_Click(object sender, EventArgs e)
        {
            addDays++;
            ShowDate(DateTime.UtcNow.Date.AddDays(addDays));
            displayShifts(DateTime.UtcNow.Date.AddDays(addDays));
        }


        private void jumpTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = jumpTo.Value;

            //DateTime yesterday = now.AddDays(-1);
            //this.dayLeft.Text = now.ToString("dd");
            //this.mothLeft.Text = now.ToString("MMM");
            //this.yearLeft.Text = now.ToString("yyyy");

            this.middleDay.Text = now.ToString("dd");
            this.middleMonth.Text = now.ToString("MMM");
            this.middleYear.Text = now.ToString("yyyy");

            //DateTime tommorrow = now.AddDays(+1);
            //this.rightDay.Text = now.ToString("dd");
            //this.RightMonth.Text = now.ToString("MMM");
            //this.RightYear.Text = now.ToString("yyyy");
            displayShifts(now);
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
            
            int idx = dvgShift.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dvgShift.Rows[idx].Cells[0].Value);

            var confirmResult = MessageBox.Show("Are you sure you want to delete this shift? ");
            if(confirmResult == DialogResult.Yes)
            {
                shiftM.DeleteShift(id);
                DateTime now = DateTime.UtcNow.Date;
                ShowDate(now);
                
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}
