using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
     public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birtyhday { get; set; }
        public int BSN { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public Role Role { get; set; }
        public Status Status { get; set; }
        Contract contract;
        



        public User(int id,string userName,string firstName,string lastName, string email, string password,DateTime birthday,int bsn, string zipCode,string address,Contract contract,Gender gender, Role role,Status status)
        {
            this.Id = id;
            this.UserName = userName;
            this.FirstName= firstName;
            this.LastName= lastName;
            this.Email = email;
            this.Password = password;
            this.Birtyhday= birthday;
            this.BSN = bsn;
            this.ZipCode = zipCode;
            this.Address = address;
            this.Gender = gender;
            this.Role = role;
            this.Status = status;
            this.contract = contract;
        }
        public User()
        {

        }
        public override string ToString()
        {
            return UserName + " - " + FirstName + " " + LastName + ", " + Email + " - " + BSN + " - " + Gender + " - " + Role; 
        }
    }
}
