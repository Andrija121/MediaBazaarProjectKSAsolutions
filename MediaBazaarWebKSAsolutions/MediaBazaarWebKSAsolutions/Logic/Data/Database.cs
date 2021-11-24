using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebKSAsolutions.Logic.Data
{
    public class Database
    {
        public static string connectionString = "server=studmysql01.fhict.local;uid=dbi454447;database=dbi454447;Pwd=root;Sslmode=none";

        public bool Connect(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}
