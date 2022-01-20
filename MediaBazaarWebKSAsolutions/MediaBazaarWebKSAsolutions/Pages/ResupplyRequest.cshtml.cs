using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaBazaarProjectKSAsolutions.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebKSAsolutions.Pages
{
    public class ResupplyRequestModel : PageModel
    {
        public string UsernameFromSession { get; set; }
        RequestResupplyManagement rrm = new RequestResupplyManagement();
        public List<ResupplyRequest> MyRRs { get; set; }

        public IActionResult OnGet()
        {
            MyRRs = rrm.GetPendingResupplyRequests();
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
