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
        public DaysOff GetDayOff(int hrManagerId)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    DaysOff dayOff = new DaysOff();
                    string sql = "select * from daysoff where hrManagerId=@hrManagerId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("hrManagerId", hrManagerId);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        dayOff.StartDate = dr.GetDateTime("startDate");
                        dayOff.EndDate = dr.GetDateTime("endDate");
                        dayOff.Reason = dr.GetString("reason");
                        dayOff.RequestStatus = Enum.Parse<RequestStatus>(dr["requestStatus"].ToString());

                    }
                    return dayOff;
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
                    string sql = "SELECT * FROM daysoff where requestStatus=@requestStatus";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("requestStatus", RequestStatus.PENNDING.ToString());

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
        public DaysOff EditDaysOff(DaysOff doff,int hrManagerId)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "Update daysoff set startDate=@startDate,endDate=@endDate,reason=reason,requestStatus=@requestStatus where hrManagerId=@hrManagerId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("hrManagerId", hrManagerId);
                    cmd.Parameters.AddWithValue("startDate", doff.StartDate);
                    cmd.Parameters.AddWithValue("endDate", doff.EndDate);
                    cmd.Parameters.AddWithValue("reason", doff.Reason);
                    cmd.Parameters.AddWithValue("requestStatus", doff.RequestStatus.ToString());
                    cmd.ExecuteNonQuery();
                }
                return doff;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                conn.Close();
            }
        }
        public void ApproveRequest(DaysOff doff, int hrManagerId)
        {
            doff.RequestStatus = RequestStatus.APPROVED;
            EditDaysOff(doff, hrManagerId);
        }
        public void DeclineRequest(DaysOff doff, int hrManagerId)
        {
            doff.RequestStatus = RequestStatus.DECLINED;
            EditDaysOff(doff,hrManagerId);
        }
    }
}
