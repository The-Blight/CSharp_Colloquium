using System;

namespace Workshop.Core.Entities;

public class Client
{
    public required Guid Id { get; init; }

    public required string FirstName { get; init; }

    public string? Patronymic { get; init; }

    public required string LastName { get; init; }

    public required string Phone { get; init; }

    public string? Email { get; init; }

    public Client(string firstName, string lastName, string phone,
        string? patronymic = null, string? email = null)
    {
        Id = Guid.NewGuid();

        FirstName = firstName;
        Patronymic = patronymic;
        LastName = lastName;
        Phone = phone;
        Email = email;
    }
}