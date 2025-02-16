using AutoMapper;
using BethanysPieShopWebAPI.Products.Entities;
using BethanysPieShopWebAPI.Products.Models.ProductDTOs;

namespace BethanysPieShopWebAPI.Products.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductForCreationDto, Product>();
            CreateMap<ProductForUpdateDto, Product>();
            CreateMap<Product, ProductForUpdateDto>();

        }
    }
}
