using MediaBazaarProjectKSAsolutions.Classes;
using MediaBazaarProjectKSAsolutions.Classes.Statistics;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.DAL.StatisticsDAL
{
     public class SalesConnection
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);
        public List<Sales> LoadQuantityChart()
        {
            List<Sales> listSales = new List<Sales>();

            using (conn)
            {
                conn.Open();
                string query = @"SELECT productName, amount FROM stock ORDER BY amout DESC LIMIT 5";
                MySqlCommand cmd = new MySqlCommand(query, conn);


                MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    Sales sales = new Sales((int)dr["Amout"], (string)dr["productname"]);
                    listSales.Add(sales);
                }
                return listSales;
            }
        }
        public List<Sales> LoadPriceChart()
        {
            List<Sales> listSales = new List<Sales>();

            using (conn)
            {
                conn.Open();
                string query = @"SELECT productName, price AS CostOfItem  FROM stock ORDER BY price DESC LIMIT 5";
                MySqlCommand cmd = new MySqlCommand(query, conn);


                MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                while (dr.Read())
                {
                    Sales sales = new Sales((int)dr["price"], (string)dr["productname"]);
                    listSales.Add(sales);
                }
                return listSales;

            }
        }
    }
}
