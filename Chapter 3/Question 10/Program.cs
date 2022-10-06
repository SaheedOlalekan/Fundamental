using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
        //    10. Write a program that takes as input a four-digit number in format abcd
        //     (e.g. 2011) and performs the following actions:
        //     - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        //     - Prints on the console the number in reversed order: dcba (in our 
        //     example 1102).
        //     - Puts the last digit in the first position: dabc (in our example 1201).
        //     - Exchanges the second and the third digits: acbd (in our example 
        //     2101)

                System.Console.WriteLine("Enter a four-digit number: ");
                int abcd = int.Parse(Console.ReadLine());

                int d = abcd % 10;
                int c = (abcd % 100)/10;
                int b = (abcd % 1000)/100;
                int a = (abcd % 10000)/1000;

                // int a = abcd % 10;
                // int b = (abcd / 10) % 10;
                // int c = (abcd/ 100) % 10;
                // int d = (abcd / 1000) % 10;

                int sum = a + b + c + d;
                string convert = Convert.ToString(abcd);
                System.Console.WriteLine("The sum of the digits of " + " " + abcd + " is" + " " + sum + ".");
                System.Console.WriteLine("The reversed oreder of " + " " + abcd + " " + "is" + " " + d+c+b+a + ".");
                System.Console.WriteLine("To put the last digit of " + abcd + " " + "in the first position" +" " + d+a+b+c + "." );
                System.Console.WriteLine("To exchange the second and the third digit is" + " " + a+c+b+d + ".");
                

        }
    }
}
