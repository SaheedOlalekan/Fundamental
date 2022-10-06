using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
        //    7. Write a program that reads five integer numbers and prints their 
        //     sum. If an invalid number is entered the program should prompt the user 
        //     to enter another number.

                Console.Write("Enter the number of integer: ");
                int num = int.Parse(Console.ReadLine());
                int sum = 0;
                
                int number;
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"Enter the number {i}: ");
                    while(!(int.TryParse(Console.ReadLine(), out number)))
                    {
                         Console.Write("Kindly enter a number: ");
                    }

                    sum += number;      
                }
                Console.WriteLine($"The sum of the {num} numbers is {sum}.");
        }
    }
}
