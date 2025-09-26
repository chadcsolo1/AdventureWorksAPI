using AdventureWorksAPI.Models;
using AdventureWorksAPI.Models.DTOs;

namespace AdventureWorksAPI.Repositories.SalesRepository
{
    public class SalesRepository : ISalesRepository
    {
        private readonly AdventureWorks2017Context _context;
        public SalesRepository(AdventureWorks2017Context context)
        {
            _context = context;
        }
        public List<SalesOrderDetail> GetAllSalesOrderDetails()
        {
            return _context.SalesOrderDetails.Take(10).ToList();
        }

        public List<SalesOrderHeader> GetAllSalesOrderHeaders()
        {
            return _context.SalesOrderHeaders.Take(300).Where(u => u.SalesPersonId != null).ToList();
        }

        public List<SalesPersonDTO> GetAllSalesPersons()
        {
            var salesPersons = _context.SalesPeople.Where(r => r.BusinessEntityId != null && r.TerritoryId != null).ToList();

            List<SalesPersonDTO> salesPersonDTOs = new List<SalesPersonDTO>();

            foreach (var person in salesPersons)
            {
                salesPersonDTOs.Add(new SalesPersonDTO
                {
                    Id = person.BusinessEntityId,
                    TerritoryId = (int)person.TerritoryId,
                    SalesQuota = (int)person.SalesQuota,
                    Bonus = (int)person.Bonus,
                    SalesYTD = (int)person.SalesYtd,
                    SalesLastYear = (int)person.SalesLastYear
                });
            }

            return salesPersonDTOs;
        }

        public List<ProductInventory> GetProductInventory()
        {
            return _context.ProductInventories.Take(50).ToList();
        }
    }
}
