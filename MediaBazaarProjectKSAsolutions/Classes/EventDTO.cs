using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class EventDTO
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        public List<String> GetAllResupplyEvents()
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "SELECT u.userName,udm.userName,s.productName,requestStatus FROM `requestresupply` INNER JOIN user as u ON requestresupply.wheId = u.id INNER JOIN user AS udm ON requestresupply.dmid = udm.id INNER JOIN stock as s ON requestresupply.sid = s.id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<String> answers = new List<String>();

                    while (dr.Read())
                    {
                        ResupplyRequest rr = new ResupplyRequest();
                        string userName = dr.GetString("userName");
                        string dmUserName = dr.GetString("userName");
                        string productName = dr.GetString("productName");
                        string requestStatus = dr.GetString("requestStatus");
                        string answer = userName + " - " + dmUserName + " - " + productName + " - " + requestStatus;
                        answers.Add(answer);
                    }
                    return answers;


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
        //public List<String> GetAllAnsweredRequestsOFDaysOff()
        //{
        //    try
        //    {
        //        using (conn)
        //        {
        //            conn.Open();
        //            string sql = "";
        //            MySqlCommand cmd = new MySqlCommand(sql,conn);

        //            MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

        //            while (dr.Read())
        //            {

        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
    }
}
