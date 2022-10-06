using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine( NestedLoops(number));
            
        }

        // 1. Write a program to simulate n nested loops from 1 to n.

        static int NestedLoops( int number)
        {
            if(number == 1)
            {
                return 1;
            }
            number = number - 1;
            return NestedLoops(number);
        }

    }
}
