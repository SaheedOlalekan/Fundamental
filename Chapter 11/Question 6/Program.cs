using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("\t\tTHIS PROGRAM CALCULATES THE AREA OF A TRINAGLE");
            System.Console.WriteLine();
            Menu();
        }

        // 6. Write a program which calculates the area of a triangle with the 
        // following given:
        // - three sides;
        // - side and the altitude to it;
        // - two sides and the angle between them in degrees
        static double CalculateTheAreaOfTriangle(float sideOne, float sideTwo, float sideThree)
        {
            // Heron’s Formula 𝑆 = √(𝑝(𝑝 − 𝑎)(𝑝 − 𝑏)(𝑝 −𝑐)), where 𝑝 = (𝑎+𝑏+𝑐) / 2.
            double S = 0, p = 0, result = 0, one = 0, two = 0, three = 0;
            p = (sideOne + sideTwo + sideThree) / 2;
            one = p - sideOne;
            two = p - sideTwo;
            three = p - sideThree;
            result = (p * one * two * three);
            S = Math.Sqrt(result);
            return S;
        }
        static double CalculateTheAreaOfTriangle(double side, double height)
        {
            // formula: 𝑆 = {𝑎∗ℎ𝑎) / 2;
            double area = 1 / 2 * (side * height);
            return area;
        }

        static double CalculateTheAreaOfTriangle(double sideOne, double sideTwo, double angle)
        {
            //    formula: 𝑆 = (𝑎 ∗ 𝑏 ∗ 𝑠𝑖𝑛(𝛾)) / 2.
            double S = (sideOne * sideTwo * Math.Sin(angle)) / 2;
            return S;
        }

        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("THIS PROGRAM CALCULATES THE AREA OF A TRIANGLE");
            Console.WriteLine(" PRESS 1: To use three sides to find the area of the triangle: " +
            "\n PRESS 2: To calculate the area of the trinagle with one side and the altitude to it: " +
            "\n PRESS 3: To find the area of the triangle with two sides and an angle between them: ");
            int input;
            while (!(int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 3))
            {
                Console.WriteLine("Kindly enter a positive number lesser than 4: ");
            }
            System.Console.WriteLine();
            if (input == 1)
            {
                System.Console.Write("Enter the first side of the triangle: ");
                float firstSide = float.Parse(Console.ReadLine());
                System.Console.Write("Enter the second side of the triangle: ");
                float secondSide = float.Parse(Console.ReadLine());
                System.Console.Write("Enter the third side of the triangle: ");
                float thirdSide = float.Parse(Console.ReadLine());
                System.Console.WriteLine(CalculateTheAreaOfTriangle(firstSide, secondSide, thirdSide));
            }
            else if (input == 2)
            {
                System.Console.Write("Enter the side of the triangle: ");
                double side = double.Parse(Console.ReadLine());
                System.Console.Write("Enter the height of the triangle: ");
                double height = double.Parse(Console.ReadLine());
                System.Console.WriteLine(CalculateTheAreaOfTriangle(side, height));
            }
            else if (input == 3)
            {
                System.Console.Write("Enter the first side of the triangle: ");
                double firstSide = double.Parse(Console.ReadLine());

                System.Console.Write("Enter the second side of the triangle: ");
                double secondSide = double.Parse(Console.ReadLine());

                System.Console.Write("Enter the angle between the two sides of the triangle: ");
                double angle = double.Parse(Console.ReadLine());
                System.Console.WriteLine(CalculateTheAreaOfTriangle(firstSide, secondSide, angle));
            }
        }







    }


}
