using System;
using System.Numerics;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintNumberFactorial(number));
        }

            // 10. Write a program that calculates and prints the n! for any n in the range
            // [1…100].

        static BigInteger PrintNumberFactorial(int number)
        {
            BigInteger product = 1;
            for (int i = number; i >= 1; i--)
            {
                product *= i;
            }
            return product;
        }
    }   
}
