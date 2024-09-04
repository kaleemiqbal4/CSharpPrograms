namespace StaticConstructorAndFields;

public class StaticConstructor
{
    public static void Main(string[] args)
    {
        StaticImplementation staticImplementation = new StaticImplementation();
        // Console.WriteLine(StaticImplementation.str);
        staticImplementation.ChangeStaticVariableValue();
        Console.ReadLine();
    }
}


public class StaticImplementation
{
    private static readonly string str;

    public StaticImplementation()
    {
        string str = "Hello I have been called from default constructor";
        Console.WriteLine(str);
    }

    static StaticImplementation()
    {
        Console.WriteLine("Hello I am written in constructor at start");
        str = "Hello I am Static Fields";
        Console.WriteLine(str);
        Console.WriteLine("Hello I am written in constructor at last");
    }

    public void ChangeStaticVariableValue()
    {
        Console.WriteLine($"value of the str is {(str is null ? "I am null": str)}");
        string str1 = "Called in Method";
        Console.WriteLine(str1);
    }
}

