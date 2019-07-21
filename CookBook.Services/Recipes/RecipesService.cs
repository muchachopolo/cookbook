using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CookBook.DataSource.Repository;
using CookBook.Entities.Recipes;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Services.Recipes
{
    public class RecipesService
    {
        private readonly DataRepository _repository;

        public RecipesService(DataRepository repository)
        {
            _repository = repository;
        }

        public async Task<IList<Recipe>> getAllRecipes()
        {
            return await _repository.Recipes.ToListAsync();
        }
    }
}
