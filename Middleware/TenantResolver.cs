using System;
using Backend_Boilerplate.Models;
using Backend_Boilerplate.Services;

namespace Backend_Boilerplate.Middleware;

public class TenantResolver
{

    private readonly RequestDelegate _next;

    public TenantResolver(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, ICurrentTenantService currentTenantService)
    {
        context.Request.Headers.TryGetValue("Tenant", out var tenantFromHeader);
        if (String.IsNullOrEmpty(tenantFromHeader))
        {
            await currentTenantService.SetTenant(tenantFromHeader);
        }

        await _next(context);
    }

}
