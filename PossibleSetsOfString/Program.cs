using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        // PossibleNumberOfStringSets();
        PossibleNumberOfStringSetsWithOutShift();
        Console.ReadLine();
    }

    public static void PossibleNumberOfStringSets()
    {
        string set = "abc";
        int subset = 1 << set.Length;
        for (int i = 0; i < subset; i++)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < set.Length; j++)
                if ((i & (1 << j)) != 0)
                    sb.Append(set[j]);
            Console.Write(sb.ToString());
            Console.Write(" ");
        }
    }

    public static void PossibleNumberOfStringSetsWithOutShift()
    {
        string str = "abc";
        int length = str.Length;
        for (int i = 0; i < length; i++)
        {
            // Loop to fix the ending index
            for (int j = i + 1; j <= length; j++)
            {
                // Extract the substring from index i to index j
                string substring = str.Substring(i, j - i);
                Console.WriteLine(substring);
            }
        }
    }
}
