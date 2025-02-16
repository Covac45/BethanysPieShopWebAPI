namespace BethanysPieShopWebAPI.Products.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string? Tagline { get; set; }
        public string? Description { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
        public IEnumerable<string> IngredientRisk { get; set; }
        public IEnumerable<string> IngredientPct { get; set; }
        public string? ProductQuote { get; set; }
    }
}
