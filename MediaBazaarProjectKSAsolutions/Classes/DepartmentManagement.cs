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
        public List<Department> GetActiveDepartments()
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

                    List<Department> activeDepartments= new List<Department>();

                    while (dr.Read())
                    {
                        Department department = new Department();
                        department.Id = dr.GetInt32("id");
                        department.Name = dr["name"].ToString();
                        department.Status = Enum.Parse<Status>(dr["status"].ToString());
                        activeDepartments.Add(department);
                    }
                    return activeDepartments;

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
        public List<Department> GetInactiveDepartments()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Params.connectionString))
                {
                    conn.Open();
                    string sql = "select * from department where status=@status";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@status", Status.INACTIVE.ToString());

                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader();

                    List<Department> inactiveDepartments = new List<Department>();

                    while (dr.Read())
                    {
                        Department department = new Department();
                        department.Id = Convert.ToInt32(dr["id"]);
                        department.Name = dr["name"].ToString();
                        department.Status = Enum.Parse<Status>(dr["status"].ToString());
                        inactiveDepartments.Add(department);
                    }
                    return inactiveDepartments;

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
        public void SetDepartmentInactive(Department department)
        {
            department.Status = Status.INACTIVE;
            EditDepartment(department);
        }
        
    }
}
