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
        public Task<List<WorkItem>> AddWorkItem(WorkItem newWorkItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkItem>> DeleteWorkItem(int id)
        {
            throw new NotImplementedException();
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
