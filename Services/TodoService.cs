using System;
using Backend_Boilerplate.data;
using Backend_Boilerplate.DTOs;
using Backend_Boilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Boilerplate.Services;

public class TodoService(AppDbContext context) : ITodoService
{

    public async Task<List<TodoResponseDto>> GetTodosAsync()
    {
        return await context.Todos.Select(c => new TodoResponseDto
        {
            Name = c.Name,
            Description = c.Description
        }).ToListAsync();
    }

    public async Task<Todo?> GetTodoByIdAsync(int id)
    {
        var todo = await context.Todos.FindAsync(id);
        return todo;
    }

    public Task<Todo> CreateTodoAsync(TodoResponseDto todo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateTodoAsync(TodoResponseDto todo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTodoAsync(int id)
    {
        throw new NotImplementedException();
    }
}
