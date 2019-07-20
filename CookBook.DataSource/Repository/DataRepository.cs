using System;
using CookBook.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace CookBook.DataSource.Repository
{
    public class DataRepository : DbContext
    {
        public DataRepository(DbContextOptions<DataRepository> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
