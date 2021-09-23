using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class Stock
    {
        private int id;
        private string productName;
        private double price;
        private int serialNumber;

        public int Id { get; set; }
        // properties

        public Stock(int id,string productName,double price,int serialNumber)
        {
            this.id = id;
            this.productName = productName;
            this.price = price;
            this.serialNumber = serialNumber;
        }
    }
}
