using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
        //    10. Write a program that reads an integer number n from the console and 
        //         prints all numbers in the range [1…n], each on a separate line.

                    Console.Write("Enter a number: ");
                    int number;
                    while(!(int.TryParse(Console.ReadLine(), out number) && number >= 1))
                    {
                            Console.Write("Kindly enter a  positive number: ");
                    }
                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine(i);
                    }

        }
    }
} 
