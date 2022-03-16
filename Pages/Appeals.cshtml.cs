using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MosqueCharity.Pages
{
    public class AppealsModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your description page.";
        }
    }
}
