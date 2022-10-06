using System;
using System.Numerics;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
             //  5. Write a program that reads from the console number N and print the sum 
            // of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
            // 13, 21, 34, 55, 89, 144, 233, 377, …

            Console.WriteLine("The sequence and the sum of the first N terms of the Fibonacci sequence.");
            Console.Write("\n");
            Console.Write("---------------------------------------------------------");
            Console.Write("\n\n\n");

            Console.Write("Enter the n term of the Fibonacci: ");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write("Kindly enter a number: ");
            }

            int a = 0, b = 1, c = 0;

            BigInteger sum = 1;
            for (int i = 1; i <= number; i++)
            {

                if (i == 1)
                {
                    c = a + b;
                    Console.Write($" {a}, {b},");
                    a = b;
                    b = c;
                }
                else
                {
                    c = a + b;
                    Console.Write(" " + c + ",");
                    a = b;
                    b = c;
                }
                sum += c;
            }
            Console.Write(" " + " .The Sum of the first " + " " + number + "th" + " " + "term of the Fibonacci is: " + (sum));



        }
    }
}
