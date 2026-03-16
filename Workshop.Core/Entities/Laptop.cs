using System;
using Workshop.Core.Enums;

namespace Workshop.Core.Entities;

public class Laptop : AbstractDevice
{
    private const DeviceType Type = DeviceType.Laptop;  
    public required string Processor { get; init;  }
    
    public Laptop(string brand,string model, 
                 string serialNumber, string issueDescription, string processor) 
        : base(brand, model, serialNumber, issueDescription)
    {
        Processor = processor; 
    }


    public override DeviceType GetDeviceType() => Type; 
    
    
    public override void PrintInfo()
    {
        Console.WriteLine($"Бренд: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Процессор: {Processor}");
        Console.WriteLine($"Серийный номер: {SerialNumber}");
        Console.WriteLine($"Описание неисправности: {IssueDescription}");
    }
    
}