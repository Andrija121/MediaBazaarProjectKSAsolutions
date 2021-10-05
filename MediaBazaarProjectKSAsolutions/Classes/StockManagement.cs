using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Class
{
    class StockManagement
    {
        List<Stock> stocks = new List<Stock>();
        List<User> users = new List<User>();

        public StockManagement()
        {

        }
        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }
        public Stock GetStock(int id)
        {
            foreach (var stock in stocks)
            {
                if(stock.Id==id)
                {
                    return stock;
                }
            }
            return null;
        }
        public void RemoveStockAtIndex(int sIndex)
        {
            stocks.RemoveAt(sIndex);
            
        }
    }
}
