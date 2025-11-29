using System;
using Backend_Boilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Boilerplate.Services;

public class CurrentTenantService : ICurrentTenantService
{
    private readonly AppDbContext _context;
    public CurrentTenantService(AppDbContext context)
    {
        _context = context;
    }

    public string? TenantId { get; set; }

    public async Task<bool> SetTenant(string tenant)
    {
        var tenantInfo = await _context.Tenants.Where(x => x.Id == tenant).FirstOrDefaultAsync();

        if (tenantInfo == null)
        {
            throw new Exception("Tenant invalid");
        }

        TenantId = tenantInfo.Id;
        return true;
    }
}
