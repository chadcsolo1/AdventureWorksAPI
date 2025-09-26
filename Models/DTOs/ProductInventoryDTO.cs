namespace AdventureWorksAPI.Models.DTOs
{
    public class ProductInventoryDTO
    {
        public int ProductId
        {
            get;
            set;
        }

        public int LocationId
        {
            get;
            set;
        }

        public string Shelf
        {
            get;
            set;
        } = string.Empty;
        public int Bin
        {
            get;
            set;
        }
        public int Quantity
        {
            get;
            set;
        }
    }
}
