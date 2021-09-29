using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class StockManagement
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        List<Stock> stocks = new List<Stock>();
        List<User> users = new List<User>();

        public StockManagement()
        {

        }
        public void AddStock(Stock stock)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "INSERT INTO stock(id, productName, price, serialNumber, amount)";



                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.AddWithValue("@id", stock.Id);
                    cmd.Parameters.AddWithValue("@id", stock.ProductName);
                    cmd.Parameters.AddWithValue("@id", stock.Price);
                    cmd.Parameters.AddWithValue("@id", stock.SerialNumber);
                    cmd.Parameters.AddWithValue("@id", stock.Amount);
                    conn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            //stocks.Add(stock);
        }

        public Stock GetStock(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "select * from stock";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);



                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Stock> stocks = new List<Stock>();

                    while (dr.Read())
                    {
                        Stock stock = new Stock();
                        stock.Id = Convert.ToInt32(dr["id"]);
                        stock.ProductName = dr["productName"].ToString();
                        stock.Price = Convert.ToInt32(dr["price"]);
                        stock.SerialNumber = Convert.ToInt32(dr["serialNumber"]);
                        stock.Amount = Convert.ToInt32(dr["amount"]);
                        stocks.Add(stock);
                    }
                    return null;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Stock> GetAllStock()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "select * from stock";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);



                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Stock> stocks = new List<Stock>();

                    while (dr.Read())
                    {
                        Stock stock = new Stock();
                        stock.Id = Convert.ToInt32(dr["id"]);
                        stock.ProductName = dr["productName"].ToString();
                        stock.Price = Convert.ToInt32(dr["price"]);
                        stock.SerialNumber = Convert.ToInt32(dr["serialNumber"]);
                        stock.Amount = Convert.ToInt32(dr["amount"]);
                        stocks.Add(stock);
                    }
                    return stocks;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            //foreach (var stock in stocks)
            //{
            //    if(stock.Id==id)
            //    {
            //        return stock;
            //    }
            //}
            //return null;
        }
        public Stock EditStock(int id)
        {
            GetStock(id);
            //do something
            return null;
        }
        public void RemoveStockAtIndex(int sIndex)
        {
            stocks.RemoveAt(sIndex);

        }
    }
}
