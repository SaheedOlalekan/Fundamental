using System;
using System.Collections.Generic;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
         //    Write a program that converts a given number from decimal to 
            //     hexadecimal notation.

            Console.WriteLine("Enter a number in decimal number: ");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write("Kindly enter a number: ");
            }
            char output = ' ';

            var stack = new  Stack <char>();
          
           
            int modulo = 0;
            while (number > 0)
            {
                modulo = number % 16;

                if (modulo == 0)
                {
                    output = '0';
                }
                if (modulo == 1)
                {
                    output = '1';
                }
                if( modulo == 2)
                {
                    output = '2';
                }
                if (modulo == 3)
                {
                    output = '3';
                }
                if (modulo == 4)
                {
                    output = '4';
                }
                if (modulo == 5)
                {
                    output = '5';
                }
                if (modulo == 6)
                {
                    output = '6';
                }
                if (modulo == 7)
                {
                    output = '7';
                }
                if (modulo == 8)
                {
                    output = '8';
                }
                if( modulo == 9)
                {
                    output = '9';
                }
                if (modulo == 10)
                {
                    output = 'A';
                }
                if (modulo == 11)
                {
                    output = 'B';
                }
                if (modulo == 12)
                {
                    output = 'C';
                }
                if (modulo == 13)
                {
                    output = 'D';
                }
                if (modulo == 14)
                {
                    output = 'E';
                }
                if (modulo == 15)
                {
                    output = 'F';
                }
                stack.Push(output);
                number = number / 16;
            }
            while(stack.Count >= 1)
            {
               var print = stack.Pop();
                Console.Write(print);
            }
        }
    }
}
