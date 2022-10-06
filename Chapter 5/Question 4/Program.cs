using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
           // 4. Sort 3 real numbers in descending order. Use nested if statements.

            Console.Write("Enter the  first number: ");
            int a = int.Parse(Console.ReadLine());
             Console.Write("Enter the second number: ");
            int b  = int.Parse(Console.ReadLine());
             Console.Write("Enter the third number: ");
            int c  = int.Parse(Console.ReadLine());
            
            if( (a > b && b > c) || (b > a && a > c))
            {
                int temp = c;
                c = a;
                a = temp;
            }
            else if( (a > c && c > b) ||(c > a && a > b))
            {
                int temp = b;
                b = a;
                a = temp;
            }
            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }
            Console.WriteLine($"{c} {b} {a}");
        }
    }
}
