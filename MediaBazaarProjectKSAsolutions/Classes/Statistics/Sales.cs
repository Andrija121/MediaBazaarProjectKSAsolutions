using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes.Statistics
{
     public class Sales
    {
        public double Price { get; set; }
        public int Amount { get; set; }
        public string Name_Product { get; }

        public Sales (double profit, string name_product)
        {
            Price = profit;
            Name_Product = name_product;
        }

        public Sales (int amount_left, string name_product)
        {
            Amount = amount_left;
            Name_Product = name_product;
        }
    }
}
