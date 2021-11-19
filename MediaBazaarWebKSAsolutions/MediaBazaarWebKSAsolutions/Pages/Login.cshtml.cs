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
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required, MinLength(2, ErrorMessage = "Please enter a username with at least 2 characters")]
        public string loginUsername { get; set; }
        [BindProperty]
        [Required, MinLength(2, ErrorMessage = "Please enter a password with at least 2 characters")]
        public string loginPassword { get; set; }
        private MediaBazaarWebKSAsolutions.Logic.Data.UserBase ub;
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                ub = new Logic.Data.UserBase();
                User loginUser = ub.Login(loginUsername, loginPassword);
                if (loginUser != null)
                {
                    HttpContext.Session.SetString("username", loginUser.Username);

                    return RedirectToPage("Index");
                }
            }
            return Page();
        }
    }
}
