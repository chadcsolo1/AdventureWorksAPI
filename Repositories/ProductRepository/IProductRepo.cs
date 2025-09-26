using AdventureWorksAPI.Models.DTOs;

namespace AdventureWorksAPI.Repositories.ProductRepository
{
    public interface IProductRepo
    {
        Task<List<ProductDTO>> GetAllProductsAsync();
    }
}
