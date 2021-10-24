using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {

        }
        public Category(int id, string categoryName)
        {
            this.Id = id;
            this.CategoryName = categoryName;
        }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
