using AutoMapper;
using Azure;
using Azure.Messaging;
using BethanysPieShopWebAPI.Auth.Entities;
using BethanysPieShopWebAPI.Products.Database;
using BethanysPieShopWebAPI.Products.Entities;
using BethanysPieShopWebAPI.Products.Models.ProductDTOs;
using BethanysPieShopWebAPI.Products.Services.ProductRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BethanysPieShopWebAPI.Products.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly ProductContext _dbContext;
        private readonly User _user;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(ProductContext dbContext, IProductRepository productRepository, IMapper mapper)
        {
            _dbContext = dbContext;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var products = await _productRepository.GetProductsAsync();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(products));
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int productId)
        {
            if (!await _productRepository.CheckProductExistsByID(productId))
            {
                return NotFound();
            }

            var productToReturn = await _productRepository.GetProductAsync(productId);

            return Ok(_mapper.Map<ProductDto>(productToReturn));
        }
        
        [HttpPost]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<ActionResult<ProductForCreationDto>> CreateProduct(ProductForCreationDto productDtoForCreation) {

            //Checking against productID is not sensible here...
            if (await _productRepository.CheckProductExistsByName(productDtoForCreation.ProductName))
            {
                return Conflict();
            }

            var productToCreate = _mapper.Map<Product>(productDtoForCreation);
            await _dbContext.AddAsync(productToCreate);
            await _dbContext.SaveChangesAsync();

            return Created();
        }

        [HttpPut("{productId}")]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<ActionResult> UpdateProduct(int productId, ProductForUpdateDto productDtoForUpdate)
        {
            if (!await _productRepository.CheckProductExistsByID(productId))
            {
                return NotFound();
            }

            var productToUpdate = await _dbContext.Products.Select(p => p).FirstOrDefaultAsync(p => p.ProductId == productId);

            productToUpdate = _mapper.Map(productDtoForUpdate, productToUpdate);

            await _dbContext.SaveChangesAsync();

            return Ok(productToUpdate);
        }

        //NOT WORKING
        /*[HttpPatch("{productId}")]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<ActionResult> PartiallyUpdateProduct(int productId, JsonPatchDocument<ProductForUpdateDto> patchDocument)
        {
            if (!await _productRepository.CheckProductExistsByID(productId))
            {
                return NotFound();
            }

            var productToUpdate = await _dbContext.Products.Select(p => p).FirstOrDefaultAsync(p => p.ProductId == productId);

            var productToPatch = _mapper.Map<ProductForUpdateDto>(productToUpdate);

            patchDocument.ApplyTo(productToPatch);

            //Model Validaiton logic
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!TryValidateModel(productToPatch))
            {
                return BadRequest(ModelState);
            }

            //Map DTO to Product and save changes to database.
            _mapper.Map(productToPatch, productToUpdate);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }*/

        [HttpDelete("{productId}")]
        [Authorize(Policy = "MustBeAdmin")]
        public async Task<ActionResult> DeleteProduct(int productId)
        {
            if (!await _productRepository.CheckProductExistsByID(productId))
            {
                return NotFound();
            }

            var productToDelete = await _dbContext.Products.Select(p => p).FirstOrDefaultAsync(p => p.ProductId == productId);

            _productRepository.DeleteProduct(productToDelete);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }


    }
}
