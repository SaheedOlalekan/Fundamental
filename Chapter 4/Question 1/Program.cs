using System;

namespace Quetion_1
{
    class Program
    {
        static void Main(string[] args)
        {
        // 1. Write a program that reads from the console three numbers of type int
        // and prints their sum.

            // Console.Write("Enter the first number: ");
            // int number1 = int.Parse(Console.ReadLine());
            // Console.Write("Enter the first number: ");
            // int number2 = int.Parse(Console.ReadLine());
            // Console.Write("Enter the first number: ");
            // int number3 = int.Parse(Console.ReadLine());
            // int sum = number1 + number2 + number3;
            // Console.WriteLine($"The sum of the three numbers is {sum}.");

            Console.WriteLine("Enter the numbers of interger: ");
            int i = 0;
            int sum2 = 0;
            int num;
            while (!(int.TryParse(Console.ReadLine(), out num)))
            {
                Console.WriteLine("Kindly enter a number.");
            }
            for (i = 1; i <= num; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number;
                while (!(int.TryParse(Console.ReadLine(), out number)))
                {
                    Console.WriteLine("Kindly enter a number.");
                }
                sum2 += number;
            }
            Console.WriteLine($"The sum of the {num} numbers is {sum2}.");




        }
    }
           
}
