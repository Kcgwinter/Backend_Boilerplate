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

        [HttpPost]
        public async Task<ActionResult> CreateTodo(ITodoService service, TodoRequestDto todo)
        {
            var res = await service.CreateTodoAsync(todo);
            return Ok(res);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTodo(ITodoService service, TodoRequestDto todo)
        {
            var res = await service.UpdateTodoAsync(todo);
            return res ? Ok() : NotFound("Todo not found");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTodo(ITodoService service, int id)
        {
            var res = await service.DeleteTodoAsync(id);
            return res ? Ok() : NotFound("Todo not found");
        }
    }
}
