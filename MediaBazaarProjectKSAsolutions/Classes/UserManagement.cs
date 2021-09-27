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
                        u.Password= dr.GetString("password");
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





        public User EditUser(User u)
            {

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                    {
                    conn.Open();
                    string sql = "Update user set username=@userName, firstName=@firstName,lastName=@lastName,email=@email,password=@password,birthday=@birthday,bsn=@bsn,zipcode=@zipCode,address=@address,gender=@gender,role=@role,status=@status where id =@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@userName",u.UserName);
                    cmd.Parameters.AddWithValue("@firstName", u.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", u.LastName);
                    cmd.Parameters.AddWithValue("@email", u.Email);
                    cmd.Parameters.AddWithValue("@password", u.Password);
                    cmd.Parameters.AddWithValue("birthday", u.Birtyhday);
                    cmd.Parameters.AddWithValue("bsn", u.BSN);
                    cmd.Parameters.AddWithValue("zipcode", u.ZipCode);
                    cmd.Parameters.AddWithValue("@address", u.Address);
                    cmd.Parameters.AddWithValue("@gender", u.Gender);
                    cmd.Parameters.AddWithValue("@role", u.Role);
                    cmd.Parameters.AddWithValue("@status", u.Status);

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
                    conn.Open();
                    string sql = "select * from user";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        

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
                            user.Gender = (Gender)int.Parse(dr[10].ToString());
                            user.Role = (Role)int.Parse(dr[11].ToString());
                            user.Status = (Status)int.Parse(dr[12].ToString());
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
