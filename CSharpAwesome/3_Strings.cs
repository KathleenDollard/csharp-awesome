namespace CSharpAwesome;

public class Strings
{

    /// <summary>
    /// This method shows quoted string syntax, but other string types are easier for these cases.
    /// </summary>
    public static void QuotedStringExample()
    {
        var quotedString = "The street is named \"Green street\"";
        var fileString = "C:\\Users\\kdollard\\Documents\\";
        var newLineInString = "First line\nSecondLine"; // not precisely correct on Windows

        Console.WriteLine($"Quoted string: {quotedString}");
        Console.WriteLine($"File string: {fileString}");
        Console.WriteLine($"File string: {newLineInString}");
    }

    /// <summary>
    /// This shows verbatim literal strings, which are simpler than quoted strings for these cases.
    /// </summary>
    public static void VerbatimStringExample()
    {
        var quotedString = @"The street is named ""Green street""";
        var fileString = @"C:\Users\kdollard\Documents\";
        var newLineInString = @"First line
SecondLine"; 

        Console.WriteLine($"Quoted string: {quotedString}");
        Console.WriteLine($"File string: {fileString}");
        Console.WriteLine($"File string: {newLineInString}");
    }

    /// <summary>
    /// Interpolated strings solve a different problem - how to include data in a string easily. 
    /// String.Format is more prone to runtime failures and generally slower.
    /// </summary>
    /// <remarks>
    /// Note that interpolated strings can be either quoted strings or verbatim strings.
    /// </remarks>
    public static void InterpolatedStringExample()
    {
        var planet = "Earth";
        var street = "Green street";
        var user = "kdollard";

        var greeting = $"Hello {planet}";
        var quotedString = @"The street is named ""{street}""";
        var fileString = @$"C:\Users\{user}\Documents\";

        Console.WriteLine($"Quoted string: {quotedString}");
        Console.WriteLine($"File string: {fileString}");
    }

    /// <summary>
    /// Raw strings manage new lines and special characters well and are especlially good
    /// for structured output like JSON or  C# code.
    /// </summary>
    /// <remarks>
    /// Note that interpolated strings can be either quoted strings or verbatim strings and 
    /// that you can also create single line raw strings.
    /// </remarks>
    public static void RawStringExample()
    {
        string jsonString = """
            {
                "Date": "2025-01-01T00:00:00-07:00",
                "AverageTemperatureCelsius": 25,
                "Summary": "Generally cold",
                "DatesAvailable": [
                "2025-01-01T00:00:00-07:00",
                "2024-12-01T00:00:00-07:00"
                ]
            }
            """;

        // Did you know you could do this trick with tuples?
        var (date, avgTemp) = (DateTime.Parse("2025-01-01T00:00:00-07:00"), 25);
        string interpolatedJsonString = $$"""
            {
              "Date": "{{date}}",
              "AverageTemperatureCelsius": {{avgTemp}},
              "Summary": "Generally cold",
              "DatesAvailable": [
                "2025-01-01T00:00:00-07:00",
                "2024-12-01T00:00:00-07:00"
              ]
            }
            """;
    }
}

