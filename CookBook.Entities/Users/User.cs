using System;
using CookBook.Entities.Base;

namespace CookBook.Entities.Users
{
    public class User : BaseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool active { get; set; }
        public DateTime Birth { get; set; }
    }
}
