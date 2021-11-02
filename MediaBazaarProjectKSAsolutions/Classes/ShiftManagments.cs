using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
namespace MediaBazaarProjectKSAsolutions.Classes
{
    class ShiftManagments
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        public ShiftManagments()
        {

        }
        public void AddShift( Shift shifts)  //This Adds Shifts
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "INSERT INTO shifts(user_id,shift_date,shift_type) VALUES(@User_Id,@Shift_date,Shift_Type)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@User_id", shifts.User_Id);
                    cmd.Parameters.AddWithValue("@U", shifts.Shift_Date);
                    cmd.Parameters.AddWithValue("@User_id", shifts.Shift_Type.ToString());
                    cmd.ExecuteNonQuery(); 
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
        public Shift GetShiftId(int Shift_id ) //This Gets Shifts by ID
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    Shift shifts = new Shift();
                    string query = "SELECT * FROM shift WHERE shift_id= @Shift_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("shift_Id", Shift_id);


                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        shifts.Shift_Id = dr.GetInt32("shift_id");
                        shifts.User_Id = dr.GetInt32("user_id");
                        shifts.Shift_Date = dr.GetDateTime("shift_date");
                        shifts.Shift_Type = (Shift_Type)dr.GetInt32("shift_type");

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
        public List<Shift> GetAllShifts()
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Shift";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Shift> shifts =new List<Shift>(); 

                    while (dr.Read())
                    {
                        Shift shift = new Shift();
                        shift.Shift_Id = Convert.ToInt32(dr["Shift_Id"]);
                        shift.User_Id = Convert.ToInt32(dr["User_Id"]);
                        shift.Shift_Date = Convert.ToDateTime(dr["Shift_Date"]);
                        shift.Shift_Type = Enum.Parse<Shift_Type>(dr["Shift_Type"].ToString());
                        shifts.Add(shift);
                    }
                    return shifts;
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
        }//This Returns AllShift
        public Shift UpdateShifts(Shift shift) //This Updates Shift
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE shift SET User_Id =@User_Id, Shift_Date =@Shift_Date, Shift_Type=@Shift_Type";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Shift_Id", shift.Shift_Id);
                    cmd.Parameters.AddWithValue("@User_Id", shift.User_Id);
                    cmd.Parameters.AddWithValue("@Shift_Date", shift.Shift_Date);
                    cmd.Parameters.AddWithValue("@Shift_Type", shift.Shift_Type);

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
        public void DeleteShift(int Shift_Id) //This Deletes Shift
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "DELETE FROM shift WHERE Shift_Id =@Shift_Id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Shift_Id", Shift_Id);

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
