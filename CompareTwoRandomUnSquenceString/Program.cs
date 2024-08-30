public static class Program
{
    public static void Main(string[] args)
    {
        string str1 = "GeeksgeeksFor";
        // string str2 = "GeeksForgeeks";
        var convertArray = str1.ToArray();
        var ayySorted = convertArray.OrderDescending();

        Console.WriteLine(string.Join((","), ayySorted));
        Console.ReadLine();
    }
}