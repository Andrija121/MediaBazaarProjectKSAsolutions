using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    public class RequestResupplyManagement
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        public void CreateNewRequest(ResupplyRequest rr)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "Insert INTO requestresupply (wheId,dmId,sId,amount_requested,amount_fulfilled,requestStatus) values(@wheId,@dmid,@sid,@amount_requested,@amount_fulfilled,@requestStatus)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("wheId", rr.Whe.Id);
                    cmd.Parameters.AddWithValue("dmid", rr.Dm.Id);
                    cmd.Parameters.AddWithValue("sid", rr.Stock.Id);
                    cmd.Parameters.AddWithValue("amount_requested", rr.AmountRequested);
                    cmd.Parameters.AddWithValue("amount_fulfilled", rr.AmountFulfilled);
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
        public void SendRequestToDM(User user,Stock stock,ResupplyRequest rr) // instead of dm, SHOULD BE WHE
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "Insert INTO ResupplyRequest (wheId,dmid,stockid,amount_requested,amount_fulfilled,requestStatus) values(@wheId,@dmid,@stockid,@amount_requested,@amount_fulfilled,@requestStatus) ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("WheId", rr.Whe);
                    cmd.Parameters.AddWithValue("dmid", user.Id);
                    cmd.Parameters.AddWithValue("stockId", stock.Id);
                    cmd.Parameters.AddWithValue("amount_requested", rr.AmountRequested);
                    cmd.Parameters.AddWithValue("amount_fulfilled", rr.AmountFulfilled);
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
                        rr.Whe.Id = Convert.ToInt32(dr["wheid"]);
                        rr.Dm.Id = Convert.ToInt32(dr["dmid"]);
                        rr.Stock.Id = Convert.ToInt32(dr["sid"]);
                        rr.AmountRequested = Convert.ToInt32(dr["amount_requested"]);
                        rr.AmountFulfilled = Convert.ToInt32(dr["amount_fulfilled"]);
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
                        ResupplyRequest resupplyRequest = new ResupplyRequest();
                        resupplyRequest.AmountRequested = Convert.ToInt32(dr["amount_requested"]);
                        resupplyRequest.AmountFulfilled = Convert.ToInt32(dr["amount_fulfilled"]);
                        resupplyRequest.RequestStatus = Enum.Parse<RequestStatus>(dr["RequestStatus"].ToString());
                        resupplyRequest.Stock.Id = Convert.ToInt32(dr["sid"]);
                        resupplyRequest.Dm.Id = Convert.ToInt32(dr["dmid"]);
                        resupplyRequest.Whe.Id = Convert.ToInt32(dr["wheId"]); // error
                        rrs.Add(resupplyRequest);

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
        public ResupplyRequest GetResupplyRequest(int wheid)
        {
            try
            {
                using (conn)
                { 
                    conn.Open();
                    ResupplyRequest rr = new ResupplyRequest();
                    string sql = "select * from requestresupply where wheId=@wheId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("wheId", wheid);
                    
                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rr.RequestID = dr.GetInt32("requestId");
                        rr.Dm.Id = dr.GetInt32("dmid");
                        rr.Stock.Id = dr.GetInt32("sid");
                        rr.AmountRequested = dr.GetInt32("amount_requested");
                        rr.AmountFulfilled = dr.GetInt32("amount_fulfilled");
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
        public ResupplyRequest EditResupplyRequest(ResupplyRequest rr,int wheId) //whe
        {
            try
            {
                using (conn)
                {
                    conn.Open();

                    string sql = "Update RequestResupply set wheId=@wheId,dmid=@dmId,sid=@sid,amount_requested=@amount_requested,amount_fulfilled=@amount_fulfilled,requestStatus=@requestStatus where requestId=@requestId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("requestId", rr.RequestID);
                    cmd.Parameters.AddWithValue("@wheId",wheId);
                    cmd.Parameters.AddWithValue("@dmid", rr.Dm.Id);
                    cmd.Parameters.AddWithValue("@sid", rr.Stock.Id);
                    cmd.Parameters.AddWithValue("@amount_requested", rr.AmountRequested);
                    cmd.Parameters.AddWithValue("@amount_fulfilled", rr.AmountFulfilled);
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

        public void ApproveRequest(ResupplyRequest rr, int  wheId) // whe
        {
            rr.RequestStatus = RequestStatus.APPROVED;
            EditResupplyRequest(rr, wheId);
        }
        public void PartiallyApproveRquest(ResupplyRequest rr,int wheId,int amount)
        {
            rr.RequestStatus = RequestStatus.PARTIALLYDONE;
            rr.AmountFulfilled = amount;
            EditResupplyRequest(rr, wheId);
        }
        public void DeclineRequest(ResupplyRequest rr, int wheId)
        {
            rr.RequestStatus = RequestStatus.DECLINED;
            EditResupplyRequest(rr, wheId);
        }
    }
}
