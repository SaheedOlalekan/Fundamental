using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.   Write a program that gets the coefficients a, b and c of a quadratic 
            //     equation: ax + bx + c, calculates and prints its real roots (if they exist). 
            //     Quadratic equations may have 0, 1 or 2 real roots.
            //     
               
               Console.Write("Enter the first number:");
               int a = int.Parse(Console.ReadLine());
               Console.Write("Enter the second number:");
               int b = int.Parse(Console.ReadLine());
               Console.Write("Enter the third number:");
               int c = int.Parse(Console.ReadLine());
                double D = Math.Pow(b, 2) - (4 * a * c);
                double x;
                if(D == 0)
                {
                     x = -b / (2 * a);
                    Console.Write($"The roots of the equation are {x} and {x}.");
                }
                if(D > 0)
                {
                     double x1 = (-b + Math.Sqrt( Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                     double x2 = (-b - Math.Sqrt( Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
                     Console.Write("The roots of the equation are {0:F2} and {1:F2}.", x1, x2);
                }
                if(D < 0)
                {
                    Console.WriteLine("The equation has no roots.");
                }
               
            
        }
    }
}
