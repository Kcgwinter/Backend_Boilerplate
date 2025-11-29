using System;
using Backend_Boilerplate.Models;

namespace Backend_Boilerplate.Middleware;

public class TenantResolver
{

    private readonly RequestDelegate _next;

    public TenantResolver(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        context.Request.Headers.TryGetValue("Tenant", out var tenantFromHeader);
        if (String.IsNullOrEmpty(tenantFromHeader))
        {
            context.Request.Headers.TryGetValue("Host", out var hostFromHeader);
            tenantFromHeader = hostFromHeader.ToString().Split('.')[0];
        }

        await _next(context);
    }

}
