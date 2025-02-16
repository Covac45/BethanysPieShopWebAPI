using BethanysPieShopWebAPI.Auth.Database;
using BethanysPieShopWebAPI.Auth.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTests.Auth.TestHelpers
{
    public class AuthTestDatabaseSetup
    {
        public static UserContext GetContext()
        {
            var builder = new DbContextOptionsBuilder<UserContext>();

            var context = new UserContext(builder.Options);

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

            User user1 = new User("abc", "123", "John", "Doe", "Client");
            User user2 = new User("Bethany@BPS.com", "456", "Bethany", "Doe", "Admin");

            using (var context = GetContext())
            {
                context.Users.AddRange(
                    user1,
                    user2
                );

                context.SaveChanges();
            }
        }
    }
}
