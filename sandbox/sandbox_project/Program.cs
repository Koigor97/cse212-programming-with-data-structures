using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");
        var listOfNames = new List<string> {"John",  "Mary", "Jane",  "Bob", "Jacob",  "Lily", "Tom", "Lucy"};

        ArrayPractice arrayPractice  = new();

        // arrayPractice.DynamicArray();
        // arrayPractice.FixedArray();
        // arrayPractice.Run();    
        // arrayPractice.DoSomething(100);
        arrayPractice.DoSomethingElse(listOfNames);

    }
}