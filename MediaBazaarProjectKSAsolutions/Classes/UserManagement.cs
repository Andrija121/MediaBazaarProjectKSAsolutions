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


        public UserManagement()
        {

        }

        public void AddUser(User user)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "INSERT INTO user(id,userName,firstName,lastName,email,password,birthday,bsn,zipcode,address,gender,role,status) values(@id,@userName,@firstName,@lastName,@email,@password,@birthday,@bsn,@zipcode,@address,@gender,@role,@status)";



                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.Parameters.AddWithValue("@userName", user.UserName);
                    cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", user.LastName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@birthday", user.Birtyhday);
                    cmd.Parameters.AddWithValue("@bsn", user.BSN);
                    cmd.Parameters.AddWithValue("@zipCode", user.ZipCode);
                    cmd.Parameters.AddWithValue("@address", user.Address);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@status", user.Status);
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
        public User GetUser(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "select distinct(user.id)  from user";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        User user = new User();
                        user.Id = id;
                        
                    }
                    return null;// is not finished
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





        public User EditUser(User u)
            {

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                    {
                        string sql = "Update user set (id='" + u.Id + "',username='" + u.UserName + "',firstName='" + u.FirstName + "',lastName='" + u.LastName + "',email='" + u.Email + "',password='" + u.Password + "',birthday='" + u.Birtyhday + "',bsn='" + u.BSN + "',zipcode='" + u.ZipCode + "',address='" + u.Address + "',gender='" + u.Gender + "',role='" + u.Role + "',status='" + u.Status + "') ";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                return u;
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

                        while (dr.Read())
                        {
                            User user = new User();
                            user.Id = Convert.ToInt32(dr[0]);
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
                            user.Status = (Status)dr[12];
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
            public void DeleteUser(int id)
            {

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                    {
                        string sql = "DELETE FROM user where id=@id";
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
