using System;

namespace Backend_Boilerplate.DTOs;

public class TodoRequestDto
{
    public int? Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
