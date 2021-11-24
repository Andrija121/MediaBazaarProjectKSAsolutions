using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public User Department_Manager { get; set; } 
        public Status Status { get; set; }
        public List<User> UserInDepartment { get; set; }


        public Department()
        {

        }
        public Department(int id,string name,User depo_manager,Status status)
        {
            this.Id = id;
            this.Name = name;
            this.Department_Manager = depo_manager;
            this.Status = status;
            
        }
        public override string ToString()
        {
            return Name + " - " + Status;
        }
    }
}
