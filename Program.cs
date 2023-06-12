using System;

class Program
{
    delegate void GreetingDelegate(string name);

    static void Main()
    {
        GreetingDelegate greetDelegate = delegate (string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        };

        greetDelegate("John");

        Console.ReadKey();
    }
}
