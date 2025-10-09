using AdventureWorksAPI.Models.DTOs;
using AdventureWorksAPI.Services.WorkItemService;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAPI.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class WorkItemController : Controller
    {
        private readonly IWorkItemService _workItemService;
        public WorkItemController(IWorkItemService workItemService)
        {
            _workItemService = workItemService;
        }


        [HttpGet("GetAllTask")]
        public async Task<IActionResult> GetAllTask()
        {
            return Ok(await _workItemService.GetAllWorkItems());
        }

        [HttpGet("GetTaskById")]
        public async Task<IActionResult> GetTaskById([FromBody] int id)
        {
            return Ok(await _workItemService.GetWorkItemById(id));
        }

        [HttpGet("GetTaskByName")]
        public async Task<IActionResult> GetTaskByName([FromBody] string name)
        {
            return Ok();
        }

        [HttpPost("CreateTask")]
        public async Task<IActionResult> CreateTask([FromBody] WorkItemDto workItemDto)
        {
            return Ok(await _workItemService.CreateWorkItem(workItemDto));
        }

        [HttpPut("UpdateTask")]
        public async Task<IActionResult> UpdateTask([FromBody] WorkItemDto workItemDto)
        {
            return Ok(await _workItemService.UpdateWorkItem(workItemDto));
        }

        [HttpPut("DeleteTask")]
        public async Task<IActionResult> DeleteTask([FromBody] int id)
        {
            return Ok(await _workItemService.DeleteWorkItem(id));
        }
    }
}
