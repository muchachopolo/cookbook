using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.Entities.Users;
using CookBook.Services.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookBook.ViewModels.Home
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
