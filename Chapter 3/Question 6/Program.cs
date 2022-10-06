using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Write a program that prints on the console the perimeter and the area
            //of a rectangle by given side and height entered by the user.

            Console.Write("Enter the length of the rectangle:");
            double length = int.Parse(Console.ReadLine());
            Console.Write("Enter the breadth of the rectangle:");
            double breadth = int.Parse(Console.ReadLine());
            double area = length * breadth;
            double perimeter = 2 * (length + breadth);
            Console.WriteLine("The area of the rectangle is:" + " " +
             area + "," + " and the Perimeter is:" + " " + perimeter + ".");
        }
    }
}
 