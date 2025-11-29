using System;
using Backend_Boilerplate.Models;

namespace Backend_Boilerplate.Services;

public interface ITodoService
{
    Task<List<Todo>> GetTodosAsync(); // Example method signature
    Task<Todo> GetTodo();
    Task<Todo> CreateTodo(Todo todo);
    Task<Todo> UpdateTodo(Todo todo);
    Task<bool> DeleteTodo(int id);
}
