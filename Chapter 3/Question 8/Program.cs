using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
        //    8. Write an expression that checks for a given point {x, y} if it is within 
        //     the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
        //     the circle and 5 is the radius.

            System.Console.Write("Enter the x-cordinate:" );
            double x = int.Parse(Console.ReadLine());
            System.Console.Write("Enter the y-cordinate:" );
            int y = int.Parse(Console.ReadLine());
            bool isValid  = (x * x) + ( y * y) <= 5 * 5; 
            if(isValid)
            {
                System.Console.WriteLine("The coordinate point is valid.");
            }
            else
            {
                System.Console.WriteLine("The coordinate is Not valid.");
            }
        }
    }
}
