using System;
using System.Collections.Generic;
using System.Linq;
using Workshop.Core.Enums;

namespace Workshop.Core.Entities;

public class Engineer
{
    public required Guid Id { get; init; }
    public required string FirstName { get; init; }
    public string? Patronymic { get; init; }
    public required string LastName { get; init; }
    public List<DeviceType> Specialization = [];

    public Engineer(string firstName, string lastName, 
        string? patronymic = null)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Patronymic = patronymic; 
    }

   public bool CanRepair(AbstractDevice device) => Specialization.Contains(device.DeviceType);

   public void AddSpecialization(DeviceType specialization) => Specialization.Add(specialization); 
   
}