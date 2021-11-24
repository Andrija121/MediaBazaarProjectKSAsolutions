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

       
       

        public StockManagement()
        {

        }
        public void AddStock(Stock stock)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "INSERT INTO stock(productName,price,serialNumber,amount,categoryId) values(@productName,@price,@serialNumber,@amount,@categoryId)";



                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    //cmd.Parameters.AddWithValue("@id", stock.Id);
                    cmd.Parameters.AddWithValue("@productName", stock.ProductName);
                    cmd.Parameters.AddWithValue("@price", stock.Price.ToString());
                    cmd.Parameters.AddWithValue("@serialNumber", stock.SerialNumber);
                    cmd.Parameters.AddWithValue("@amount", stock.Amount);
                    cmd.Parameters.AddWithValue("@categoryId", stock.Category.Id);

                    cmd.ExecuteNonQuery();
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

        public Stock GetStock(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    Stock stock = new Stock();
                    string sql = "select * from stock where id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("id", id);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        stock.Id = Convert.ToInt32(dr["id"]);
                        stock.ProductName = dr["productName"].ToString();
                        stock.Price = Convert.ToInt32(dr["price"]);
                        stock.SerialNumber = Convert.ToInt32(dr["serialNumber"]);
                        stock.Amount = Convert.ToInt32(dr["amount"]);
                        return stock;
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

        }
        public Stock EditStock(Stock stock)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "Update stock set productName=@productName, price=@price,serialNumber=@serialNumber,amount=@amount where id =@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", stock.Id);
                    cmd.Parameters.AddWithValue("@productName", stock.ProductName);
                    cmd.Parameters.AddWithValue("@price", stock.Price);
                    cmd.Parameters.AddWithValue("@serialNumber", stock.SerialNumber);
                    cmd.Parameters.AddWithValue("@amount", stock.Amount);

                    cmd.ExecuteNonQuery();

                }
                return stock;
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
        public void DeleteStock(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "DELETE FROM stock where id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
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
        }
    }
}
