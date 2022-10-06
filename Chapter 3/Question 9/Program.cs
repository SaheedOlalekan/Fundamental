using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
        //    9. Write an expression that checks for given point {x, y} if it is within the 
        //     circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
        //     Clarification: for the rectangle the lower left and the upper right corners 
        //     are given.  

            
            Console.Write("Enter the x1-cordinate:" );
            double x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the x2-cordinate:" );
            double x2 = int.Parse(Console.ReadLine());
 
            System.Console.Write("Enter the y1-cordinate:" );
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the y2-cordinate:" );
            double y2 = int.Parse(Console.ReadLine());
 
            bool isValid  = (x1 * x2) + ( y1 * y2) <= 5 * 5; 
            if(isValid)
            {
                System.Console.WriteLine("The coordinate point is valid.");
            }
            else
            {
                System.Console.WriteLine("The coordinate is Not valid.");
            }
           

        //     //    9. Write an expression that checks for given point {x, y} if it is within the 
        // //     circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
        // //     Clarification: for the rectangle the lower left and the upper right corners 
        // //     are given.  

            
        //     Console.Write("Enter the x1-cordinate:" );
        //     double x1 = int.Parse(Console.ReadLine());
        //     Console.Write("Enter the x2-cordinate:" );
        //     double x2 = int.Parse(Console.ReadLine());
 
        //     System.Console.Write("Enter the y1-cordinate:" );
        //     int y1 = int.Parse(Console.ReadLine());
        //     Console.Write("Enter the y2-cordinate:" );
        //     double y2 = int.Parse(Console.ReadLine());
 
        //     bool isTriangle  = (x1 * x2) + ( y1 * y2) <= 5 * 5; 
        //     bool isRectangle = (x1 >= -1 &&  x2 <= 5 ) && (y1 >= 1 && y2 <= 5);
        //     if(isTriangle && isRectangle)
        //     {
        //         System.Console.WriteLine("The coordinate point is valid.");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("The coordinate is Not valid.");
        //     }

        }
    }
}
