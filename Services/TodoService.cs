using System;
using System.Security.Cryptography.X509Certificates;
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

    public async Task<Todo> CreateTodoAsync(TodoRequestDto todo)
    {
        Todo newTodo = new Todo()
        {
            Name = todo.Name,
            Description = todo.Description
         };

        context.Todos.Add(newTodo);
        context.SaveChanges();

        return newTodo; 
    }

    public async Task<bool> UpdateTodoAsync(TodoRequestDto todo, int id)
    {
        Todo updateTodo = context.Todos.Find(id);
        if(updateTodo is null) return false;

        updateTodo.Name = todo.Name;
        updateTodo.Description = todo.Description;
        await context.SaveChangesAsync();
        return true;

    }

    public async Task<bool> DeleteTodoAsync(int id)
    {
        context.Remove(id);
        return true;
    }
}
