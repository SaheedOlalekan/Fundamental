using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Write a program that finds the greatest of given 5 numbers.
            int max = int.MinValue;
            
            for (int i = 1; i <=5; i++)
            {
               Console.Write($"Enter the number {i}: ");
               int number;
               while(!(int.TryParse(Console.ReadLine(), out number)))
               {
                   Console.Write($"Kindly enter a number{i}:");
               }
               if (number > max)
               {
                   max = number;
               }
            }
            Console.WriteLine($"The biggest of the numbers is {max}.");

        }
    }
}
