using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class DepartmentManagement
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString);

        public DepartmentManagement()
        {

        }
        public void AddDepartment(Department department)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    string sql = "INSERT INTO department(Name,ManagerId) values(@nam,@managerId)";



                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", department.Name);
                    cmd.Parameters.AddWithValue("@mangerId", department.ManagerID);
                    cmd.ExecuteNonQuery();

                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Department> GetDepartments()
        {

            
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                    {
                        conn.Open();


                        string query = "select * from department";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        
                        



                        MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();
                        List<Department> departments = new List<Department>();
                        while (dr.Read())
                        {
                            Department d = new Department();
                            d.Id = Convert.ToInt32(dr["id"]);
                            d.Name = dr["name"].ToString();
                            d.ManagerID = Convert.ToInt32(dr["managerid"]);
                            departments.Add(d);
                        }
                        return departments;
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
