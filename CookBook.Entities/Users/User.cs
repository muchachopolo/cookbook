using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CookBook.Entities.Base;

namespace CookBook.Entities.Users
{
    public class User : BaseModel
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "The password field must be more than 8 digits.")]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DefaultValue(true)]
        public bool active { get; set; }
        [Required]
        public DateTime Birth { get; set; }
    }
}
