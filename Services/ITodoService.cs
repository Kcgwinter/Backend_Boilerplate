using System;
using Backend_Boilerplate.DTOs;
using Backend_Boilerplate.Models;

namespace Backend_Boilerplate.Services;

public interface ITodoService
{
    Task<List<TodoResponseDto>> GetTodosAsync(); // Example method signature
    Task<Todo?> GetTodoByIdAsync(int id);
    Task<Todo> CreateTodoAsync(TodoResponseDto todo);
    Task<bool> UpdateTodoAsync(TodoResponseDto todo);
    Task<bool> DeleteTodoAsync(int id);
}
