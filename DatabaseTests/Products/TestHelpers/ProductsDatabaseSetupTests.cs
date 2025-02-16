using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTests.Products.TestHelpers
{
    [TestClass]
    public class ProductsDatabaseSetupTests : ProductsTestDatabaseSetup
    {
        [TestMethod]

        public void SeedDatbaseTest()
        {
            var context = GetContext();
            ResetDatbase();
            SeedDatbase();

            var products = context.Products.Select(p => p.ProductId).ToList();
            Console.WriteLine();

            Assert.AreNotEqual(context.Products.Select(p => p.ProductId).ToList().Count(), 0);
        }

    }
}
