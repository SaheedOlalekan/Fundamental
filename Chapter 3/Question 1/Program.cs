using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            
           // 1.Write an expression that checks whether an integer is odd or even.
           
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine( number + " " + "is an even number.");
            }
            else
            {
                Console.WriteLine (number +"" + " is an odd number.");
            }
        }
    }
}
