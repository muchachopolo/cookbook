using System;
using System.ComponentModel.DataAnnotations;
using CookBook.Entities.Base;
using CookBook.Entities.Users;

namespace CookBook.Entities.Recipes
{
    public class Recipe : BaseModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public User User { get; set; }
    }
}
