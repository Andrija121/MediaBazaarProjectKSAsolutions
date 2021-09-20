using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class Department
    {
        private int id;
        private string name;
        private User manager;
        

        public int Id { get; set; }
        public string Name { get; set; }
        public User Manager { get; set; }

        public Department(int id,string name,User manager)
        {
            this.id = id;
            this.name = name;
            this.manager = manager;
            
        }
    }
}
