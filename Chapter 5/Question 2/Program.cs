using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    2. Write a program that shows the sign (+ or -) of the product of three real 
        //     numbers, without calculating it. Use a sequence of if operators.

                
                 Console.Write("Enter the first number:");
                    int a;
                 while(!(int.TryParse(Console.ReadLine(), out a)))
                 {
                     Console.Write("Kindly enter a number: ");
                 }
                  Console.Write("Enter the second number:");
                    int b;
                 while(!(int.TryParse(Console.ReadLine(), out b)))
                 {
                     Console.Write("Kindly enter a number: ");
                 }
                  Console.Write("Enter the third number:");
                  int c;
                 while(!(int.TryParse(Console.ReadLine(), out c)))
                 {
                     Console.Write("Kindly enter a number: ");
                 }

                 if(a > 0 && b > 0 && c > 0) Console.Write("+");
                 else if(a > 0 && b > 0 && c < 0) Console.Write("-");
                 else if(a > 0 && b < 0 && c < 0) Console.Write("+");
                 else if(a < 0 && b < 0 && c < 0) Console.Write("-");
                 else if(a < 0 && b > 0 && c > 0) Console.Write("-");
                 else if(a < 0 && b < 0 && c > 0) Console.Write("+");
                 else if(a < 0 && b > 0 && c < 0) Console.Write("+");
                 else if(a > 0 && b < 0 && c > 0) Console.Write("-");
                 else if(a == 0 || b == 0 || c == 0 ) Console.WriteLine("0");

                 
        
        }
    }
}
