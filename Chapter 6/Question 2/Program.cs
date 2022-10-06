using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
                //   2. Write a program that prints on the console the numbers from 1 to N, 
                // which are not divisible by 3 and 7 simultaneously. The number N 
                // should be read from the standard input.

                Console.Write("Enter an number: ");
                int number;
                while(!(int.TryParse(Console.ReadLine(), out number)))
                {
                    Console.Write("Kindly enter a number: ");
                }
                for (int i = 1; i <= number; i++)
                {
                    if(i % (3 * 7) != 0)
                    {
                            Console.Write(" " + i);
                    }
                    Console.Write(" ");
                }
        }
    }
}
