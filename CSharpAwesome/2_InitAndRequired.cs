using System.Diagnostics.CodeAnalysis;

namespace CSharpAwesome.Init;

public class Customer
{
    
    public Customer()
    {
    }

    [SetsRequiredMembers]
    public Customer(string firstName, string lastName, string? middleName = null)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }

    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; init; }
}

public class InitAndRequiredExample
{
    public void ExampleOfConstructor()
    {
        var person = new Customer("John", "Doe");
    }

    public void ExampleOfInit()
    {
        Customer person = new()
        {
            FirstName = "John",
            LastName = "Doe"
        };
    }
}
