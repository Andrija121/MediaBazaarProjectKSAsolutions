using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
     public  class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string password;
        private string email;
        private Geneder geneder;
        private DateTime birthday;
        private int bSN;
        private string zipCode;
        private string address;

        public int Id   { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id,string firstName,string lastName,string password,string email,Geneder geneder,DateTime birthday,int bsn,string zipCode,string address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
            this.geneder = geneder;
            this.birthday = birthday;
            this.bSN = bsn;
            this.zipCode = zipCode;
            this.address = address;
        }
        public User()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
