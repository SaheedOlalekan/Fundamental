using System;
using System.Collections;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
              //4.Write a program that converts a decimal number to binary one.

             Console.WriteLine("\n\n");
             Console.WriteLine("\t\tTHIS PROGRAM CONVERTS NUMBER FROM DECIMAL NUMBER TO BINARY NUMBER");
             Console.WriteLine("\n");
             Console.Write("Enter a decimal number: ");
             int number;
             while (!(int.TryParse(Console.ReadLine(), out number))) 
             {
                 Console.Write("Kindly enter a number: ");

             }

             int remainder = 0;
             var keep4me = new Stack();
             int staysafe = number;
             while (number > 0)
             {
                 remainder = number % 2;
                 number = number / 2;
                 keep4me.Push(remainder);
             }


             Console.Write($"{staysafe} converts to binary number is: ");
             foreach (var item in keep4me)
             {
                 Console.Write(item);
             }
             Console.WriteLine("\n\n");
        }
    }
}
