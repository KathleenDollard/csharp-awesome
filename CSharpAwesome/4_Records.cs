namespace CSharpAwesome;

// Copy this into SharpLab to see what is built
public record class Customer(string FirstName,
                             string LastName,
                             string? MiddleInitial = null)
{
}

public class WorkingWithRecords
{
    public static void Example()
    {
        var x = new Customer("Kathleen", "Dollard");
        var y = x with { MiddleInitial = "A" };
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}

