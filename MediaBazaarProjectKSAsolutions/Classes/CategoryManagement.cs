using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class CategoryManagement
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        public CategoryManagement()
        {

        }

        public void AddCategory(@int category)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO category(name) values(@name)";



                    MySqlCommand cmd = new MySqlCommand(sql, conn);


                    cmd.Parameters.AddWithValue("@name", category.CategoryName);
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
        public @int GetCategory(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    @int c = new @int();
                    string query = "select * from category where id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("id", id);


                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        c.Id = dr.GetInt32("id");
                        c.CategoryName = dr.GetString("name");

                        return c;
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
        public List<@int> GetCategories()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string query = "select * from category";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<@int> categories = new List<@int>();

                    while (dr.Read())
                    {
                        @int c = new @int();
                        c.Id = dr.GetInt32("categoryid");
                        c.CategoryName = dr.GetString("name");
                        categories.Add(c);
                    }
                    return categories;

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
        public List<Stock> GetCombinedCategories()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string query ="SELECT stock.productName, stock.price, stock.serialNumber, stock.amount, category.name FROM category INNER JOIN stock on category.categoryID = stock.CategoryID";
                    //"select * from category";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Stock> data = new List<Stock>();

                    while (dr.Read())
                    {
                        Stock stock = new Stock();
                        stock.ProductName = dr.GetString("productName");
                        stock.Price = dr.GetUInt32("price");
                        stock.SerialNumber = dr.GetInt32("serialNumber");
                        stock.Amount = dr.GetInt32("amount");
                        stock.CategoryId = dr.GetInt32("name".ToString());

                        data.Add(stock);
                    }
                    return data;

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
