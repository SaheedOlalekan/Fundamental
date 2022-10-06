using System;
using System.Numerics;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
               // 11. Write a program that calculates with how many zeroes the factorial of 
            // a given number ends. Examples:
            // N = 10 -> N! = 3628800 -> 2
            // N = 20 -> N! = 2432902008176640000 -> 4

            Console.Write("Enter the nth term of the factorial: ");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number) && number > 0))
            {
                Console.Write("Kindly enter a postive number: ");
            }

            Console.Write(" ");
            BigInteger factorial = 1;
            int zeroes = 0;
            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

            do
            {
                factorial /= 10;
                zeroes++;

            } while (factorial % 10 == 0);


            Console.Write("The number of zeroes in" + " " + number + "th" + " " + "term of the factorial" + " " + "is" +  " " + zeroes + ".");
        }
    }
}
