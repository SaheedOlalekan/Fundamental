using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
        //    9. Write a program that reads an integer number n from the console. After 
        //     that reads n numbers from the console and prints their sum.

                Console.Write("Enter the number of interger:  ");
                int number;
                while(!(int.TryParse(Console.ReadLine(), out number) && number > 0))
                {
                    Console.Write("Kindly enter a number greater than 0: ");
                }
                int sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"Enter the number {i}: ");
                    int numb;
                    while(!(int.TryParse(Console.ReadLine(), out numb)))
                    {
                        Console.Write("Kindly enter a number: ");
                    }

                    sum = sum + numb;
                }
                Console.WriteLine($"The sum of the {number} numbers is {sum}.");

        }
    }
}
