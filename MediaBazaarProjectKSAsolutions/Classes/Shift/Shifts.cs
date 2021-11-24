using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    public class Shift 
    {
       
        private UserManagement uerCon = new UserManagement();
        private DepartmentManagement depCon = new DepartmentManagement();

        public Department department = new Department(); //Give a Department and employee
        public int Shift_Id { get; set; }
       
        public int User_Id { get; set; }
        public DateTime Shift_Date { get; set; }

        public Shift_Type Shift_Type { get; set; }

        public Shift( int shift_Id, int user_Id, DateTime shift_date, Shift_Type shift_type)
        {
            this.Shift_Id = shift_Id;
            this.User_Id = user_Id;
            this.Shift_Date = shift_date;
            this.Shift_Type = shift_type;
        }

        public Shift()
        {

        }
        public override string ToString()
        {
            return User_Id + " " + Shift_Date+ " " + Shift_Type + " " ;
        }
    }
}
