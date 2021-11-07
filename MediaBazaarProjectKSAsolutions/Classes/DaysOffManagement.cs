using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class DaysOffManagement
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        public void CreateDaysOffRequest(DaysOff daysOff)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "INSERT INTO daysoff(hrManagerId,startDate,endDate,reason,requestStatus) values(@hrManagerId,@startDate,@endDate,@reason,@requestStatus)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("hrManagerId", daysOff.HRManagerId);
                    cmd.Parameters.AddWithValue("startDate", daysOff.StartDate);
                    cmd.Parameters.AddWithValue("endDate", daysOff.EndDate);
                    cmd.Parameters.AddWithValue("reason", daysOff.Reason);
                    cmd.Parameters.AddWithValue("requestStatus", daysOff.RequestStatus.ToString());
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
        public List<DaysOff> GetRequestsForDaysOff()
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "SELECT * FROM daysOff where requestStatus=@requestStatus";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("status", RequestStatus.PENNDING.ToString());

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<DaysOff> daysOffRequests = new List<DaysOff>();
                    while (dr.Read())
                    {
                        DaysOff daysOff = new DaysOff();
                        daysOff.RequestId = dr.GetInt32("requestId");
                        daysOff.HRManagerId = dr.GetInt32("hrManagerId");
                        daysOff.StartDate = dr.GetDateTime("startDate");
                        daysOff.EndDate = dr.GetDateTime("endDate");
                        daysOff.Reason = dr.GetString("reason");
                        daysOffRequests.Add(daysOff);

                    }
                    return daysOffRequests;
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
