namespace SplitString;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Enter String");
        string str = "Hello India";
        SplitStringUsingMultipleConditions splitStringUsingMultipleConditions = new SplitStringUsingMultipleConditions();
        splitStringUsingMultipleConditions.SplitOnWhiteSpace(str);
        var commaAndSemiColonString = "Hello, India; How Are; you";
        splitStringUsingMultipleConditions.SplitStringOnWhiteSpaceSemicolonAndComma(commaAndSemiColonString);
        string input = "apple,banana,,orange";
        splitStringUsingMultipleConditions.SplitStringUSingLinq(input);
        Console.ReadLine();
    }
}

public class SplitStringUsingMultipleConditions
{
    public void SplitOnWhiteSpace(string str)
    {
        Console.WriteLine("Split string using space");
        var splitStr = str.Split(' ');
        Console.WriteLine(string.Join(", ", splitStr)); 
    }

    public void SplitStringOnWhiteSpaceSemicolonAndComma(string str)
    {
        Console.WriteLine("Split string using space, semicolon and comma");
        var delimiter = new char[] { ';', ',', ' ' };
        var splitStr = str.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(", ", splitStr));
    }

    public void SplitStringUSingLinq(string str)
    {
        var result = str.Split(',')
                          .Where(s => !string.IsNullOrEmpty(s))
                          .ToArray();
        Console.WriteLine($" result is {string.Join(", ", result)}");
    }
}