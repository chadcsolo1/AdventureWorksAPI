namespace AdventureWorksAPI.Models.DTOs
{
    public class ProductDTO
    {
        public int ProductId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        } = string.Empty;
        public string ProductNumber
        {
            get;
            set;
        } = string.Empty;

        public int SafteyStockLevel
        {
            get;
            set;
        }
        public int ReorderPoint
        {
            get;
            set;
        }
        public int StandardCost
        {
            get;
            set;
        }
        public int ListPrice
        {
            get;
            set;
        }
    }
}
