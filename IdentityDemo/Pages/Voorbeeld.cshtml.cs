using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityDemo.Pages
{
    public class VoorbeeldModel : PageModel
    {
        public string Message { get; private set; } = "Vanuit de pagina in C#! ";
        public void OnGet()
        {
            Message += $"Het is nu {DateTime.Now}.";
        }
    }
}