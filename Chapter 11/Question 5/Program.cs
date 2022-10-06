using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("\t\tTHIS PROGRAM CALCULATES THE HYPOTENUSE OF A RIGHT ANGLE TRIANGLE");
            System.Console.WriteLine();
            System.Console.Write("Enter the first side of the traingle: ");
            int sideOne;
            while(!(int.TryParse(Console.ReadLine(), out sideOne)))
            {
                Console.Write("Kindly enter a number: ");
            }
             System.Console.Write("Enter the first side of the traingle: ");
            int sideTwo;
            while(!(int.TryParse(Console.ReadLine(), out sideTwo)))
            {
                Console.Write("Kindly enter a number: ");
            }
            System.Console.Write("The hypotenuse of the triangle is: ");
            System.Console.WriteLine(CalculateTheHypotenuse(sideOne, sideTwo));
            System.Console.WriteLine();
        }

            // 5. Write a program which by given two sides finds the hypotenuse of a 
            // right triangle. Implement entering of the lengths of the sides from the 
            // standard input, and for the calculation of the hypotenuse use methods of 
            // the class Math.
        
        static double CalculateTheHypotenuse(int sideOne, int sideTwo)
        {
            double result = 0;
            result = Math.Pow(sideOne, 2) + Math.Pow(sideTwo, 2);
            double hypotenuse = Math.Sqrt(result);
            return hypotenuse;
        }
    }
}
