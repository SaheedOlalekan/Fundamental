using System;
using System.Collections.Generic;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12. Write a program that converts a given number from decimal to binary 
            // notation (numeral system).


             Console.Write("Enter a number: ");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write("Kindly enter a number: ");
            }
            
            var binary = new List<int>();
            int modulo = 0;
           
           while(number > 0)
            {
                modulo = number % 2;
                binary.Add(modulo);
                number = number / 2;

            }
            for (int i = binary.Count - 1; i >= 0; i--)
            {
                Console.Write(binary[i]);
            }
        }
    } 
}
