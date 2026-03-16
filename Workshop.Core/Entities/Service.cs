using System;

namespace Workshop.Core.Entities;

public record Service
{
    public required Guid Id { get; init;  }
    public required string Name { get; init; }
    public required decimal Price { get; init; }

    public Service(string name, decimal price)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price; 
    }
}