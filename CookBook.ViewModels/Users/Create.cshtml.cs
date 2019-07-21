using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.Entities.Users;
using CookBook.Services.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookBook.ViewModels.Users
{
    public class CreateModel : PageModel
    {
        private readonly UserService userService;
        private readonly LoginService loginService;

        public CreateModel (UserService userService, LoginService loginService)
        {
            this.userService = userService;
            this.loginService = loginService;
        }

        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {
            ViewData["creationErrorMessage"] = TempData["creationErrorMessage"];
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            User = await userService.CreateUser(User);
            var isLogged = await loginService.LogginAttempt(User.Email, User.Password);
            if(isLogged)
            {
                return RedirectToPagePermanent("../Home/Index");
            }
            else
            {
                //TODO: replace with error handler
                TempData["creationErrorMessage"] = "Something Went Wrong, please try again.";
                return Page();
            }
        }
    }
}
