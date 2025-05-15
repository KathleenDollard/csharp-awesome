using Entry = (string region, System.Collections.Generic.List<CSharpAwesome.Customer> customers);

namespace CSharpAwesome;

public class UsingDirectives
{
    public void Example()
    {
        var entry = new Entry();
        Console.WriteLine(entry);
    }
    // Alias
    // Removing global using
}

