using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Write an expression that calculates the area of a trapezoid by given 
            // sides a, b and height h.

            System.Console.Write("Enter the value of first side of the trapezoid: ");
            double a = int.Parse(Console.ReadLine());
            System.Console.Write("Enter the value of second side of the trapezoid : ");
            double b = int.Parse(Console.ReadLine()); 
            System.Console.Write("Enter the value of height of the trapezoid: ");
            double h = int.Parse(Console.ReadLine());
            double area = (a + b) * h / 2;
            System.Console.WriteLine("The area of the trapezoid is:" + " " + area + ".");
            

            

            

        }
    }
}
