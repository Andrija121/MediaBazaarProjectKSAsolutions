using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebKSAsolutions.Pages
{
    public class ScheduleModel : PageModel
    {
        public string UsernameFromSession { get; set; }

        public IActionResult OnGet()
        {
            string username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                UsernameFromSession = username;
                return Page();
            }
            return Redirect("/Login");
        }
    }
}
