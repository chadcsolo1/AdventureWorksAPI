namespace AdventureWorksAPI.Models
{
    public class WorkItem
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
        public DateTime CreatedAt
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        } = string.Empty;
    }
}
