using MediaBazaarWebKSAsolutions.Logic.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebKSAsolutions.Logic.Data
{
    public class UserBase
    {
        public User Login(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.connectionString))
                try
                {
                    string sql = "SELECT * FROM `user` WHERE username = @username AND password = @password ;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    User client;

                    while (dr.Read())
                    {
                        client = new User(
                            Convert.ToInt32(dr["id"]),
                            Convert.ToString(dr["username"]),
                            Convert.ToString(dr["email"]),
                            Convert.ToString(dr["password"])
                            );
                        return client;
                    }
                }
                finally
                {
                    conn.Close();
                }
            return null;
        }

        //public void CreateUser(User client)
        //{
        //    using (MySqlConnection conn = new MySqlConnection(Database.connectionString))
        //        try
        //        {
        //            string sql = "INSERT INTO user(username, email, password) values(@Username, @Email, @Password)";
        //            MySqlCommand cmd = new MySqlCommand(sql, conn);

        //            conn.Open();
        //            cmd.Parameters.AddWithValue("@username", client.Username);
        //            cmd.Parameters.AddWithValue("@email", client.Email);
        //            cmd.Parameters.AddWithValue("@password", client.Password);

        //            cmd.ExecuteNonQuery();
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //}

        public User GetUser(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.connectionString))
                try
                {
                    conn.Open();
                    User c = new User();
                    string sql = "SELECT * from user WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("username", username);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        c.Id = dr.GetInt32("id");
                        c.UserName = dr.GetString("username");
                        c.Email = dr.GetString("email");
                        c.Password = dr.GetString("password");
                        return c;
                    }
                    return null;
                }
                finally
                {
                    conn.Close();
                }
        }

        public User UpdateUser(string username, string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(Database.connectionString))
            {
                try
                {
                    User c = new User();
                    conn.Open();
                    string sql = "Update user set email=@email,password=@password where username = @username";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("username", username);

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);


                    cmd.ExecuteNonQuery();

                    return c;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
