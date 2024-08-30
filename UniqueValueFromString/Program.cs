namespace UniqueVlaueFromString;

public class Program
{
	public static void Main(string[] args)
	{
        string strs = "text is Not Goods";
        string[] charArrays = strs.Split(" ");
        List<string> list = new List<string>();
        for (int i = 0; i < charArrays.Length; i++)
		{
            char[] charArray = charArrays[i].ToCharArray();
            foreach (char c in charArray)
                if (!list.Contains(c.ToString()))
                    list.Add(c.ToString());
        }

		Console.Write(string.Join(", ", list));
		Console.ReadLine();
	}
}