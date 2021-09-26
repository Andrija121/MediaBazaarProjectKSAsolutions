using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class Stock
    { 
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int SerialNumber { get; set; }
        // properties

        public Stock(int id,string productName,double price,int serialNumber)
        {
            this.Id = id;
            this.ProductName = productName;
            this.Price= price;
            this.SerialNumber= serialNumber;
        }
    }
}
