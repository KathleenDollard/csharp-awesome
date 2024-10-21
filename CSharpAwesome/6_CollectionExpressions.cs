namespace CSharpAwesome;

public class CollectionExpressions
{
    public void Example()
    {
        int[] x1 = new int[] { 1, 2, 3, 4 };
        int[] x2 = Array.Empty<int>();
        WriteByteArray(new[] { (byte)1, (byte)2, (byte)3 });
        List<int> x4 = new() { 1, 2, 3, 4 };
        Span<DateTime> dates = stackalloc DateTime[] { GetDate(0), GetDate(1) };
        WriteByteSpan(stackalloc[] { (byte)1, (byte)2, (byte)3 });

        // These are a local functions. They are very nice, although I may not be able to cover them.
        // These are just dummy ones to supply the signatures.
        static void WriteByteArray(byte[] bytes) { }
        static void WriteByteSpan(Span<byte> bytes) { }
        static DateTime GetDate(int i) => DateTime.Now;
    }

    public void SpreadExamples()
    {
        int[] x1 = [1, 2, 3, 4];   // 1, 2, 3, 4
        int[] x2 = [.. x1, 5];     // 1, 2, 3, 4, 5
        int[] x3 = [.. x1[1..^1]]; // 2, 3 
    }
}
