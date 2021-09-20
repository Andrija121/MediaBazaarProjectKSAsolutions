using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Class
{
    class Department
    {
        private int id;
        private string name;
        private string manager;//instead of string, maybe type User

        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id,string name,string manager)
        {
            this.id = id;
            this.name = name;
            this.manager = manager;
        }
    }
}
