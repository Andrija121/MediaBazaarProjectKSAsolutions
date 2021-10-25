using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class ContractManagement
    {
        MySqlConnection conn = new MySqlConnection(Params.connectionString); 
        public void AddContract(Contract contract)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "INSERT INTO(startDate,endDate,contractType,salaryPerHour) values(@startDate,@endDate,@contractType,@salaryPerHour)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("startDate", contract.StartDate);
                    cmd.Parameters.AddWithValue("endDate", contract.EndDate);
                    cmd.Parameters.AddWithValue("contractType", contract.ContractType.ToString());
                    cmd.Parameters.AddWithValue("salaryPerHour", contract.SalaryPerHour);
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
        public List<Contract> GetContracts()
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "SELECT * FROM contract where contractId=@contractId"; MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader dr = (MySqlDataReader)cmd.ExecuteReader(); List<Contract> contracts = new List<Contract>();
                    while (dr.Read())
                    {
                        Contract contract = new Contract();
                        contract.ContractId = Convert.ToInt32(dr["contractId"]);
                        contract.StartDate = Convert.ToDateTime(dr["StartDate"]);
                        contract.EndDate = Convert.ToDateTime(dr["EndDate"]);
                        contract.ContractType = Enum.Parse<ContractType>(dr["ContractType"].ToString());
                        contract.SalaryPerHour = Convert.ToDouble(dr["salaryPerHour"]); contracts.Add(contract);
                    }
                    return contracts;
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
        public Contract EditContract(Contract contract)
        {
            try
            {
                using (conn)
                {
                    conn.Open();
                    string sql = "UPDATE values set startDate=@startDate,endDate=@endDate,ContractType=@ContractType,salaryPerHour=@salaryPerHour where contractId=@contractId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn); cmd.Parameters.AddWithValue("startDate", contract.StartDate);
                    cmd.Parameters.AddWithValue("endDate", contract.EndDate);
                    cmd.Parameters.AddWithValue("contractType", contract.ContractType);
                    cmd.Parameters.AddWithValue("salaryPerHour", contract.SalaryPerHour);
                }
                return contract;
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

