using AdventureWorksAPI.Models.DTOs;
using AdventureWorksAPI.Repositories.ProductRepository;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepo _productRepo;
        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet("GetAllProducts")]
        public async Task<ActionResult<List<ProductDTO>>> GetAllProducts()
        {
            var products = await _productRepo.GetAllProductsAsync();

            if (products == null || !products.Any())
            {
                return NotFound("No products found.");
            }

            return Ok(products);
        }
    }
}
