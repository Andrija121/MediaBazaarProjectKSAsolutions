using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    public class Contract
    {
        public int ContractId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ContractType ContractType { get; set; }
        public double SalaryPerHour { get; set; }

        public Contract(int id,DateTime startDate,DateTime endDate, ContractType contractType,double salary)
        {
            this.ContractId = id;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ContractType = contractType;
            this.SalaryPerHour = salary;
        }
        public Contract()
        {

        }
        public override string ToString()
        {
            return StartDate + " - " + EndDate + " || " + ContractType + " - " + SalaryPerHour + " $ / H ";
        }
      
    }
}
