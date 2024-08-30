using CSharpPocies;

public class Program
{
    public static void Main(string[] args)
    {
        ListHavingVowels listHavingVowels = new ListHavingVowels();
        List<string> str = new List<string> { "Abdul", "Test", "John", "Jen Pul Dumny" };
        listHavingVowels.FilterListHavingTwoVowels(str);
        Console.WriteLine(string.Join(", ", str));
        Console.ReadLine();
    }
}
