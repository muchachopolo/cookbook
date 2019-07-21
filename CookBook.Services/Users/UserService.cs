using System;
using System.Linq;
using System.Threading.Tasks;
using CookBook.DataSource.Repository;
using CookBook.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Services.Users
{
    public class UserService
    {
        private readonly DataRepository _repository;

        public UserService(DataRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> CreateUser(User user)
        {
            await _repository.Users.AddAsync(user);
            await _repository.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetUserAsync(int? id)
        {
            var User = await _repository.Users.Select(user => new User
            {
                Id = user.Id,
                Email = user.Email,
                active = user.active,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Birth = user.Birth
            }).FirstOrDefaultAsync(user => user.Id == id);
            return User;
        }
    }
}
