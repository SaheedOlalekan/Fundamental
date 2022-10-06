using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
               // 10. Write a program that reads from the console a positive integer number 
            // N (N < 20) and prints a matrix of numbers as on the figures below:
            // N = 3            N = 4
            // 1 2 3
            // 2 3 4
            // 3 4 5
            //                 1 2 3 4
            //                 2 3 4 5
            //                 3 4 5 6
            //                 4 5 6 7

            Console.Write("\n\n");
            Console.WriteLine(" \t\tPrint a Matrix of numbers");
            Console.WriteLine("\t---------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("\tEnter a positive interger number less than 20: ");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number) && number > 0 && number <= 20))
            {
                Console.Write("Kindly enter a  positive number NOT greater than 20:  ");
            }
            Console.Write("\n");
            for (int i = 1; i <= number; i++)
            {
                for (int k = i; k <= i + number - 1; k++)
                {
                    if(k <= 9)
                    {
                        Console.Write($"  {k} ");
                    }
                    else
                    {
                        Console.Write(" " + k + " ");
                    }
                }
                   
                Console.WriteLine(" " + " ");
            }
        }
    }
}
