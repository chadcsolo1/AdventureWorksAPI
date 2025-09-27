using AdventureWorksAPI.Models;
using AdventureWorksAPI.Models.DTOs;
using AdventureWorksAPI.Repositories.SalesRepository;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAPI.Controllers
{
    [Route("api/sales")]
    [ApiController]
    public class SalesController : Controller
    {
        private readonly ISalesRepository _salesRepo;
        public SalesController(ISalesRepository salesRepo)
        {
            _salesRepo = salesRepo;
        }
        
        [HttpGet("GetAllSalesOrderDetails")]
        public ActionResult<List<SalesOrderDetail>> GetAllSalesOrderDetails()
        {
            //Need to add services to call in the controller
            //Testing CICD Pipeline and need a commit and push
            var salesOrderDetails = _salesRepo.GetAllSalesOrderDetails();
            if (salesOrderDetails == null || !salesOrderDetails.Any())
            {
                return NotFound("No sales order details found.");
            }

            List<SalesOrderDetailDTO> salesOrderDetailsDTO = new List<SalesOrderDetailDTO>();

            foreach (var detail in salesOrderDetails)
            {
                salesOrderDetailsDTO.Add(new SalesOrderDetailDTO
                {
                    SalesOrderDetailsId = detail.SalesOrderDetailId,
                    OrderQuantity = detail.OrderQty,
                    UnitPrice = (int)detail.UnitPrice,
                    ProductId = detail.ProductId,
                });
            }
            return Ok(salesOrderDetailsDTO);
        }

        [HttpGet("GetAllSalesOrderHeaders")]
        public ActionResult<List<SalesOrderDetail>> GetAllSalesOrderHeader()
        {
            var salesOrderHeaders = _salesRepo.GetAllSalesOrderHeaders();
            if (salesOrderHeaders == null || !salesOrderHeaders.Any())
            {
                return NotFound("No sales order details found.");
            }

            List<SalesOrderHeaderDTO> salesOrderHeaderDTO = new List<SalesOrderHeaderDTO>();

            foreach (var header in salesOrderHeaders)
            {
                salesOrderHeaderDTO.Add(new SalesOrderHeaderDTO
                {
                    Id = header.SalesOrderId,
                    AccountNumber = header.AccountNumber,
                    Date = header.OrderDate,
                    Amount = (int)header.TotalDue,
                    Status = (int)header.Status,
                    TerritoryId = (int)header.TerritoryId,
                    SalesPersonId = (int)header.SalesPersonId,
                    ShipDate = (DateTime)header.ShipDate
                });
            }
            return Ok(salesOrderHeaderDTO);
        }

        [HttpGet("GetAllProductInventory")]
        public ActionResult<List<SalesOrderDetail>> GetProductInventory()
        {
            var prodInventory = _salesRepo.GetProductInventory();
            if (prodInventory == null || !prodInventory.Any())
            {
                return NotFound("No sales order details found.");
            }

            List<ProductInventoryDTO> salesOrderHeaderDTO = new List<ProductInventoryDTO>();

            foreach (var header in prodInventory)
            {
                salesOrderHeaderDTO.Add(new ProductInventoryDTO
                {
                    ProductId = header.ProductId,
                    LocationId = header.LocationId,
                    Shelf = header.Shelf,
                    Bin = header.Bin,
                    Quantity = header.Quantity
                });
            }
            return Ok(salesOrderHeaderDTO);
        }

        [HttpGet("GetAllSalesPersons")]
        public ActionResult<List<SalesPersonDTO>> GetAllSalesPersons()
        {
            var salesPersons = _salesRepo.GetAllSalesPersons();

            if (salesPersons == null || !salesPersons.Any())
            {
                return NotFound("No sales persons found.");
            }

            return Ok(salesPersons);
        }
    }
}
