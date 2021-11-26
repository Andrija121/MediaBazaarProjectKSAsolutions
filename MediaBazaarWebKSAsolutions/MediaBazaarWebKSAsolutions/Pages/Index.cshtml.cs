using MediaBazaarWebKSAsolutions.Logic.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebKSAsolutions.Pages
{
    public class IndexModel : PageModel
    {
        public string UsernameFromSession { get; set; }
        public string displayTitle;
        public string displayCreator;
        public string displayImageURL;
        private readonly ILogger<IndexModel> _logger;




        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        //public void OnGet()
        //{
        //    string username = HttpContext.Session.GetString("username");
        //    if (username != null)
        //    {
        //        UsernameFromSession = username;
        //    }
        //    else
        //    {
        //        username = "";
        //    }
        //}

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
