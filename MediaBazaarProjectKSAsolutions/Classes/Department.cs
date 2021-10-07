using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        //public int ManagerID { get; set; }

        public Department()
        {

        }
        public Department(int id,string name)
        {
            this.Id = id;
            this.Name = name;
            //this.ManagerID = managerId;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
