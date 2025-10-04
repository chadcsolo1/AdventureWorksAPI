using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksAPI.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TaskController : Controller
    {
        [HttpGet("GetAllTask")]
        public IActionResult GetAllTask()
        {
            return Ok();
        }

        [HttpGet("GetTaskById")]
        public IActionResult GetTaskById()
        {
            return Ok();
        }

        [HttpGet("GetTaskByName")]
        public IActionResult GetTaskByName()
        {
            return Ok();
        }

        [HttpPost("CreateTask")]
        public IActionResult CreateTask()
        {
            return Ok();
        }

        [HttpPut("UpdateTask")]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpPut("DeleteTask")]
        public IActionResult DeleteTask()
        {
            return Ok();
        }
    }
}
