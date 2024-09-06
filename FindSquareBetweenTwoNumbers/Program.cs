namespace FindSquareBetweenTwoNumbers;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter lower bound: ");
        int lowerBound = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter upper bound: ");
        int upperBound = Convert.ToInt32(Console.ReadLine());
        ProblemStatement problemStatement = new ProblemStatement();
        problemStatement.FindSquare(lowerBound, upperBound);
    }
}

public class ProblemStatement
{
    public void  FindSquare(int lowerBound, int upperBound)
    {
        int start = (int)Math.Ceiling(Math.Sqrt(lowerBound));
        int end = (int)Math.Floor(Math.Sqrt(upperBound));
        Console.WriteLine($"Perfect squares between {lowerBound} and {upperBound}:");
        for (int i = start; i <= end; i++)
        {
            int square = i * i;
            Console.WriteLine(square);
        }
    }
}