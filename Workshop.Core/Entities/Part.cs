using System;

namespace Workshop.Core.Entities;

public class Part
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required string Article { get; init; }
    public required decimal SellingPrice { get; init; }
  

    public Part(string name, string article, 
                decimal sellingPrice)
    {
        Id = Guid.NewGuid();
        Name = name;
        Article = article;
        SellingPrice = sellingPrice;
        
    }

}