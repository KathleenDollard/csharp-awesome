namespace CSharpAwesome;

public class CollectionExpressions
{
    public void Example()
    {
        int[] x1 = [1, 2, 3, 4];
        int[] x2 = [];
        WriteByteArray([1, 2, 3]);
        List<int> x4 = [1, 2, 3, 4];
        Span<DateTime> dates = [GetDate(0), GetDate(1)];
        WriteByteSpan([1, 2, 3]);

        // These are a local functions. They are very nice, although I may not be able to cover them.
        // These are just dummy ones to supply the signatures.
        static void WriteByteArray(byte[] bytes) { }
        static void WriteByteSpan(Span<byte> bytes) { }
        static DateTime GetDate(int i) => DateTime.Now;
    }

    //int[] x1 = [1, 2, 3, 4];
    //int[] x2 = [];
    //WriteByteArray([1, 2, 3]);
    //List<int> x4 = [1, 2, 3, 4];
    //Span<DateTime> dates = [GetDate(0), GetDate(1)];
    //WriteByteSpan([1, 2, 3]);

    public static void SpreadExamples()
    {
        int[] x1 = [1, 2, 3, 4];   // 1, 2, 3, 4
        int[] x2 = [.. x1, 5];     // 1, 2, 3, 4, 5
        int[] x3 = [.. x1[1..^1]]; // 2, 3
        int[] x4 = [.. x2, ..x3];  // 1, 2, 3, 4, 5, 2, 3

        Console.WriteLine($"{OutputArray(x1)}");
        Console.WriteLine($"{OutputArray(x2)}");
        Console.WriteLine($"{OutputArray(x3)}");
        Console.WriteLine($"{OutputArray(x4)}");

        static string OutputArray(int[] array) 
            => string.Join(", ", array);
    }
}
