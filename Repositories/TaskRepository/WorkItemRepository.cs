using AdventureWorksAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksAPI.Repositories.TaskRepository
{
    public class WorkItemRepository : IWorkItemRepository
    {
        private readonly AdventureWorks2017Context _context;
        public WorkItemRepository(AdventureWorks2017Context context)
        {
            _context = context;
        }
        public Task<WorkItem> CreateTask(WorkItem workItem)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<WorkItem>> GetAllTask()
        {
            return await _context.WorkItems.ToListAsync();
        }

        public Task<WorkItem> GetWorkItemById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WorkItem> GetWorkItemByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<WorkItem> UpdateTask(WorkItem workItem)
        {
            throw new NotImplementedException();
        }
    }
}
