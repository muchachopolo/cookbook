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
    public class ProfileModel : PageModel
    {
        private readonly UserService userService;
        public User User { get; set; }

        public ProfileModel(UserService userService)
        {
            this.userService = userService;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await userService.GetUserAsync(id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
