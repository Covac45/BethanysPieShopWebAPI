using BethanysPieShopWebAPI.Auth.Entities;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopWebAPI.Auth.Database
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext() { }

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(
                    $"Server=(localdb)\\mssqllocaldb; Database=BPS_UserDB; Trusted_Connection=True")
                    .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.UserId);
        }
    }
}
