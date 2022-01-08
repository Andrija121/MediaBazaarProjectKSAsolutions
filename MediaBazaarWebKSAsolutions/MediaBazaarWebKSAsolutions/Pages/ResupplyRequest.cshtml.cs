using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaBazaarProjectKSAsolutions.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebKSAsolutions.Pages
{
    public class ResupplyRequestModel : PageModel
    {
        RequestResupplyManagement rrm = new RequestResupplyManagement();
        public List<ResupplyRequest> MyRRs { get; set; }
        public void OnGet()
        {
            MyRRs = rrm.GetPendingResupplyRequests();
        }
    }
}
