using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class RequestResupplyManagement
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        public void CreateNewRequest(ResupplyRequest rr)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "Insert INTO requestresupply (wheId,dmId,sId,amount,requestStatus) values(@wheId,@dmid,@sid,@amount,@requestStatus)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("wheId", rr.WheId);
                    cmd.Parameters.AddWithValue("dmid", rr.DmId);
                    cmd.Parameters.AddWithValue("sid", rr.StockId);
                    cmd.Parameters.AddWithValue("amount", rr.Amount);
                    cmd.Parameters.AddWithValue("requestStatus", rr.RequestStatus.ToString());
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
        public void SendRequestToDM(User user,Stock stock,ResupplyRequest rr)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "Insert INTO ResupplyRequest values(wheId,dmid,stockId,amount,requestStatus) where(@wheId,@dmid,@stockid,@amount,@requestStatus) ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("WheId", rr.WheId);
                    cmd.Parameters.AddWithValue("dmid", user.Id);
                    cmd.Parameters.AddWithValue("stockId", stock.Id);
                    cmd.Parameters.AddWithValue("amount", rr.Amount);
                    cmd.Parameters.AddWithValue("requestStatus", rr.RequestStatus.ToString());
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
        public List<ResupplyRequest> GetResupplyRequests()
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "select * from requestresupply ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();


                    List<ResupplyRequest> rrs = new List<ResupplyRequest>();

                    while (dr.Read())
                    {
                        ResupplyRequest rr = new ResupplyRequest();
                        rr.WheId = Convert.ToInt32(dr["wheid"]);
                        rr.DmId = Convert.ToInt32(dr["dmid"]);
                        rr.StockId = Convert.ToInt32(dr["sid"]);
                        rr.Amount = Convert.ToInt32(dr["amount"]);
                        rr.RequestStatus = Enum.Parse<RequestStatus>(dr["RequestStatus"].ToString());
                        rrs.Add(rr);

                    }
                    return rrs;
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
        public List<ResupplyRequest> GetPendingResupplyRequests()
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "select * from requestresupply where requestStatus=@requestStatus";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("requestStatus", RequestStatus.PENNDING.ToString());
                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();


                    List<ResupplyRequest> rrs = new List<ResupplyRequest>();

                    while (dr.Read())
                    {
                        ResupplyRequest rr = new ResupplyRequest();
                        rr.WheId = Convert.ToInt32(dr["wheid"]);
                        rr.DmId = Convert.ToInt32(dr["dmid"]);
                        rr.StockId = Convert.ToInt32(dr["sid"]);
                        rr.Amount = Convert.ToInt32(dr["amount"]);
                        rr.RequestStatus = Enum.Parse<RequestStatus>(dr["RequestStatus"].ToString());
                        rrs.Add(rr);

                    }
                    return rrs;
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
        public ResupplyRequest GetResupplyRequest(int dmid)
        {
            try
            {
                using (conn)
                { 
                    conn.Open();
                    ResupplyRequest rr = new ResupplyRequest();
                    string sql = "select * from requestresupply where dmid=@dmid";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("dmid", dmid);
                    
                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rr.RequestID = dr.GetInt32("requestId");
                        rr.WheId = dr.GetInt32("wheId");
                        rr.StockId = dr.GetInt32("sid");
                        rr.Amount = dr.GetInt32("Amount");
                        rr.RequestStatus = Enum.Parse<RequestStatus>(dr["RequestStatus"].ToString());
                    }
                    return rr;
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
        public ResupplyRequest EditResupplyRequest(ResupplyRequest rr,int dmid)
        {
            try
            {
                using (conn)
                {
                    conn.Open();

                    string sql = "Update RequestResupply set wheId=@wheId,dmid=@dmId,sid=@sid,amount=@amount,requestStatus=@requestStatus where requestId=@requestId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("requestId", rr.RequestID);
                    cmd.Parameters.AddWithValue("@wheId", rr.WheId);
                    cmd.Parameters.AddWithValue("@dmid", dmid);
                    cmd.Parameters.AddWithValue("@sid", rr.StockId);
                    cmd.Parameters.AddWithValue("@amount", rr.Amount);
                    cmd.Parameters.AddWithValue("@requestStatus", rr.RequestStatus.ToString());
                    cmd.ExecuteNonQuery();
                }
                return rr;
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

        public void ApproveRequest(ResupplyRequest rr, int  dmid)
        {
            rr.RequestStatus = RequestStatus.APPROVED;
            EditResupplyRequest(rr,dmid);
        }
        public void DeclineRequest(ResupplyRequest rr, int dmid)
        {
            rr.RequestStatus = RequestStatus.DECLINED;
            EditResupplyRequest(rr,dmid);
        }
    }
}
