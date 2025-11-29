using Backend_Boilerplate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Boilerplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetTodos()
        {
            var todos = new[]
            {
                new Todo { Id = 1, Name = "Todo 1", Description = "Description 1" },
                new Todo { Id = 2, Name = "Todo 2", Description = "Description 2" },

            };

            return Ok(todos);
        }
    }
}
