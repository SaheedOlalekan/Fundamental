using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("\t\tTHIS PROGRAM GENERATES NUMBER(S) BETWEEN 100 AND 200.");
            System.Console.WriteLine();
            Console.Write("Enter the length of numbers to generate: ");
            int numbers = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("The method generates a number: ");
            GenerateRandomNumber();
            System.Console.WriteLine();
            System.Console.Write($"Now {numbers} number(s): ");
            GenerateRandomNumber(numbers);
            System.Console.WriteLine();
            
        }

            // 2. Write a program, which generates and prints on the console 10 random 
            // numbers in the range [100, 200].

        static void GenerateRandomNumber()
        {
            Random num = new Random();
            var rand = num.Next(100, 201);
            Console.WriteLine(rand);
        }

        static void GenerateRandomNumber(int number)
        {
            Random random = new Random();
            
            for (int i = 0; i < number; i++)
            {
                int rand = random.Next(201);
                Console.Write(rand);
                Console.Write(" ");
            }
        }
    }
}
