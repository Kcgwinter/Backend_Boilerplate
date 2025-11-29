using System;

namespace Backend_Boilerplate.Models;

public class Product : IMustHaveTenant
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public string TenantId { get; set; }


}
