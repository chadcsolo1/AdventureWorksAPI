using AdventureWorksAPI.Models;
using WorkItem = AdventureWorksAPI.Models.WorkItem;

namespace AdventureWorksAPI.Repositories.TaskRepository
{
    public interface IWorkItemRepository
    {
        Task<WorkItem> GetAllTask();
        Task<WorkItem> GetWorkItemById(int id);
        Task<WorkItem> GetWorkItemByName(string name);
        Task<WorkItem> CreateTask(WorkItem workItem);
        Task<WorkItem> UpdateTask(WorkItem workItem);
        Task<bool> DeleteTask(int id);
    }
}
