using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    public class Shift
    {
        UserManagement usercon = new UserManagement(); //To use fro shifts 

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
        public virtual string[] GetInfo()
        {
            string[] s = { this.User_Id.ToString(), this.Shift_Date.ToString("dd/MM/yyyy"), this.Shift_Type.ToString() };
            return s;
        }
    }
}
