using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string birthday;
        private int bSN;
        private string zipCode;
        private string address;
        private Gender gender;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
