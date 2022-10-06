using System;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13. Write a program that converts a given number from binary to decimal 
            //     notation.

            // CONVERT FROM BINARY NUMBER TO DECIMAL NUMBER

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t CONVERT FROM BINARY NUMBER TO DECIMAL NUMBER ");
            Console.Write("\t Enter the binary number: ");
            int binaryNumber;
            while (!(int.TryParse(Console.ReadLine(), out binaryNumber)))
            {
                Console.Write(" \t Kindly enter 1 and 0: ");
            }
            int decimalValue = 0;
            int placeValue = 1;
            int remainder = 0; 
            while (binaryNumber > 0)
            {
                remainder = binaryNumber % 10;
                decimalValue += remainder * placeValue;
                placeValue = placeValue * 2;
                binaryNumber = binaryNumber / 10;
            }
            Console.WriteLine($" The value of the number in decimal is {decimalValue}.");
            Console.Write("\n\n");

        }
    }
}
