using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write an if-statement that takes two integer variables and exchanges
            // their values if the first one is greater than the second one.

            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            int temp = 0;
            if( number1 > number2)
            {
                temp = number1;
                number1 = number2;
                number2 = temp;
                Console.WriteLine($"After swapped, number one is now {number1} and number two is now {number2}.");
            }
            else
            {
                Console.WriteLine("The first number is less than the second number.");
            }
            
        }
    }
}
