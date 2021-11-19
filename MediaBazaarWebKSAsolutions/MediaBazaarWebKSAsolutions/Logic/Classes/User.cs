using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebKSAsolutions.Logic.Classes
{
    public class User
    {
        public User()
        {

        }

        public User(int id, string username, string email, string password)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
        }

        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Please enter a username with at least 2 characters")]
        public string Username { get; set; }
        [Required, EmailAddress(ErrorMessage = "Please enter a correct email adress")]
        public string Email { get; set; }
        [Required, MinLength(2, ErrorMessage = "Please enter a password with at least 2 characters")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "The passwords doesn't match, please try again")]
        public string Password2 { get; set; }
    }
}
