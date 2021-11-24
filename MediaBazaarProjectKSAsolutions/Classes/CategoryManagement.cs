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

        public void AddCategory(Category category)
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
        public Category GetCategory(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    Category c = new Category();
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
        public List<Category> GetCategories()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string query = "select * from category";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Category> categories = new List<Category>();

                    while (dr.Read())
                    {
                        Category c = new Category();
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
        public List<Category> GetCombinedCategories()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string query = "SELECT stock.productName, stock.price, stock.serialNumber, stock.amount, category.name FROM category INNER JOIN stock on category.categoryID = stock.CategoryID";
                    //"select * from category";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Category> categories = new List<Category>();

                    while (dr.Read())
                    {
                        Category c = new Category();
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
    }
}
