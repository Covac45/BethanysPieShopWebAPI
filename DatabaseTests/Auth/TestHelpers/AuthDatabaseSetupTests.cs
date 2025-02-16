using DatabaseTests.Auth.TestHelpers;

namespace DatabaseTests.Auth.Testhelpers
{
    [TestClass]
    public class DatabaseSetupTests : AuthTestDatabaseSetup
    {
        [TestMethod]

        public void SeedDatbaseTest()
        {
            var context = GetContext();
            ResetDatbase();
            SeedDatbase();

            var products = context.Users.Select(u => u).ToList();
            Console.WriteLine();

            Assert.AreNotEqual(context.Users.Select(u => u).ToList().Count(), 0);
        }

    }
}
