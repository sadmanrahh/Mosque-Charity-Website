﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MosqueCharity.Pages
{
    public class NewsModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your  page.";
        }
    }
}
