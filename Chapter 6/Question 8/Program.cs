using System;
using System.Numerics;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Hello World!");

            Console.Write("\n\n");
            Console.WriteLine("{0,50}", " THIS PROGRAM CALCULATES THE Nth TERM OF CALATAN NUMBER");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.Write("Enter the n number: ");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number) && number >= 0))
            {
                Console.Write("Kindly enter a positive number: ");
            }

            int numerator = 2 * number;
            BigInteger nFactorial = 1;
            
            for (int i = numerator; i >= 1; i--)
            {
                nFactorial *= i;

            }

            BigInteger denomenator = 1;
            BigInteger dFactorial = 1;
            for (int i = number; i >= 1; i--)
            {
                dFactorial *= i;
            }
            denomenator = dFactorial * (dFactorial * (number + 1));

            BigInteger calatanNumber = 1;
            calatanNumber = nFactorial / denomenator;
            Console.WriteLine($"The {number}th term of the Calatan number is {calatanNumber}.");
            Console.Write("\n\n");
        }
    }
}
