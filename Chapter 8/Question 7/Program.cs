using System;
using System.Collections.Generic;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
              //7.Write a program that converts a hexadecimal number to decimal one.


             Console.WriteLine("\n\n");
             Console.WriteLine("\t\tTHIS PROGRAM CONVERTS HEXADECIMAL NUMBER TO DECIMAL NUMBER");
             Console.WriteLine("\n");
             Console.Write("Enter the number in hexadecimal format: ");
             string numb = Console.ReadLine();
             string number = numb.ToUpper();
             var decimalNumber = new List<int>();
             int output = 0;
             var remainder = new char[number.Length];
             remainder = number.ToCharArray();
             foreach (var item in remainder)
             {
                 if (item == '0')
                 {
                     output = 0;
                 }
                 if (item == '1')
                 {
                     output = 1;
                 }
                 if (item == '2')
                 {
                     output = 2;
                 }
                 if (item == '3')
                 {
                     output = 3;
                 }
                 if (item == '4')
                 {
                     output = 4;
                 }
                 if (item == '5')
                 {
                     output = 5;
                 }
                 if (item == '6')
                 {
                     output = 6;
                 }
                 if (item == '7')
                 {
                     output = 7;
                 }
                 if (item == '8')
                 {
                     output = 8;
                 }
                 if (item == '9')
                 {
                     output = 9;
                 }
                 if (item == 'A')
                 {
                     output = 10;
                 }
                 if (item == 'B')
                 {
                     output = 11;
                 }
                 if (item == 'C')
                 {
                     output = 12;
                 }
                 if (item == 'D')
                 {
                     output = 13;
                 }
                 if (item == 'E')
                 {
                     output = 14;
                 }
                 if (item == 'F')
                 {
                     output = 15;
                 }
                 decimalNumber.Add(output);
             }


             int placeValue = 1, decNumber = 0, result = 0;
             for (int i = decimalNumber.Count - 1; i >= 0; i--)
             {
                 decNumber = decimalNumber[i] * placeValue;
                 placeValue *= 16;
                 result += decNumber;
             }
             Console.WriteLine($"{number} in decimal number is {result}.");
        }
    }
}
