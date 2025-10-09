using AdventureWorksAPI.Models;
using AdventureWorksAPI.Models.DTOs;

namespace AdventureWorksAPI.Services.WorkItemService
{
    public interface IWorkItemService
    {
        Task<List<WorkItemDto>> GetAllWorkItems();
        Task<WorkItemDto> GetWorkItemById(int id);
        Task<WorkItem> CreateWorkItem(WorkItemDto WorkItem);
        Task<bool> UpdateWorkItem(WorkItemDto workItemDto);
        Task<bool> DeleteWorkItem(int id);
    }
}
