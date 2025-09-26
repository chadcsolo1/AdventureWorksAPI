namespace AdventureWorksAPI.Models.DTOs
{
    public class SalesOrderDetailDTO
    {
        public int SalesOrderDetailsId
        {
            get;
            set;
        }

        public int OrderQuantity
        {
            get;
            set;
        }
        public int UnitPrice
        {
            get;
            set;
        }

        public int ProductId
        {
            get;
            set;
        }
    }
}
