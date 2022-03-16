using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace HomeController.Pages
{
    public class StripeSettings : PageModel
    {

        public IOptions<MosqueCharity.Pages.StripeSettings> Stripe { get; private set; }


    }

}