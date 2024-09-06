namespace InterfaceImplementation;

public class Program
{
    public static void Main(string[] args)
    {
        string str = "My Name is Khan";
        ChildClass childObj = new ChildClass();
        childObj.Name = "Hello India";
        var name= childObj.SetName(childObj.Name);
        var abc = childObj.GetName();
        Console.WriteLine($"out put from child class {abc}");
        Console.ReadLine();
    }
}

public class ParentClass : ITestIntreface
{
    private string _name;
    public string Name { get => _name; set => value = _name; }

    public string GetName()
    {
        Console.WriteLine("I am called from ParentClass {0}", Name);
        return Name;
    }

    public string SetName(string input)
    {
       return  Name = input;
    }
}

public class ChildClass : ParentClass, ITestIntreface 
{

}