using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.Entities.Users;
using CookBook.DataSource.Repository;
using CookBook.Services.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Services.Users
{
    public class LoginService
    {
        private readonly DataRepository _repository;
        private readonly IHttpContextAccessor _context;

        public LoginService(DataRepository repository, IHttpContextAccessor context)
        {
            _repository = repository;
            _context = context;
        }

        public void logout()
        {
            _context.HttpContext.Session.Clear();
        }

        public async Task<bool> LogginAttempt(string username, string password)
        {
            var User = await _repository.Users
                .Where(
                    user => user.Email == username && user.Password == password
                ).Select(user => new User
                {
                    Id = user.Id,
                    Email = user.Email,
                    active = user.active,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                }).FirstOrDefaultAsync();
            if (User != null)
            {
                _context.HttpContext.Session.SetObject("currentUser", User);
                return true;
            }

            return false;
        }

        public User getCurrentUser()
        {
            return _context.HttpContext.Session.GetObject<User>("currentUser");
        }

        public bool IsSignedIn()
        {
            var User = _context.HttpContext.Session.GetObject<User>("currentUser");
            return User != null;
        }
    }
}
