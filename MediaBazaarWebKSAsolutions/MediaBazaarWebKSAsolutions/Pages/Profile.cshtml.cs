using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MediaBazaarWebKSAsolutions.Logic.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebKSAsolutions.Pages
{
    public class ProfileModel : PageModel
    {
        private MediaBazaarWebKSAsolutions.Logic.Data.UserBase ub = new Logic.Data.UserBase();
        User user = new User();


        [BindProperty]
        public string profileUsername { get; set; }
        [BindProperty]
        [Required, EmailAddress(ErrorMessage = "Please enter a correct email adress")]
        public string profileEmail { get; set; }
        [BindProperty]
        [Required, MinLength(6, ErrorMessage = "Please enter a password with at least 6 characters")]
        public string profilePassword { get; set; }

        public string UsernameFromSession { get; set; }

        public IActionResult OnGet()
        {
            string username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                UsernameFromSession = username;
                LoadTextboxes();
                return Page();
            }
            return Redirect("/Login");
        }

        public ActionResult OnPost(string submit)
        {
            string username = HttpContext.Session.GetString("username");
            switch (submit)
            {
                case "Update":
                    ub = new Logic.Data.UserBase();
                    User updateUser = ub.UpdateUser(HttpContext.Session.GetString("username"), profileEmail, profilePassword);

                    if (updateUser != null)
                    {
                        HttpContext.Session.SetString("username", username);
                        LoadTextboxes();
                        UsernameFromSession = username;
                        return Page();
                    }
                    break;
                case "Logout":
                    HttpContext.Session.Clear();
                    return Redirect("Index");
            }
            return Page();
        }

        public void LoadTextboxes()
        {
            User loadUser = ub.GetUser(HttpContext.Session.GetString("username"));
            profileUsername = loadUser.Username;
            profileEmail = loadUser.Email;
            profilePassword = loadUser.Password;
            //loadUser.Username = profileUsername;
        }
    }
}