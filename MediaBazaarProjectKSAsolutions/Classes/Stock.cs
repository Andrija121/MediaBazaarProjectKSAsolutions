using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
   public class Stock
    { 
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int SerialNumber { get; set; }
        public int Amount { get; set; }
        public Category Category { get; set; }

        public Stock()
        {

        }
        public Stock(int id,string productName,double price,int serialNumber, int amount,Category category)
        {
            this.Category = category;
            this.Id = id;
            this.ProductName = productName;
            this.Price = price;
            this.SerialNumber = serialNumber;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return ProductName + " - " + Price + " - " + SerialNumber + " - " + Amount;
        }

    }
}
