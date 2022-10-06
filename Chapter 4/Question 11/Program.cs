using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11. Write a program that prints on the console the first 100 numbers in the 
            // Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

            Console.Write("Enter a numb: ");
            int num = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            for (int i= 0; i <= num; i++)
            {
                c = a + b;
                Console.WriteLine(i == 0 ? $"{a}\n{b}\n{c}" : $"{c}");
                a = b;
                b = c;
            }            
         }
    }
}

       