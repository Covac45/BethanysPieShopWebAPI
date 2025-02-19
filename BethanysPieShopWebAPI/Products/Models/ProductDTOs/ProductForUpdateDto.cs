using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopWebAPI.Products.Models.ProductDTOs
{
    public class ProductForUpdateDto
    {
        
        //public int ProductId { get; set; }
        
        [Required(ErrorMessage = "A name is required.")]
        [MaxLength(100)]
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string? Tagline { get; set; }
        public string? AtpTagline { get; set; }
        public string? CardTagline { get; set; }
        public string? Description { get; set; }
        
        [Required(ErrorMessage = "A list of ingredients is required.")]
        public IEnumerable<string> Ingredients { get; set; }

        [Required(ErrorMessage = "A list of ingredient risk is required.")]
        public IEnumerable<string> IngredientRisk { get; set; }

        [Required(ErrorMessage = "A list of ingredient percentages is required.")]
        public IEnumerable<string> IngredientPct { get; set; }
        public string? ProductQuote { get; set; }
        public string? ImagePath { get; set; }
        public string? SmallImagePath { get; set; }
        public double Price { get; set; }

    }
}
