using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class UserManagement
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);



        List<User> users;
        

        public UserManagement()
        {

        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public User GetUser(int id)
        {
            return users[1];
        }
        public User EditUser(User u)
        {
            return u;
        }
        public List<User> GetUsers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "select * from user";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<User> users = new List<User>();

                    while(dr.Read())
                    {
                        User user = new User();
                        user.Id =Convert.ToInt32(dr[0]);
                        user.UserName = dr[1].ToString();
                        user.FirstName = dr[2].ToString();
                        user.LastName = dr[3].ToString();
                        user.Email = dr[4].ToString();
                        user.Password = dr[5].ToString();
                        user.Birtyhday = Convert.ToDateTime(dr[6]);
                        user.BSN = Convert.ToInt32(dr[7]);
                        user.ZipCode = dr[8].ToString();
                        user.Address = dr[9].ToString();
                        user.Gender = (Gender)dr[10];
                        user.Role = (Role)dr[11];
                        users.Add(user);  
                    }
                    return users;
                    
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
        public void RemoveUserAtIndex(int uIndex)
        {
            users.RemoveAt(uIndex);
        }
    }
}
