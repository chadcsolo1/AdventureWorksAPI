using AdventureWorksAPI.Models;
using AdventureWorksAPI.Models.DTOs;

namespace AdventureWorksAPI.Repositories.SalesRepository
{
    public interface ISalesRepository
    {
        List<SalesOrderDetail> GetAllSalesOrderDetails();
        List<SalesOrderHeader> GetAllSalesOrderHeaders();

        List<ProductInventory> GetProductInventory();
        List<SalesPersonDTO> GetAllSalesPersons();
    }
}
