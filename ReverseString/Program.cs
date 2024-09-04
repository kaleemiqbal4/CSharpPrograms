namespace ReverseString;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter String: ");
        string inputStr = Console.ReadLine();
        ReverseGivenString reverseGivenString = new ReverseGivenString();
        reverseGivenString.AraryReverseString(inputStr);
        reverseGivenString.StringReverse(inputStr);
        reverseGivenString.ReverseStringUsingIEnumerable(inputStr);
        Console.ReadLine();
    }
}


public class ReverseGivenString
{
    public void StringReverse(string inpuStr)
    {
        Console.WriteLine("Using Convert IEneumeable -> charArray -> string: ");
        var revStr = new string(inpuStr.Reverse().ToArray());
        Console.WriteLine(revStr);
    }

    public void AraryReverseString(string inpuStr)
    {
        Console.WriteLine("Using Convert  charArray -> string: ");
        var charArray = inpuStr.ToCharArray();
        Array.Reverse(charArray);
        string str = new string(charArray);
        Console.WriteLine(str);
    }

    public void ReverseStringUsingIEnumerable(string inpuStr)
    {
        Console.WriteLine("Using Convert IEneumeable: ");
        foreach (var x in inpuStr.Reverse())
            Console.Write($"{x}");
    }
}
