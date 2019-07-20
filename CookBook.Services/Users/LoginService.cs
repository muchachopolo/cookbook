using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBook.DataSource.Repository;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Services.Users
{
    public class LoginService
    {
        private readonly DataRepository _repository;

        public LoginService(DataRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> LogginAttempt(string username, string password)
        {
            var User = await _repository.Users
                .Where(
                    user => user.Email == username && user.Password == password
                ).FirstOrDefaultAsync();
            return User != null;
        }
    }
}
