using System;
using Microsoft.EntityFrameworkCore;

namespace Backend_Boilerplate.Models;

public class TenantDBContext : DbContext
{
    public TenantDBContext(DbContextOptions<TenantDBContext> options) : base(options)
    {

    }
    public DbSet<Tenant> Tenants { get; set; }
}
