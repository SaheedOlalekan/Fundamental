using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
                // 1. Write a program that prints on the console the numbers from 1 to N. 
                // The number N should be read from the standard input.

                Console.Write("Enter a number: ");
                int number;
                while(!(int.TryParse(Console.ReadLine(), out number)))
                {
                    Console.WriteLine("Kindly enter a number: ");
                }
                 for (int i = 1; i <= number; i++)
                 {
                     Console.WriteLine(i);
                 }
        }
    }
}
