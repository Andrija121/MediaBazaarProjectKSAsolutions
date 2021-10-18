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
                using (conn)
                {
                    string sql = "INSERT INTO user(userName,firstName,lastName,email,password,birthday,bsn,zipcode,address,gender,role,status) values(@userName,@firstName,@lastName,@email,@password,@birthday,@bsn,@zipcode,@address,@gender,@role,@status)";



                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@userName", user.UserName);
                    cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", user.LastName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@birthday", user.Birtyhday);
                    cmd.Parameters.AddWithValue("@bsn", user.BSN);
                    cmd.Parameters.AddWithValue("@zipcode", user.ZipCode);
                    cmd.Parameters.AddWithValue("@address", user.Address);
                    cmd.Parameters.AddWithValue("@gender", user.Gender.ToString());
                    cmd.Parameters.AddWithValue("@role", user.Role.ToString());
                    cmd.Parameters.AddWithValue("@status", user.Status.ToString());
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
                using (conn)
                {
                    conn.Open();
                    string sql = "Update user set username=@userName, firstName=@firstName,lastName=@lastName,email=@email,password=@password,birthday=@birthday,bsn=@bsn,zipcode=@zipCode,address=@address,gender=@gender,role=@role,status=@status where id =@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", u.Id);
                    cmd.Parameters.AddWithValue("@userName", u.UserName);
                    cmd.Parameters.AddWithValue("@firstName", u.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", u.LastName);
                    cmd.Parameters.AddWithValue("@email", u.Email);
                    cmd.Parameters.AddWithValue("@password", u.Password);
                    cmd.Parameters.AddWithValue("birthday", u.Birtyhday);
                    cmd.Parameters.AddWithValue("bsn", u.BSN);
                    cmd.Parameters.AddWithValue("zipcode", u.ZipCode);
                    cmd.Parameters.AddWithValue("@address", u.Address);
                    cmd.Parameters.AddWithValue("@gender", u.Gender.ToString());
                    cmd.Parameters.AddWithValue("@role", u.Role.ToString());
                    cmd.Parameters.AddWithValue("@status", u.Status.ToString());

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
        public List<User> GetInactiveUsers()
        {
            try
            {
                using(conn)
                {
                    conn.Open();
                    string sql = "select * from user where status=@status";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@status", Status.INACTIVE.ToString());

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<User> inactiveUsers = new List<User>();

                    while (dr.Read())
                    {
                        User user = new User();
                        user.Id = Convert.ToInt32(dr["id"]);
                        user.UserName = dr["USERNAME"].ToString();
                        user.FirstName = dr["FIRSTNAME"].ToString();
                        user.LastName = dr["LASTNAME"].ToString();
                        user.Email = dr["EMAIL"].ToString();
                        user.Password = dr["PASSWORD"].ToString();
                        user.Birtyhday = Convert.ToDateTime(dr["BIRTHDAY"]);
                        user.BSN = Convert.ToInt32(dr["BSN"]);
                        user.ZipCode = dr["ZIPCODE"].ToString();
                        user.Address = dr["ADDRESS"].ToString();
                        user.Gender = Enum.Parse<Gender>(dr["GENDER"].ToString());
                        user.Role = Enum.Parse<Role>(dr["ROLE"].ToString());
                        user.Status = Enum.Parse<Status>(dr["STATUS"].ToString());
                        inactiveUsers.Add(user);
                    }
                    return inactiveUsers;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<User> GetUsers()
            {
                try
                {
                    using (conn)
                    {
                    conn.Open();
                    string sql = "select * from user where status=@status ";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@status", Status.ACTIVE.ToString());



                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                        List<User> users = new List<User>();

                        while (dr.Read())
                        {
                            User user = new User();
                            user.Id = Convert.ToInt32(dr["id"]);
                            user.UserName = dr["USERNAME"].ToString();
                            user.FirstName = dr["FIRSTNAME"].ToString();
                            user.LastName = dr["LASTNAME"].ToString();
                            user.Email = dr["EMAIL"].ToString();
                            user.Password = dr["PASSWORD"].ToString();
                            user.Birtyhday = Convert.ToDateTime(dr["BIRTHDAY"]);
                            user.BSN = Convert.ToInt32(dr["BSN"]);
                            user.ZipCode = dr["ZIPCODE"].ToString();
                            user.Address = dr["ADDRESS"].ToString();
                            user.Gender =Enum.Parse<Gender>( dr["GENDER"].ToString());
                            user.Role = Enum.Parse<Role>(dr["ROLE"].ToString());
                            user.Status = Enum.Parse<Status>(dr["STATUS"].ToString());
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

        public void SetUserStatusToInactive(User user)
            {
            user.Status = Status.INACTIVE;
            EditUser(user);
            }


        }
    } 
