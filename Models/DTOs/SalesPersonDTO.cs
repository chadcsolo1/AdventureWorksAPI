namespace AdventureWorksAPI.Models.DTOs
{
    public class SalesPersonDTO
    {
        public int Id
        {
            get;
            set;
        }

        public int TerritoryId
        {
            get;
            set;
        }

        public int SalesQuota
        {
            get;
            set;
        }
        public int Bonus
        {
            get;
            set;
        }
        public int SalesYTD
        {
            get;
            set;
        }

        public int SalesLastYear
        {
            get;
            set;
        }   
    }
}
