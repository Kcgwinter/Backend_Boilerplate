using System;
using Backend_Boilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Boilerplate.data;

public class DBInitializer
{
    public static async Task InitDB(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>()
        ?? throw new InvalidOperationException("DbContext not found");


        await SeedData(context);
    }

    private static async Task SeedData(AppDbContext context)
    {

        context.Database.Migrate();

        if (!context.Todos.Any())
        {
            var todos = new List<Todo>()
            {
                new(){Name="Learn ASP.NET Core", Description="Learn how to build web APIs with ASP.NET Core"},
                new(){Name="Build a Web API", Description="Use ASP.NET Core to build a simple Web API"},
                new(){Name="Create a React App", Description="Use Create-React-App to create a frontend for your Web API"},
            };

            context.Todos.AddRange(todos);
            context.SaveChanges();

        }


    }
}
