using AdventureWorksAPI.Models;

namespace AdventureWorksAPI.Services.WorkItemService
{
    public interface IWorkItemService
    {
        Task<List<WorkItem>> GetAllWorkItems();
        Task<WorkItem> GetWorkItemById(int id);
        Task<List<WorkItem>> AddWorkItem(WorkItem newWorkItem);
        Task<WorkItem> UpdateWorkItem(WorkItem updatedWorkItem);
        Task<List<WorkItem>> DeleteWorkItem(int id);
    }
}
