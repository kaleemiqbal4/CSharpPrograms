using System.Text;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var string1 = "aabbbcdddee";
        var string2 = "abbcccddeeef";
        var output = string1.ToCharArray().Intersect(string2.ToCharArray());

       var data = output.GroupBy(x => x).Select(x => new { key = x, value = x.Count() });
        foreach (var item in data)
        {
            Console.WriteLine(item.value);
            Console.WriteLine(item.key);
        }

        //var numbers = new List<int> { 1, 2, 3, 4, 5 };
        //var resultDict = numbers.ToDictionary(n => n, n => n * n);
        //foreach (var number in resultDict)
        //{
        //    Console.WriteLine(" key is => {0} and value is => {1}", number.Key, number.Value);
        //}

        //string input = "ThisIsAnExampleStringToSplit";
        //var result = new List<string>();
        //var sb = new StringBuilder();

        //foreach (char c in input)
        //{
        //    if (char.IsUpper(c) && sb.Length > 0)
        //    {
        //        result.Add(sb.ToString());
        //        sb.Clear();
        //    }
        //    sb.Append(c);
        //}

        //if (sb.Length > 0)
        //{
        //    result.Add(sb.ToString());
        //}

        //Console.WriteLine("Split parts:");
        //foreach (var part in result)
        //{
        //    Console.WriteLine(part);
        //}

        Console.ReadLine();
    }
}