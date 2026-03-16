using System;
using Workshop.Core.Enums;

namespace Workshop.Core.Entities;

public abstract class AbstractDevice
{
    public required Guid Id { get; init; }
    public required string Brand { get; init; }
    public required string Model { get; init; }
    public DeviceType DeviceType { get; }
    public required string SerialNumber { get; init; }
    public required string IssueDescription { get; init; }

    public AbstractDevice(string brand, string model, string serialNumber, string issueDescription)
    {
        Id = Guid.NewGuid();
        Brand = brand;
        Model = model;
        SerialNumber = serialNumber;
        IssueDescription = issueDescription;
    }


    public abstract DeviceType GetDeviceType();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Бренд: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Серийный номер: {SerialNumber}");
        Console.WriteLine($"Описание неисправности: {IssueDescription}");
    }
}