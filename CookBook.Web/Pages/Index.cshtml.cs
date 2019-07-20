using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.Entities.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookBook.Web.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public User User { get; set; }

        public void OnPost()
        {

        }
    }
}
