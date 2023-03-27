using System;

public class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        if (name = "John")
        {
            Console.WriteLine("Hello John!");
        }
        else if (name = "Mary")
        {
            Console.WriteLine("Hello Mary!");
        }
        else
        {
            Console.WriteLine("Hello, what's your name?");
        }
        Console.ReadLine();
    }
    public void DoSomething(int someValue)
    {
        string someString = someValue.ToString();
        int anotherValue = Convert.ToInt32(someString);
        // ... code that uses anotherValue ...
    }
}
