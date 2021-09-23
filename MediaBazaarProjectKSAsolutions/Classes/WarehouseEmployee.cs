using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes    
{
    class WarehouseEmployee :User
    {
        public WarehouseEmployee(int id, string firstName, string lastName, string email, string password, Geneder geneder, DateTime birthday, int bSN, string zipCode, string address) : base(id, firstName, lastName, password, email, geneder, birthday, bSN, zipCode, address)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
