using System;
using Microsoft.EntityFrameworkCore;

namespace Backend_Boilerplate.Models;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
