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
                    string sql = "INSERT INTO category(categoryName) values(@categoryName)";



                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@categoryName", category.CategoryName);
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
        public User GetUser(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    User u = new User();
                    string query = "select * from user where id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("id", id);


                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        u.Id = dr.GetInt32("id");
                        u.UserName = dr.GetString("userName");
                        u.FirstName = dr.GetString("firstName");
                        u.LastName = dr.GetString("lastName");
                        u.Email = dr.GetString("email");
                        u.Password = dr.GetString("password");
                        u.Birtyhday = dr.GetDateTime("birthday");
                        u.BSN = dr.GetInt32("bSN");
                        u.ZipCode = dr.GetString("zipCode");
                        u.Address = dr.GetString("address");
                        u.Gender = (Gender)dr.GetInt32("gender");
                        u.Role = (Role)dr.GetInt32("role");
                        u.Status = (Status)dr.GetInt32("status");
                        return u;

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
    }
}
