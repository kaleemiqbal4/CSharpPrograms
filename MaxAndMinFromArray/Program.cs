namespace MaxAndMinFromArray;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Set value of Array");
        int numOfElements = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[numOfElements];
        for (int i = 0; i < numOfElements; i++)
        {
            Console.WriteLine("{0} index elemnt is ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        };

        FindMaxAndMin findMaxAndMin = new FindMaxAndMin();
        var result = findMaxAndMin.GetMaxAndMinFromAnArray(array);
        Console.WriteLine("max value is {0} and min value is {1} ", result.Item1, result.Item2);
    }
}

public class FindMaxAndMin
{
    public (int, int) GetMaxAndMinFromAnArray(int[] array)
    {
        if(array.Length == 0)
        {
            Console.WriteLine("Array is empty.");
            return(0,0);
        }
        int max = array[0], min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine(string.Join(", ", array));
        return (max, min);
    }
}