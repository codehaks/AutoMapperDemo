using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Pages.Books
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
        }

        class BookInput
        {
            public string Name { get; set; }

        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
