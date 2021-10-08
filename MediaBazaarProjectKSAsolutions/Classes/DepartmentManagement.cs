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
                    string sql = "INSERT INTO department(name) values(@name)";



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
                    string sql = "select * from department where status=@status";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@status", Status.ACTIVE.ToString());

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Department> departments= new List<Department>();

                    while (dr.Read())
                    {
                        Department department = new Department();
                        department.Id = Convert.ToInt32(dr["id"]);
                        department.Name = dr["name"].ToString();
                        department.Status = Enum.Parse<Status>(dr["status"].ToString());
                        departments.Add(department);
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

        public Department EditDepartment(Department department) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "Update Department set name=@name, status=@status where id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", department.Id);
                    cmd.Parameters.AddWithValue("@name", department.Name);
                    cmd.Parameters.AddWithValue("@status", department.Status.ToString());

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
        public void DeleteDepartment(int id)
        {
            {
                try
                {
                    using (MySqlConnection conn=new MySqlConnection(Params.connectionString))
                    {
                        string sql = "delete from Department where id=@id";

                        MySqlCommand cmd = new MySqlCommand(sql,conn);

                        cmd.Parameters.AddWithValue("id", id);

                        conn.Open();
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
        }
        
    }
}
