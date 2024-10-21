namespace CSharpAwesome.Init;

public class Customer
{
    public Customer(string firstName, string lastName, string? middleName = null)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string? MiddleName { get; }
}

public class InitAndRequiredExample
{
    public void ExampleOfConstructor()
    {
        var person = new Customer("John", "Doe");
    }

    public void ExampleOfInit()
    {
        //Customer person = new()
        //{
        //    FirstName = "John",
        //    LastName = "Doe"
        //};
    }
}
