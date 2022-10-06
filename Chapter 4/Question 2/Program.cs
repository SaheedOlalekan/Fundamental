using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a program that reads from the console the radius "r" of a circle 
            // and prints its perimeter and area.

            Console.Write("Enter the radius of the circle: ");
            int radius;
            while(!(int.TryParse(Console.ReadLine(), out radius)))
            {
                Console.Write("Kindly enter a number: ");
            }
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * (Math.Pow(radius,2));
            Console.WriteLine("The perimeter of the circle is {0:F1} and the area of the circle is {1:F1}.", circumference, area);
            Console.WriteLine("The perimeter of the circle is {0:F2} and the area of the circle is {1:F2}.", circumference, area);
            Console.WriteLine("The perimeter of the circle is {0:F3} and the area of the circle is {1:F3}.", circumference, area);
            Console.WriteLine("The perimeter of the circle is {0:F4} and the area of the circle is {1:F4}.", circumference, area);
            Console.WriteLine("The perimeter of the circle is {0:F5} and the area of the circle is {1:F5}.", circumference, area);
        }
    }
}
