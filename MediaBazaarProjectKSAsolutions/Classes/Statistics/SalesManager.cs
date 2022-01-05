
using MediaBazaarProjectKSAsolutions.DAL.StatisticsDAL;
using MediaBazaarProjectKSAsolutions.Classes.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
