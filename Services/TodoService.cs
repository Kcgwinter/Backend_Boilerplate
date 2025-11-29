using System;
using Backend_Boilerplate.data;
using Backend_Boilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Boilerplate.Services;

public class TodoService(AppDbContext context) : ITodoService
{

    public async Task<List<Todo>> GetTodosAsync()
    {
        return await context.Todos.ToListAsync<Todo>();
    }

    public async Task<Todo?> GetTodoByIdAsync(int id)
    {
        var todo = await context.Todos.FindAsync(id);
        return todo;
    }

    public Task<Todo> CreateTodoAsync(Todo todo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateTodoAsync(Todo todo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTodoAsync(int id)
    {
        throw new NotImplementedException();
    }
}
