using AdventureWorksAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksAPI.Repositories.TaskRepository
{
    public class WorkItemRepository : IWorkItemRepository
    {
        private readonly AdventureWorks2017Context _context;
        private WorkItem DefaultWorkItem => new WorkItem
        {
            WorkItemId = 0,
            Title = "Default Title",
            Description = "Default Description",
            DueDate = DateTime.MinValue,
            Priority = 0,
            CreatedAt = DateTime.MinValue,
            CreatedBy = "System"
        };
        public WorkItemRepository(AdventureWorks2017Context context)
        {
            _context = context;
        }
        public async Task<WorkItem> CreateTask(WorkItem workItem)
        {
            WorkItem newWorkItem = new WorkItem
            {
                Title = workItem.Title,
                Description = workItem.Description,
                DueDate = workItem.DueDate,
                Priority = workItem.Priority,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = workItem.CreatedBy
            };

            await _context.WorkItems.AddAsync(newWorkItem);
            _context.SaveChanges();

            return newWorkItem;
        }

        public async Task<bool> DeleteTask(int id)
        {
            var workItemToBeDeleted = await _context.WorkItems.FindAsync(id);

            if (workItemToBeDeleted == null)
            {
                throw new ArgumentException("Work item not found");
            }

            await _context.WorkItems.AddAsync(workItemToBeDeleted);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<WorkItem>> GetAllTask()
        {
            return await _context.WorkItems.ToListAsync();
        }

        public async Task<WorkItem> GetWorkItemById(int id)
        {
            return await _context.WorkItems.FindAsync(id) ?? DefaultWorkItem;
        }

        public async Task<WorkItem> GetWorkItemByName(string name)
        {
            return await _context.WorkItems.FirstOrDefaultAsync(w => w.Title == name) ?? DefaultWorkItem;
        }

        public async Task<WorkItem> UpdateTask(WorkItem workItem)
        {
            var workItemToUpdate = _context.WorkItems.Find(workItem.WorkItemId);

            if (workItemToUpdate == null) 
            {
                throw new ArgumentException("Work item not found");
            }

            workItemToUpdate.Title = workItem.Title;
            workItemToUpdate.Description = workItem.Description;
            workItemToUpdate.Priority = workItem.Priority;
         
            await _context.WorkItems.AddAsync(workItemToUpdate);
            await _context.SaveChangesAsync();

            return workItemToUpdate;
        }
    }
}
