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
        public int Amount { get; set; }
        // properties

        public Stock()
        {

        }
        public Stock(int id,string productName,double price,int serialNumber, int amount)
        {
            this.Id = id;
            this.ProductName = productName;
            this.Price = price;
            this.SerialNumber = serialNumber;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
