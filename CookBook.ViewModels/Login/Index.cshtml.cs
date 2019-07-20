using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.Entities.Users;
using CookBook.Services.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookBook.ViewModels.Login
{
    public class IndexModel : PageModel
    {
        private readonly LoginService _loginService;

        public IndexModel(LoginService loginService)
        {
            _loginService = loginService;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (await _loginService.LogginAttempt(User.Email, User.Password))
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
