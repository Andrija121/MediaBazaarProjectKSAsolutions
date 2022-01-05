
using MediaBazaarProjectKSAsolutions.DAL.StatisticsDAL;
using System;
using System.Collections.Generic;
using System.Text;


namespace MediaBazaarProjectKSAsolutions.Classes.Statistics
{
    public class SalesManager
    {
        SalesConnection salesConnection = new SalesConnection();

        public List<Sales> LoadQuantityChart()
        {
            return salesConnection.LoadQuantityChart();
        }
        public List<Sales> LoadCostChart()
        {
            return salesConnection.LoadPriceChart();
        }
       
    }
}
