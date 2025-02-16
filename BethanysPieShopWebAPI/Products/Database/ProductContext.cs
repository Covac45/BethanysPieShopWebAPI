using BethanysPieShopWebAPI.Products.Entities;
using BethanysPieShopWebAPI.Products.Models;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopWebAPI.Products.Database
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(){}

        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(
                    $"Server=(localdb)\\mssqllocaldb; Database=BPS_ProductsDB; Trusted_Connection=True")
                    .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
        }

    }
}
