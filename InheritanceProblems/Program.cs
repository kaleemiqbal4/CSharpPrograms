namespace InheritanceProblems;
public class A
{
    public void Display()
    {
        Console.WriteLine("A");
    }
}

public class B : A
{
    public void DisplayOne()
    {
        Console.WriteLine("B");
    }

    public void ChildDisplay()
    {
        Console.WriteLine("ChildDisplay");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        B obj = new B();
        obj.Display(); // print B
        obj.DisplayOne();
        obj.ChildDisplay();

        A obj2 = new A();
        obj2.Display(); // Print A

        A obj3 = new B();
        obj3.Display(); // Parent B

        //B obj4 = new A(); // compile  error
        //obj4.Display();
    }
}