using AdventureWorksAPI.Models;
using AdventureWorksAPI.Models.DTOs;
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
        public async Task<WorkItem> CreateWorkItem(WorkItemDto WorkItemDto)
        {
            WorkItem newWorkItem = new WorkItem();
            newWorkItem.Title = WorkItemDto.Title;
            newWorkItem.Description = WorkItemDto.Description;
            newWorkItem.DueDate = WorkItemDto.DueDate;
            newWorkItem.Priority = WorkItemDto.Priority;
            newWorkItem.CreatedAt = DateTime.Now;
            newWorkItem.CreatedBy = "AuthenticatedUser";

            await _workItemRepo.CreateTask(newWorkItem);

            return newWorkItem;
        }

        public async Task<bool> DeleteWorkItem(int id)
        {
            return await _workItemRepo.DeleteTask(id);
        }

        public async Task<List<WorkItemDto>> GetAllWorkItems()
        {
            var workItems = await _workItemRepo.GetAllTask();

            if (workItems == null || !workItems.Any())
            {
                return new List<WorkItemDto>();
            }

            var workItemDtos = workItems.Select(wi => new WorkItemDto
            {
                 WorkItemId = wi.WorkItemId,
                 Title = wi.Title,
                 Description = wi.Description,
                 DueDate = (DateTime)wi.DueDate,
                 Priority = (int)wi.Priority
            }).ToList();

            return workItemDtos;
            
        }

        public async Task<WorkItemDto> GetWorkItemById(int id)
        {
            WorkItemDto workItemDto = new WorkItemDto();

            var workItem =  _workItemRepo.GetWorkItemById(id);

            if (workItem == null)
            {
                return workItemDto;
            }

            workItemDto.WorkItemId = workItem.Result.WorkItemId;
            workItemDto.Title = workItem.Result.Title;
            workItemDto.Description = workItem.Result.Description;
            workItemDto.DueDate = (DateTime)workItem.Result.DueDate;
            workItemDto.Priority = (int)workItem.Result.Priority;

            return workItemDto;
        }

        public async Task<bool> UpdateWorkItem(WorkItemDto workItemDto)
        {

            var workItem = await _workItemRepo.GetWorkItemById(workItemDto.WorkItemId);

            if (workItem == null)
            {
                return false;
            }

            workItem.Title = workItemDto.Title;
            workItem.Description = workItemDto.Description;
            workItem.DueDate = workItemDto.DueDate;
            workItem.Priority = workItemDto.Priority;

            await _workItemRepo.UpdateTask(workItem);

            return true;
        }
    }
}
