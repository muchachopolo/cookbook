using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.Entities.Recipes;
using CookBook.Entities.Users;
using CookBook.Services.Recipes;
using CookBook.Services.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookBook.ViewModels.Home
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public IList<Recipe> Recipes { get; set; }

        private readonly RecipesService _service;

        public IndexModel(RecipesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGet()
        {
            Recipes = await _service.getAllRecipes();

            return Page();
        }
    }
}
