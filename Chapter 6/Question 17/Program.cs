using System;

namespace Question_17
{
    class Program
    {
        static void Main(string[] args)
        {
        //     17. Write a program that given two numbers finds their greatest common 
            //     divisor (GCD) and their least common multiple (LCM). You may use 
            //     the formula LCM(a, b) = |a*b| / GCD(a, b).

            Console.Write("Enter the first number: ");
            int number1;
            while (!(int.TryParse(Console.ReadLine(), out number1)))
            {
                Console.Write("Kindly enter a number: ");
            }
            Console.Write("Enter the second number: ");
            int number2;
            while (!(int.TryParse(Console.ReadLine(), out number2)))
            {
                Console.Write("Kindly enter a number: ");
            }
            int smaller = (number1 + number2 - Math.Abs(number1 - number2)) / 2;
            int maximum = int.MinValue;

            for (int gcd = 1; gcd <= smaller; gcd++)
            {
                if (number1 % gcd == 0 && number2 % gcd == 0)
                {
                    if (gcd > maximum)
                    {
                        maximum = gcd;
                    }
                }
            }
            Console.WriteLine($"The Greatest Common Divisor (GCD) of {number1} and {number2} is {maximum}.");
            Console.WriteLine("\n");

            int lcm = Math.Abs(number1 * number2) / maximum;
            Console.WriteLine($"The Least Common Multiple (LCM) of {number1} and {number2} is {lcm}.");
        }
    }
}
