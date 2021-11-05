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
                    string sql = "SELECT u.userName,udm.userName,s.productName FROM `requestresupply` INNER JOIN user as u ON requestresupply.wheId = u.id INNER JOIN user AS udm ON requestresupply.dmid = udm.id INNER JOIN stock as s ON requestresupply.sid = s.id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<String> answers = new List<String>();

                    while (dr.Read())
                    {
                        ResupplyRequest rr = new ResupplyRequest();
                        string userName = dr.GetString("userName");
                        string dmUserName = dr.GetString("userName");
                        string productName = dr.GetString("productName");
                        string answer = userName + " - " + dmUserName + " - " + productName;
                        answers.Add(answer);
                    }
                    return answers;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
