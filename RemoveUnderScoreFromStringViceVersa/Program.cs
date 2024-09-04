using System.Text;

namespace RemoveUnderScoreFromStringViceVersa;
public class RemoveUnderScoreFromString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter String With Under Score");
        string str = Console.ReadLine();
        ImplementationClass implementationClass = new ImplementationClass();
        str = implementationClass.RemoveUnderScore(str);
        Console.WriteLine(str);
    }
}

public class ImplementationClass
{
    private static readonly string UnderScore = "_";
    public string RemoveUnderScore(string name)
    {
        if (string.IsNullOrEmpty(name))
            return "Please enter some value";

        var arr = name.Split('_');
        StringBuilder stringBuilder = new StringBuilder();
        if (arr.Length > 1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != UnderScore)
                    stringBuilder.Append(arr[i]);
            }
        }
        else
        {
            var charArr = name.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (Char.IsUpper(charArr[i]) && stringBuilder.Length > 0)
                    stringBuilder.Append(UnderScore);

                stringBuilder.Append(charArr[i].ToString().Trim());
            }
        }

        return stringBuilder.ToString();
    }

}
