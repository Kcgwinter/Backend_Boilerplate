using API.Controllers;
using Backend_Boilerplate.DTOs;
using Backend_Boilerplate.Models;
using Backend_Boilerplate.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Boilerplate.Controllers
{
    public class TodoController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<TodoResponseDto>>> GetTodos(ITodoService service)
        {
            return Ok(await service.GetTodosAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Todo>> GetTodoById(ITodoService service, int id)
        {
            var todo = await service.GetTodoByIdAsync(id);
            return todo is null ? NotFound("Todo not found") : Ok(todo);
        }

    }
}
