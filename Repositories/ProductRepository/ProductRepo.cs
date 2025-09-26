using AdventureWorksAPI.Models;
using AdventureWorksAPI.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksAPI.Repositories.ProductRepository
{
    public class ProductRepo : IProductRepo
    {
        private readonly AdventureWorks2017Context _context;
        public ProductRepo(AdventureWorks2017Context context)
        {
            _context = context;
        }
        public async Task<List<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _context.Products.ToListAsync();

            if (products == null || !products.Any())
            {
                throw new Exception("No products found.");
            }

            List<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var product in products)
            {
                productDTOs.Add(new ProductDTO
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    ProductNumber = product.ProductNumber,
                    SafteyStockLevel = product.SafetyStockLevel,
                    ReorderPoint = product.ReorderPoint,
                    StandardCost = (int)product.StandardCost,
                    ListPrice = (int)product.ListPrice
                });
            }

            return productDTOs;
        }
    }
}
