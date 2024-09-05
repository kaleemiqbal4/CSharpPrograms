using System.Numerics;

namespace FactorialFind;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        BigInteger result = Result.extraLongFactorials(n);
        Console.WriteLine(result);
    }
}

public class Result
{
    public static BigInteger extraLongFactorials(int n)
    {
        if (n == 0 || n == 1) 
        { 
            return 1; 
        }
        return n * extraLongFactorials(n - 1);
    }
}


