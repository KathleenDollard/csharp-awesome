﻿namespace CSharpAwesome;

// Copy this into SharpLab to see what is built
public record class Customer(string FirstName, string LastName, string? MiddleInitial = null)
{
}

public class Records
{


    public void Example()
    {
        var x = new Customer("Kathleen", "Dollard");
        var y = x with { MiddleInitial = "A" };
    }
}
