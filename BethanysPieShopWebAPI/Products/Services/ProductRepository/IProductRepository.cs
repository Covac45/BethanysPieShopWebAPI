using BethanysPieShopWebAPI.Products.Entities;

namespace BethanysPieShopWebAPI.Products.Services.ProductRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product?> GetProductAsync(int productId);

        void DeleteProduct(Product product);

        Task<bool> CheckProductExistsByID(int productId);

        Task<bool> CheckProductExistsByName(string productName);

    }
}
