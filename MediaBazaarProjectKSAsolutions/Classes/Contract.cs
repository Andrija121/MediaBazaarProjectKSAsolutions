using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class Contract
    {
        public int ContractId { get;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ContractType ContractType { get; set; }
        public double Salary { get; set; }

    }
}
