namespace SortLinearArray;

public class SortArray
{
    public static void Main(string[] args)
    {
        int [] arr = SortUserArray();
        int[] sortedArray = StartToSortArray(arr);
        Console.WriteLine(string.Join(", ", sortedArray));
        Console.ReadKey();
    }

    public static int[] SortUserArray()
    {
        Console.WriteLine("Enter Length of Array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter array element {0}", i+1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(string.Join(", ", arr));
        return arr;
    }

    public static int[] StartToSortArray(int[] arr)
    {
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            for(int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j]) 
                { 
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                } 
            }
        }
        return arr;
    }
}