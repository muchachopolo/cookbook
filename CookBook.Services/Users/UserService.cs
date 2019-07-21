using System;
using System.Threading.Tasks;
using CookBook.DataSource.Repository;
using CookBook.Entities.Users;

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
    }
}
