using System;

namespace Chapter_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Saheed";
            SayHello(firstName);
        }


        // 1. Write a code that by given name prints on the console "Hello, <name>!"
            // (for example: "Hello, Peter!").
        static void SayHello(string name)
        {
            System.Console.WriteLine($"Hello, {name}!" );
        }
    }
}
