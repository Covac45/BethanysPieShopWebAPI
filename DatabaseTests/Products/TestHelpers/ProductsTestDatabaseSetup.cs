using BethanysPieShopWebAPI.Products.Database;
using BethanysPieShopWebAPI.Products.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTests.Products.TestHelpers
{
    public class ProductsTestDatabaseSetup
    {
        public static ProductContext GetContext()
        {
            var builder = new DbContextOptionsBuilder<ProductContext>();

            var context = new ProductContext(builder.Options);

            return context;
        }


        public static void ResetDatbase()
        {
            using var context = GetContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

        }

        public static void SeedDatbase()
        {
            ResetDatbase();

            Product applePie = new Product
            {
                ProductName = "Applie Pie",
                ProductCategory = "Pies",
                Tagline = "Our famous, number-one selling pie.",
                Description = "Indulge in the timeless delight of our Classic Apple Pie, a perfect balance of sweet and tart flavors encased in a golden, flaky crust. Each slice is brimming with tender, hand-picked apples coated in a luscious cinnamon-spiced filling, creating a warm and comforting taste in every bite. The buttery pastry, expertly baked to a crisp perfection, melts in your mouth while providing just the right amount of crunch. Perfect as a treat on its own or paired with a dollop of whipped cream or a scoop of vanilla ice cream, this pie is a celebration of tradition and exceptional flavor.",
                Ingredients = ["Apple", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["50%", "5%", "10%", "2%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany\r\n\r\n"
            };

            using (var context = GetContext())
            {
                context.Products.AddRange(
                    applePie
                );

                context.SaveChanges();
            }
        }
    }
}
