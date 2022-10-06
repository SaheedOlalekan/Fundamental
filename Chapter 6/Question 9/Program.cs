using System;
using System.Numerics;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.Write("Enter the value of numerator(n): ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)))
            {
                Console.Write("Kindly enter a positive number: ");
            }
            Console.Write("Enter the value of denomenator(x): ");
            int x;
            while (!(int.TryParse(Console.ReadLine(), out x)))
            {
                Console.Write("Kindly enter a positive number: ");
            }
            double sum = 1;
            double factorial = 1;
            double nterm = 1;
            double power = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                power = Math.Pow(x, i);
                nterm = factorial / power;
                sum += nterm;
            }



            Console.WriteLine( " Sum = " + "{0:F5}", sum);
        }
    }
}
