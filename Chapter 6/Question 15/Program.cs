using System;

namespace Question_15
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 15. Write a program that converts a given number from hexadecimal to 
            // decimal notation.

            Console.WriteLine("\n\n");
            Console.WriteLine("\n\nHOW TO CONVERT FROM HEXADECIMAL NUMBER TO DECIMAL NUMBER");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("\n");
            Console.Write("Enter the number in Hexadecimal format: ");
            int decimalValue = 0;
            int placeValue = 1;
            string input = Console.ReadLine();
            char [] letter = new Char [input.Length];
            for(int hexa = input.Length - 1; hexa > 0; hexa--)
            {
                if( hexa == '1' )
                {
                    decimalValue = 0;
                }
                if( hexa == '2' )
                {
                    decimalValue = 2;
                }
                if( hexa == '3' )
                {
                    decimalValue = 3;
                }
                 if( hexa == '4' )
                {
                    decimalValue = 4;
                }
                if( hexa == '5' )
                {
                    decimalValue = 5;
                }
                 if( hexa == '6' )
                {
                    decimalValue = 6;
                }
                 if( hexa == '7' )
                {
                    decimalValue = 7;
                }
                if( hexa == '8' )
                {
                    decimalValue = 8;
                }
                 if( hexa == '9' )
                {
                    decimalValue = 9;
                }
                 if( hexa == 'A' )
                {
                    decimalValue = 10;
                }
                if( hexa == 'B' )
                {
                    decimalValue = 11;
                }
                 if( hexa == 'C' )
                {
                    decimalValue = 12;
                }
                if( hexa == 'D' )
                {
                    decimalValue = 13;
                }
                if( hexa == 'E' )
                {
                    decimalValue = 14;
                }
                if( hexa == 'F' )
                {
                    decimalValue = 15;
                };
                decimalValue += decimalValue * placeValue;
                placeValue  = placeValue * 16;
            }
            Console.WriteLine($"The hexadecimal value in decimal number is {decimalValue}.");
        }
    }
}
