namespace AdventureWorksAPI.Models.DTOs
{
    public class SalesOrderHeaderDTO
    {
        public int Id
        {
            get;
            set;
        }
        public string AccountNumber
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
        public int Amount
        {
            get;
            set;
        }
        public int Status
        {
            get;
            set;
        }

        public int TerritoryId
        {
            get;
            set;
        }

        public int SalesPersonId
        {
            get;
            set;
        }

        public DateTime ShipDate
        {
            get;
            set;
        }
    }
}
