using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
           //12.Write a program that calculates the sum(with precision of 0.001) of
            // the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

            Console.Write("Enter a number:");
            double number = double.Parse(Console.ReadLine());
            double sum = 0, oddSum = 0, evenSum = 0;
            for (double i = 2; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += (1 / i);
                }
                else
                {
                    oddSum += (-1 / i);
                }
            }
            sum = 1 + oddSum + evenSum;
            Console.WriteLine("{0:F3}", sum);
        }
    }
}
