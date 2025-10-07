using AdventureWorksAPI.Models;
using AdventureWorksAPI.Repositories.TaskRepository;

namespace AdventureWorksAPI.Services.WorkItemService
{
    public class WorkItemService : IWorkItemService
    {
        private readonly IWorkItemRepository _workItemRepo;
        public WorkItemService(IWorkItemRepository workItemRepo)
        {
            _workItemRepo = workItemRepo;
        }
        public async Task<WorkItem> AddWorkItem(WorkItem newWorkItem)
        {
            return await _workItemRepo.CreateTask(newWorkItem);
        }

        public async Task<bool> DeleteWorkItem(int id)
        {
            return await _workItemRepo.DeleteTask(id);
        }

        public Task<List<WorkItem>> GetAllWorkItems()
        {
            throw new NotImplementedException();
        }

        public Task<WorkItem> GetWorkItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WorkItem> UpdateWorkItem(WorkItem updatedWorkItem)
        {
            throw new NotImplementedException();
        }
    }
}
