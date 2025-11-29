using Backend_Boilerplate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Boilerplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        static List<Todo> todos =
            [
                new Todo { Id = 1, Name = "Todo 1", Description = "Description 1" },
                new Todo { Id = 2, Name = "Todo 2", Description = "Description 2" },
            ];

        [HttpGet]
        public async Task<ActionResult<List<Todo>>> GetTodos()
        {
            return await Task.FromResult(Ok(todos));
        }
    }
}
