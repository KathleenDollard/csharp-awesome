using System.Numerics;

namespace CSharpAwesome;



public class CliOption<T> where T: CliOption<T>
{}

public static class Extensions
{
    public static void SetRange<T>(this CliOption<T> option, T lowerBound, T upperBound)
        where T : INumber<T>
    {

    }
}

public class Example()
{
    public void RangeExample()
    {
        var optInt = new CliOption<int>();
        var optGuid = new CliOption<Guid>();
        
    }
}
