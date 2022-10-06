using System;
using System.Collections.Generic;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.Write a program that converts a decimal number to hexadecimal one.


                        Console.WriteLine("\n\n");
                        Console.WriteLine("\t\tTHIS PROGRAM CONVERTS DECIMAL NUMBER TO HEXADECIMAL NUMBER");
                        Console.WriteLine("\n");
                        Console.Write("Enter a decimal number: ");
                        int number = int.Parse(Console.ReadLine());
                        int remainder = 0;
                        List<char> myList = new List<char>();
                        char hexaDecimal = '\u0000';
                        int saveKeep = number;
                        while (number > 0)
                        {
                            remainder = number % 16;
                            number = number / 16;
                            if (remainder == 0)
                            {
                                hexaDecimal = '0';
                            }
                            if (remainder == 1)
                            {
                                hexaDecimal = '1';
                            }
                            if (remainder == 2)
                            {
                                hexaDecimal = '2';
                            }
                            if (remainder == 3)
                            {
                                hexaDecimal = '3';
                            }
                            if (remainder == 4)
                            {
                                hexaDecimal = '4';
                            }
                            if (remainder == 5)
                            {
                                hexaDecimal = '5';
                            }
                            if (remainder == 6)
                            {
                                hexaDecimal = '6';
                            }
                            if (remainder == 7)
                            {
                                hexaDecimal = '7';
                            }
                            if (remainder == 8)
                            {
                                hexaDecimal = '8';
                            }
                            if (remainder == 9)
                            {
                                hexaDecimal = '9';
                            }
                            if (remainder == 10)
                            {
                                hexaDecimal = 'A';
                            }
                            if (remainder == 11)
                            {
                                hexaDecimal = 'B';
                            }
                            if (remainder == 12)
                            {
                                hexaDecimal = 'C';
                            }
                            if (remainder == 13)
                            {
                                hexaDecimal = 'D';
                            }
                            if (remainder == 14)
                            {
                                hexaDecimal = 'E';
                            }
                            if (remainder == 15)
                            {
                                hexaDecimal = 'F';
                            }
                            myList.Add(hexaDecimal);
                        }

                        Console.Write($"{saveKeep} in hexadecimal is ");
                        myList.Reverse();
                        myList.ForEach(e => Console.Write(e));
        }
    }
}
