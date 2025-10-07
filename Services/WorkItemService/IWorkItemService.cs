using AdventureWorksAPI.Models;

namespace AdventureWorksAPI.Services.WorkItemService
{
    public interface IWorkItemService
    {
        Task<List<WorkItem>> GetAllWorkItems();
        Task<WorkItem> GetWorkItemById(int id);
        Task<WorkItem> AddWorkItem(WorkItem newWorkItem);
        Task<WorkItem> UpdateWorkItem(WorkItem updatedWorkItem);
        Task<bool> DeleteWorkItem(int id);
    }
}
