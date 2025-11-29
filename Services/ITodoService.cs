using System;
using Backend_Boilerplate.Models;

namespace Backend_Boilerplate.Services;

public interface ITodoService
{
    Task<List<Todo>> GetTodosAsync(); // Example method signature
    Task<Todo?> GetTodoByIdAsync(int id);
    Task<Todo> CreateTodoAsync(Todo todo);
    Task<bool> UpdateTodoAsync(Todo todo);
    Task<bool> DeleteTodoAsync(int id);
}
