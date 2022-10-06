using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
                //  3. Write a program that reads from the console a series of integers and 
                // prints the smallest and largest of them.

                Console.Write("Ente a number of integer: ");
                int number;
                while(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Kindly enter a number: ");
                }
                
                
                  int max = int.MinValue;
                  int min = int.MaxValue;
                

                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"Enter number {i}: " );
                    int num;
                    while(!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.Write("Kindly enter a number: ");
                    }

                    if(num > max)
                    {
                        max = num;
                    }
                   
                    if(num < min)
                    {
                        min =num;
                    }
                }
                Console.Write($"The smallest number is {min} and the largest number is {max}.");
                

        }
    }
}
