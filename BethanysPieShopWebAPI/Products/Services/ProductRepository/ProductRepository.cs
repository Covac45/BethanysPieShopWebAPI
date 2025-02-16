using BethanysPieShopWebAPI.Products.Entities;
using BethanysPieShopWebAPI.Products.Database;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BethanysPieShopWebAPI.Products.Services.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext _dbContext;
        public ProductRepository(ProductContext productContext)
        {
            _dbContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _dbContext.Products
                .OrderBy(p => p.ProductId)
                .ToListAsync();
        }

        public async Task<Product?> GetProductAsync(int productId)
        {
            return await _dbContext.Products
                .Select(p => p)
                .FirstOrDefaultAsync(p => p.ProductId == productId);
        }

        public async Task<bool> CheckProductExistsByID(int productId)
        {
            if (await _dbContext.Products
                .Select(p => p)
                .FirstOrDefaultAsync(p => p.ProductId == productId)
                == null)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> CheckProductExistsByName(string productName)
        {
            if (await _dbContext.Products
                            .Select(p => p)
                            .FirstOrDefaultAsync(p => p.ProductName == productName)
                            == null)
            {
                return false;
            }
            return true;
        }

        public void DeleteProduct(Product productToDelete)
        {
            _dbContext.Remove(productToDelete);
        }


    }
}
