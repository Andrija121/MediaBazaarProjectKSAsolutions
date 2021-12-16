using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes.Shift
{
    public class Shift
    {

        //Will use later
        private DepartmentManagement depCon = new DepartmentManagement();
        private Department department = new Department(); //Object of department to show which shift department is working on what day.
        public Department Department { get { return this.department; } set { this.department = value; } }
        //Will use later

        private UserManagement userCon = new UserManagement();
      
        public int Shift_Id { get; set; }

        public int User_Id { get; set; }

        public DateTime Shift_Date { get; set; }

        public Shift_Type Shift_Type { get; set; }

        public Shift( int user_Id,int shift_id, DateTime shift_date, Shift_Type shift_type)
        {
            this.Shift_Id = shift_id ;
            this.User_Id = user_Id; //User-ID
            this.Shift_Date = shift_date;
            this.Shift_Type = shift_type;
            //this.department = department; //I initialised the enumratuions
        }

        public  Shift() //Shift Object
        {

        }
        public override  string ToString()
        {
            return this.Shift_Id + " - " + userCon.GetUser(this.User_Id).FirstName + " - " + userCon.GetUser(this.User_Id).LastName + "-" + Shift_Date + " " + Shift_Type; /*+ " " + depCon.GetActiveDepartments(this.Department.Id)*/
        }
    }
}
