using System;
using Backend_Boilerplate.Controllers;
using Backend_Boilerplate.Models;
using Backend_Boilerplate.Services;
using Microsoft.EntityFrameworkCore;

namespace Backend_Boilerplate.Migrations;

public class DBIntitializer
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

        if (!context.Products.Any())
        {
            var products = new List<Product>
            {
                new ()
                {
                    Name = "Product 1",
                    Description = "Description of Product 1"
                },
                new ()
                {
                    Name = "Product 2",
                    Description = "Description of Product 2"
                }
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
