namespace SortArrays;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 32, 2, 87, 0, 99, 120, 874, 3 };
        SortArrayResult sortArrayResult = new SortArrayResult();
       var result = sortArrayResult.SortArrayMethod(arr);
        Console.WriteLine(string.Join(", ", result));
        Console.ReadLine();
    }
}

public class SortArrayResult
{
    public int[] SortArrayMethod(int[] arr) 
    {
        for (int i = 0; i < arr.Length; i++) 
        { 
            for(int j = i + 1; j<arr.Length; j++)
            {
                int temp = 0;
                if(arr[i] > arr[j])
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