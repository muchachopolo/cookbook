using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.Services.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookBook.ViewModels.Login
{
    public class LogoutModel : PageModel
    {
        private readonly LoginService _loginService;

        public LogoutModel(LoginService loginService)
        {
            _loginService = loginService;
        }


        public IActionResult OnGet()
        {
            if (_loginService.IsSignedIn())
            {
                _loginService.logout();
            }
            return RedirectToPage("/Index");
        }
    }
}
