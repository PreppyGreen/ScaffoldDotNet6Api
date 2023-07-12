using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScaffoldDotNet6Api.Controllers.Models;

namespace ScaffoldDotNet6Api.Controllers
{
    [Route("api/[controller]")]
    public partial class TodoController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(TodoDto), 200)]
        public async Task<IActionResult> PostToDoAsync([FromBody] CreateTodoRequest request)
        {
            var mockTodo = new TodoDto
            {
                TodoId = System.Guid.NewGuid().ToString(),
                Title = request.Title,
                Description = request.Description,
                CreatedDt = System.DateTime.UtcNow
            };

            return new OkObjectResult(mockTodo);
        }
    }
}