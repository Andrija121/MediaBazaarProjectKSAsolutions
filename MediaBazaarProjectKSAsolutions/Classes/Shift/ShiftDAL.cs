﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
namespace MediaBazaarProjectKSAsolutions.Classes.Shift
{   
    public class ShiftDAL
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        public ShiftDAL()
        {

        }
        public Shift AddShift(Shift shifts)  //This Adds Shifts
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "INSERT INTO usershifts(user_Id,shift_Date,shift_Type) VALUES(@user_Id,@Shift_Date,@shift_Type)";
                   
                   MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@user_Id", shifts.User_Id);
                    cmd.Parameters.AddWithValue("@shift_Date", shifts.Shift_Date);
                    cmd.Parameters.AddWithValue("@shift_Type", shifts.Shift_Type.ToString());
                    cmd.ExecuteNonQuery(); 
                }
                return shifts;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

        }
        //public List<Shift>GetActiveShift()//Gets all the shits of the active Users only
        //{
        //    try
        //    {
        //        using (var conn = new MySqlConnection(Params.connectionString))
        //        {
        //            conn.Open();
        //            using (var command = conn.CreateCommand())
        //            {
        //                command.CommandText = @"SELECT * FROM `shift` as s INNER JOIN user as u on s.user_id = u.id WHERE u.status is ACTIVE";
        //                {
        //                    using (var reader = command.ExecuteReader())
        //                    {
        //                        List<Shift> shifts = new List<Shift>();
        //                        while (reader.Read())
        //                        {
        //                            Shift shift = new Shift();

        //                            shift.Shift_Id = reader.GetInt32("id");
        //                            shift.User_Id = reader.GetInt32("user_Id");
        //                            shift.Shift_Date = reader.GetDateTime("shift_Date");
        //                            shift.Shift_Type = (Shift_Type)reader.GetInt32("shift_Type");

        //                            shifts.Add(shift);

        //                        }
        //                        return shifts;
        //                    }
        //                }
        //            }
        //        }

        //    }
        //    catch(Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //}
        public List<Shift> GetShiftByDate(DateTime date)
        {
            using (var con = new MySqlConnection(Params.connectionString))
            {
                con.Open();
                using (var command = con.CreateCommand())
                {
                    //Select statment
                    command.CommandText = @"SELECT u.firstName, s.shift_type, s.shift_Date FROM `shifts`as s INNER JOIN 
                                          `user` as u ON  s.user_Id = u.id WHERE s.shift_Date = shift_Date  AND u.status  is TRUE ";
                    //command.Parameters.AddWithValue("status", );

                    //Executing it
                    using (var reader = command.ExecuteReader())
                    {
                        List<Shift> shifts = new List<Shift>();
                        List<User> users = new List<User>();
                        while (reader.Read())
                        {
                            Shift shift = new Shift();

                            //shift.Shift_Id = reader.GetInt32("id");
                            
                            shift.User_Id = reader.GetInt32("user_Id");
                            shift.Shift_Date = reader.GetDateTime("shift_Date");
                            shift.Shift_Type = (Shift_Type)reader.GetInt32("shift_Type");
                            shifts.Add(shift);
                        }
                        return shifts;
                    }
                }
            }



        }

        public Shift GetShiftById(int Shift_id ) //This Gets Shifts by ID
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    Shift shifts = new Shift();
                    string query = "SELECT * FROM shifts WHERE id= @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("shift_Id", Shift_id);


                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        shifts.Shift_Id = dr.GetInt32("id");
                        shifts.User_Id = dr.GetInt32("user_Id");
                        shifts.Shift_Date = dr.GetDateTime("shift_Date");
                        shifts.Shift_Type = (Shift_Type)dr.GetInt32("shift_Type");

                        return shifts;

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
        public List<Shift> GetTheLastShifts()
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM shifts WHERE shift_Id = (SELECT MAX(shift_Id)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Shift> shifts = new List<Shift>();

                    while (dr.Read())
                    {
                        Shift shift = new Shift();

                        shift.Shift_Id = Convert.ToInt32(dr["id"]);
                        shift.Shift_Type = Enum.Parse<Shift_Type>(dr["shift_Type"].ToString());
                        shift.Shift_Date = Convert.ToDateTime(dr["shift_Date"]);
                        shift.User_Id = Convert.ToInt32(dr["user_id"]);

                        shifts.Add(shift);
                    }
                    return shifts;
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
        }//This Returns AllShift
        public Shift UpdateShifts(Shift shift) //This Updates Shift
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE shifts SET user_Id =@user_Id, shift_Date =@shift_Date, shift_type = @Shift_type WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", shift.Shift_Id);
                    cmd.Parameters.AddWithValue("@user_Id", shift.User_Id);
                    cmd.Parameters.AddWithValue("@shift_Date", shift.Shift_Date);
                    cmd.Parameters.AddWithValue("@shift_type", shift.Shift_Type.ToString());

                    cmd.ExecuteNonQuery();
                }
                return shift;
                
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
        public void DeleteShift(int id) //This Deletes Shift
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "DELETE FROM shifts WHERE id =@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch(Exception)
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