using Microsoft.EntityFrameworkCore;
using TapAndPayWebApi.Models;

namespace TapAndPayWebApi.Data.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}