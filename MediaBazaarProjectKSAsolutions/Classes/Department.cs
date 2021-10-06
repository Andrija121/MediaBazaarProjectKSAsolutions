using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public User Manager { get; set; }

        public Department(int id,string name,User manager)
        {
            this.Id = id;
            this.Name = name;
            this.Manager = manager;
        }
        public override string ToString()
        {
            return Name + " - " + Manager;
        }
    }
}
