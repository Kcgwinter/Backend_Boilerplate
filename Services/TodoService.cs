using System;
using Backend_Boilerplate.Models;

namespace Backend_Boilerplate.Services;

public class TodoService : ITodoService
{

    static List<Todo> todos =
        [
            new Todo { Id = 1, Name = "Todo 1", Description = "Description 1" },
                new Todo { Id = 2, Name = "Todo 2", Description = "Description 2" },
            ];

    public async Task<List<Todo>> GetTodosAsync()
    {
        return await Task.FromResult(todos);
    }

    public async Task<Todo?> GetTodoByIdAsync(int id)
    {
        var todo = todos.FirstOrDefault(t => t.Id == id);
        return await Task.FromResult(todo);
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
