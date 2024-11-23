using System.Linq;
using System.Numerics;

namespace CSharpAwesome;
//
public class ParamCollections
{
    public static void Example()
    {
        WriteByteArray(1, 2, 3);


        byte[] ints = [1, 2, 3, 4, 5];
        WriteByteArray(ints.Where(x => x < 4));


        WriteByteSpan(1, 2, 3);

        static void WriteByteArray<T>(params IEnumerable<T> bytes) { }
        static void WriteByteSpan(params Span<byte> bytes) { }

    }

    public static void Overloads()
    {
        WriteNumbers(1, 2, 3);
        WriteNumbers([1, 2, 3]);      
        WriteNumbers(new[] { (byte)1, (byte)2, (byte)3 }); // not ambiguous
        byte[] bytes = [1, 2, 3, 4, 5];
        WriteNumbers([.. bytes]); 
        WriteNumbers([.. bytes, 6, 7]); // not ambiguous
        WriteNumbers(bytes.Where(x => x < 4));

    }
    private static void WriteNumbers<T>(params Span<T> values)
        => WriteOutNumbers("Span", string.Join(", ", values.ToArray()));
    //private static void WriteNumbers<T>(params T[] values)
    //    => WriteOutNumbers("array", string.Join(", ", values));
    private static void WriteNumbers<T>(params IEnumerable<T> values)
        where T : INumber<T>
        => WriteOutNumbers("IEnumerable", string.Join(", ", values));

    private static void WriteOutNumbers(string typeName, string values)
        => Console.WriteLine($"{typeName}: {values}");
}