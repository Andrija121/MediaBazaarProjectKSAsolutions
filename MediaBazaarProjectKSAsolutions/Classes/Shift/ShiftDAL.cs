//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Text;
//namespace MediaBazaarProjectKSAsolutions.Classes.Shift
//{   
//    public class ShiftDAL
//    {
//        MySqlConnection conn = new MySqlConnection(Params.connectionString);

//        public ShiftDAL()
//        {

//        }
//        public void AddShift(Shift shifts)  //This Adds Shifts
//        {
//            //try
//            //{
//            //    using(MySqlConnection conn = new MySqlConnection(Params.connectionString))
//            //    {
//            //        string sql = "INSERT INTO shifts(user_Id,shift_Date,shift_Type) VALUES(@user_Id,@Shift_Date,shift_Type)";

//            //        MySqlCommand cmd = new MySqlCommand(sql, conn);

//            //        conn.Open();
//            //        cmd.Parameters.AddWithValue("@user_Id", shifts.User_Id);
//            //        cmd.Parameters.AddWithValue("@shift_Date", shifts.Shift_Date);
//            //        cmd.Parameters.AddWithValue("@shift_Type", shifts.Shift_Type.ToString());
//            //        cmd.ExecuteNonQuery(); 
//            //    }
//            //}
//            //catch(Exception)
//            //{
//            //    throw;
//            //}
//            //finally
//            //{
//            //    conn.Close();
//            //}

//        }
//        public Shift GetShiftId(int Shift_id ) //This Gets Shifts by ID
//        {
//            //try
//            //{
//            //    using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
//            //    {
//            //        conn.Open();
//            //        Shift shifts = new Shift();
//            //        string query = "SELECT * FROM shifts WHERE id= @id";
//            //        MySqlCommand cmd = new MySqlCommand(query, conn);

//            //        cmd.Parameters.AddWithValue("shift_Id", Shift_id);


//            //        MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

//            //        while (dr.Read())
//            //        {

//            //            shifts.Shift_Id = dr.GetInt32("id");
//            //            shifts.User_Id = dr.GetInt32("user_Id");
//            //            shifts.Shift_Date = dr.GetDateTime("shift_Date");
//            //            shifts.Shift_Type = (Shift_Type)dr.GetInt32("shift_Type");

//            //            return shifts;

//            //        }
//            //        return null;
//            //    }
//            //}
//            //catch (Exception)
//            //{
//            //    throw;
//            //}
//            //finally
//            //{
//            //    conn.Close();
//            //}

//        }
//        public List<Shift> GetAllShifts()
//        {
//            //try
//            //{

//            //    using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
//            //    {
//            //        conn.Open();
//            //        string sql = "SELECT * FROM shifts";
//            //        MySqlCommand cmd = new MySqlCommand(sql, conn);

//            //        MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

//            //        List<Shift> shifts =new List<Shift>(); 

//            //        while (dr.Read())
//            //        {
//            //            Shift shift = new Shift();
                        
//            //            shift.Shift_Id = Convert.ToInt32(dr["id"]);
//            //            shift.User_Id = Convert.ToInt32(dr["user_Id"]);
//            //            shift.Shift_Date = Convert.ToDateTime(dr["shift_Date"]);
//            //            shift.Shift_Type = Enum.Parse<Shift_Type>(dr["shift_Type"].ToString());
//            //            shifts.Add(shift);
//            //        }
//            //        return shifts;
//            //    }
//            //}
//            //catch(Exception)
//            //{
//            //    throw;
//            //}
//            //finally
//            //{
//            //    conn.Close();
//            //}
//        }//This Returns AllShift
//        public Shift UpdateShifts(Shift shift) //This Updates Shift
//        {
//            //try
//            //{
//            //    using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
//            //    {
//            //        conn.Open();
//            //        string sql = "UPDATE shifts SET User_Id =@user_Id, shift_Date =@shift_Date, shift_Type=@Shift_Type";
//            //        MySqlCommand cmd = new MySqlCommand(sql, conn);

//            //        cmd.Parameters.AddWithValue("@id", shift.Shift_Id);
//            //        cmd.Parameters.AddWithValue("@user_Id", shift.User_Id);
//            //        cmd.Parameters.AddWithValue("@shift_Date", shift.Shift_Date);
//            //        cmd.Parameters.AddWithValue("@shift_Type", shift.Shift_Type);

//            //        cmd.ExecuteNonQuery();
//            //    }
//            //    return shift;
                
//            //}
//            //catch (Exception)
//            //{
//            //    throw;
//            //}
//            //finally
//            //{
//            //    conn.Close();
//            //}
//        }
//        public void DeleteShift(int Shift_Id) //This Deletes Shift
//        {
//            try
//            {
//                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
//                {
//                    string sql = "DELETE FROM shifts WHERE id =@id";
//                    MySqlCommand cmd = new MySqlCommand(sql, conn);
//                    cmd.Parameters.AddWithValue("@id", Shift_Id);

//                    conn.Open();
//                    cmd.ExecuteNonQuery();
//                    conn.Close();
//                }
//            }
//            catch(Exception)
//            {
//                throw;
//            }
//            finally
//            {
//                conn.Close();
//            }
//        }
//    }
//}

