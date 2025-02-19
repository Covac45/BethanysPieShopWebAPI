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
                ProductName = "Apple Pie",
                ProductCategory = "Fruit Pies",
                Tagline = "Our famous, number-one selling pie.",
                AtpTagline = "Increase Your Apple Pie Intake",
                CardTagline = "Our famous apple pies!",
                Description = "Indulge in the timeless delight of our Classic Apple Pie, a perfect balance of sweet and tart flavors encased in a golden, flaky crust. Each slice is brimming with tender, hand-picked apples coated in a luscious cinnamon-spiced filling, creating a warm and comforting taste in every bite. The buttery pastry, expertly baked to a crisp perfection, melts in your mouth while providing just the right amount of crunch. Perfect as a treat on its own or paired with a dollop of whipped cream or a scoop of vanilla ice cream, this pie is a celebration of tradition and exceptional flavor.",
                Ingredients = ["Apple", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["50%", "5%", "10%", "2%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "applepie.jpg",
                SmallImagePath = "applepiesmall.jpg",
                Price = 14.95
            };

            Product rhubarbPie = new Product
            {
                ProductName = "Rhubarb Pie",
                ProductCategory = "Fruit Pies",
                Tagline = "Tangy, sweet, and irresistibly rustic",
                AtpTagline = "A slice of rhubarb perfection",
                CardTagline = "My God, so sweet!",
                Description = "Savor the tangy-sweet harmony of our Rustic Rhubarb Pie, a celebration of bold, vibrant flavors. Each slice features tender chunks of rhubarb, their natural tartness perfectly balanced with just the right amount of sweetness, creating a filling that's rich and zesty. Enveloped in a golden, buttery crust with a crisp, flaky texture, this pie offers a rustic charm and satisfying crunch in every bite. Perfect on its own or paired with a scoop of creamy vanilla ice cream, our Rhubarb Pie is a delightful tribute to the simple pleasures of homestyle baking.",
                Ingredients = ["Rhubarb", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["50%", "5%", "10%", "2%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "rhubarbpie.jpg",
                SmallImagePath = "rhubarbpiesmall.jpg",
                Price = 14.95
            };

            Product strawberryPie = new Product
            {
                ProductName = "Strawberry Pie",
                ProductCategory = "Fruit Pies",
                Tagline = "Our delicious, summer sweet pie",
                AtpTagline = "Increase Your strawberry Pie Intake",
                CardTagline = "Our delicious strawberry pie!",
                Description = "Experience the vibrant taste of summer with our Fresh Strawberry Pie, a delightful burst of sweetness in every bite. Juicy, sun-ripened strawberries are nestled in a velvety glaze that highlights their natural flavor, creating a filling that's both luscious and refreshing. Encased in a buttery, golden crust with a light, flaky texture, this pie offers the perfect contrast of crispness and softness. Whether enjoyed as a refreshing dessert or a centerpiece for your next gathering, our Strawberry Pie is a bright and irresistible treat for all seasons.",
                Ingredients = ["Strawberry", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["50%", "5%", "5%", "2%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "strawberrypie.jpg",
                SmallImagePath = "strawberrypiesmall.jpg",
                Price = 14.95
            };
            
            Product peachPie = new Product
            {
                ProductName = "Peach Pie",
                ProductCategory = "Fruit Pies",
                Tagline = "Sweet, juicy, and golden",
                AtpTagline = "The essence of summer in every slice",
                CardTagline = "Sweet as peach!",
                Description = "Delight in the juicy sweetness of our Golden Peach Pie, a sun-kissed treat bursting with flavor. Made from ripe, handpicked peaches, the filling is naturally sweet, with a touch of warm spices to enhance its vibrant, fruity essence. Encased in a flaky, buttery crust baked to golden perfection, this pie delivers a delightful contrast of tender fruit and satisfying crispness. Perfect as a summer dessert or a comforting year-round indulgence, our Peach Pie is a taste of pure sunshine in every bite.",
                Ingredients = ["Peach", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["50%", "5%", "10%", "2%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "peachpie.jpg",
                SmallImagePath = "peachpiesmall.jpg",
                Price = 14.95
            };

            Product cherryPie = new Product
            {
                ProductName = "Cherry Pie",
                ProductCategory = "Fruit Pies",
                Tagline = "Sweet, tart, and utterly irresistible",
                AtpTagline = "Cherry pie at its finest",
                CardTagline = "A summer classic!",
                Description = "Indulge in the timeless allure of our Classic Cherry Pie, a perfect harmony of sweet and tart flavors. Packed with plump, juicy cherries in a luscious, glossy filling, every slice is a vibrant burst of fruity delight. The buttery, golden crust, baked to perfection, adds a satisfying crunch that complements the tender, rich filling. Whether served warm with a scoop of creamy vanilla ice cream or enjoyed on its own, our Cherry Pie is a dessert that brings pure comfort and joy to every occasion.",
                Ingredients = ["Cherry", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["30%", "8%", "14%", "3%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "cherrypie.jpg",
                SmallImagePath = "cherrypiesmall.jpg",
                Price = 14.95
            };

            Product blueberryCheesecake = new Product
            {
                ProductName = "Blueberry Cheesecake",
                ProductCategory = "Cheesecakes",
                Tagline = "Smooth, sweet, and bursting with flavour",
                AtpTagline = "A piece of blueberry bliss",
                CardTagline = "You'll love it!",
                Description = "Delight in the creamy, decadent flavors of our Blueberry Cheesecake, a perfect blend of rich, velvety cream cheese and the sweet-tart brightness of fresh blueberries. The smooth filling is complemented by a luscious layer of blueberry compote, creating a delightful contrast of textures and flavors. Resting on a buttery, golden graham cracker crust, this cheesecake offers an unforgettable taste of indulgence. Whether served as a centerpiece for a special occasion or as a simple treat, it’s a dessert that never fails to impress.",
                Ingredients = ["Blueberry", "Cream cheese", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["30%", "20%", "5%", "5%", "5%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "blueberrycheesecake.jpg",
                SmallImagePath = "blueberrycheesecakesmall.jpg",
                Price = 14.95
            };

            Product strawberryCheesecake = new Product
            {
                ProductName = "Strawberry Cheesecake",
                ProductCategory = "Cheesecakes",
                Tagline = "Rich, fruity, and utterly irresistible",
                AtpTagline = "A strawberry dream in every bite",
                CardTagline = "You'll love it!",
                Description = "Indulge in the luscious harmony of our Strawberry Bliss Cheesecake, a creamy delight topped with the vibrant sweetness of ripe strawberries. The velvety, tangy cream cheese filling pairs perfectly with the bright, juicy fruit, creating a flavor combination that's both refreshing and indulgent. Set atop a buttery graham cracker crust, each slice is a celebration of texture and taste. Perfect for any occasion, this cheesecake is as stunning as it is delicious.",
                Ingredients = ["Strawberry", "Cream cheese", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["30%", "20%", "5%", "5%", "5%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "strawberrycheesecake.jpg",
                SmallImagePath = "strawberrycheesecakesmall.jpg",
                Price = 14.95
            };

            Product cheesecake = new Product
            {
                ProductName = "Cheesecake",
                ProductCategory = "Cheesecakes",
                Tagline = "Pure, creamy, and irresistibly classic",
                AtpTagline = "Cheesecake at its finest",
                CardTagline = "You'll love it!",
                Description = "Experience the creamy perfection of our classic Cheesecake, a timeless dessert crafted with care. Each bite is luxuriously smooth and rich, with a subtle tangy sweetness that perfectly balances the velvety cream cheese filling. Nestled on a buttery, golden graham cracker crust, this cheesecake offers a harmonious blend of textures and flavors. Simple yet elegant, it’s perfect on its own or as a canvas for your favorite toppings, from fresh berries to a drizzle of caramel.",
                Ingredients = ["Cream cheese", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["40%", "8%", "14%", "8%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "cheesecake.jpg",
                SmallImagePath = "cheesecakesmall.jpg",
                Price = 14.95
            };

            Product christmasApplePie = new Product
            {
                ProductName = "Christmas Apple Pie",
                ProductCategory = "Seasonal Pies",
                Tagline = "The magic of Christmas in every pie!",
                AtpTagline = "A holiday hug in every slice",
                CardTagline = "Happy holidays with this pie!",
                Description = "Embrace the warmth of the season with our Christmas Apple Pie, a festive twist on a classic favorite. Filled with tender, cinnamon-kissed apples and infused with hints of nutmeg, cloves, and a touch of orange zest, this pie captures the cozy, nostalgic flavors of the holidays. Encased in a beautifully golden, buttery crust, every slice offers a perfect balance of sweetness and spice. Whether paired with a dollop of whipped cream or a scoop of spiced ice cream, this pie is the perfect centerpiece for your Christmas celebrations.",
                Ingredients = ["Apple", "Sugar", "Eggs", "Nuts", "Nutmeg", "Cinnamon", "Cloves", "Orange"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Mabye", "Mabye", "Mabye", "Mabye", "Mabye"],
                IngredientPct = ["50%", "10%", "10%", "<0.1%", "<0.1%", "<0.1%", "<0.1%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "christmasapplepie.jpg",
                SmallImagePath = "christmasapplepiesmall.jpg",
                Price = 14.95
            };

            Product cranberryePie = new Product
            {
                ProductName = "Cranberry Pie",
                ProductCategory = "Seasonal Pies",
                Tagline = "Bold, bright, and bursting with flavor",
                AtpTagline = "A cranberry delight in every bite",
                CardTagline = "A christmas favourite!",
                Description = "Celebrate the bold and tangy flavor of our Zesty Cranberry Pie, a perfect blend of tart cranberries and just the right touch of sweetness. Each slice bursts with the vibrant, ruby-red filling, accented by hints of citrus and warm spices for a uniquely festive twist. Encased in a golden, buttery crust that’s crisp yet tender, this pie offers a delightful contrast of textures and a flavor profile that’s both refreshing and indulgent. Perfect for the holidays or any time you crave a lively, fruit-forward dessert, our Cranberry Pie is a treat that brightens every occasion.",
                Ingredients = ["Cranberry", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Mabye"],
                IngredientPct = ["50%", "5%", "10%", "2%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "cranberrypie.jpg",
                SmallImagePath = "cranberrypiesmall.jpg",
                Price = 14.95
            };

            Product pumpkinPie = new Product
            {
                ProductName = "Pumpkin Pie",
                ProductCategory = "Seasonal Pies",
                Tagline = "The taste of autumn in every slice",
                AtpTagline = "A cranberry delight in every bite",
                CardTagline = "Our Halloween favourite!",
                Description = "Savor the essence of autumn with our Classic Pumpkin Pie, a creamy and spiced delight that warms the soul. Made with velvety pumpkin puree and a medley of cinnamon, nutmeg, ginger, and cloves, each bite is a perfect balance of sweet and earthy flavors. Nestled in a tender, buttery crust baked to golden perfection, this pie is a seasonal classic that brings comfort and joy to every gathering. Whether topped with a dollop of whipped cream or enjoyed on its own, our Pumpkin Pie is a timeless treat for fall and beyond.",
                Ingredients = ["Pumpkin", "Sugar", "Eggs", "Milk", "Nuts"],
                IngredientRisk = ["Yes", "Yes", "Yes", "Yes", "Yes"],
                IngredientPct = ["30%", "5%", "10%", "2%", "<0.1%"],
                ProductQuote = "My recipes have been in our family for generations. We hope you enjoy our pies! - Bethany",
                ImagePath = "pumpkinpie.jpg",
                SmallImagePath = "pumpkinpiesmall.jpg",
                Price = 14.95
            };


            using (var context = GetContext())
            {
                context.Products.AddRange(
                    applePie,
                    rhubarbPie,
                    strawberryPie,
                    peachPie,
                    cherryPie,
                    blueberryCheesecake,
                    strawberryCheesecake,
                    cheesecake,
                    christmasApplePie,
                    cranberryePie,
                    pumpkinPie
                );

                context.SaveChanges();
            }
        }
    }
}
