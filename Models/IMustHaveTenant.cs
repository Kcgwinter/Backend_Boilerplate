using System;

namespace Backend_Boilerplate.Models;

public interface IMustHaveTenant
{
    public string TenantId { get; set; }
}
