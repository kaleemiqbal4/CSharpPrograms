namespace AddNumberFromGivenInteger;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a integer");
        int num = Convert.ToInt32(Console.ReadLine());
        SumOfGivenInteger sumOfGivenInteger = new SumOfGivenInteger();
        int result = sumOfGivenInteger.SumOfInteger(num);
        Console.WriteLine(" sum of number {0} is {1}", num, result);
        Console.ReadLine();
    }
}

public class SumOfGivenInteger
{
    public int SumOfInteger(int number)
    {
        int result = 0;
        while (number > 0)
        {
            int remainder = number % 10;
            result += remainder;
            number /= 10;
        }
        return result;
    }
}