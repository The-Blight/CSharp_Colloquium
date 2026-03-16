using Workshop.Core.Enums;

namespace Workshop.Core.Entities;

public class Smartphone : AbstractDevice
{
    public required string OperatingSystem { get; init; }
    public const DeviceType Type = DeviceType.Smartphone;

    public Smartphone(string brand, string model, string serialNumber,
        string issueDescription)
        : base(brand, model, serialNumber, issueDescription)
    {
    }

    public override DeviceType GetDeviceType() => Type;
}