using System;
using Backend_Boilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Boilerplate.Services;

public class CurrentTenantService : ICurrentTenantService
{
    private readonly TenantDBContext _context;
    public string? TenantId { get; set; }

    public CurrentTenantService(TenantDBContext context)
    {
        _context = context;

    }
    public async Task<bool> SetTenant(string tenant)
    {

        var tenantInfo = await _context.Tenants.Where(x => x.Id == tenant).FirstOrDefaultAsync(); // check if tenant exists
        if (tenantInfo != null)
        {
            TenantId = tenant;
            return true;
        }
        else
        {
            throw new Exception("Tenant invalid");
        }

    }
}
