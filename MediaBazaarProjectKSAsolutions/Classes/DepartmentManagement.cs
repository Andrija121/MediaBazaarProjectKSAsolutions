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
                    string sql = "INSERT INTO department(Name) values(@name)";



                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", department.Name);
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
        
        public Department EditDepartment(Department department) //Allow me to edit the Department
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "Update Department set Name= @namet";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", department.Id);
                    cmd.Parameters.AddWithValue("@Department", department.Name);
                    cmd.ExecuteNonQuery();
                }
                return department;


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
