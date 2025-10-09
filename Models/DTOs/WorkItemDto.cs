namespace AdventureWorksAPI.Models.DTOs
{
    public class WorkItemDto
    {
        public int WorkItemId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        } = string.Empty;

        public string Description
        {
            get;
            set;
        } = string.Empty;
        public DateTime DueDate
        {
            get;
            set;
        }
        public int Priority
        {
            get;
            set;
        }
    }
}
