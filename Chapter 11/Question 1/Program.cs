using System;

namespace Chapter_11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n");
            Console.WriteLine("Hello World!");
            Console.WriteLine("\t\tTHIS PROGRAM FINDS A LEAP YEAR.");
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = DateTime.IsLeapYear(year); // Non-Method Approach
            Console.Write(isLeapYear + ",");
            Console.Write(" ");
            FindTheLeapYear(year);   // Method Approach 
            System.Console.WriteLine("\n");


        }

        // 1. Write a program, which reads from the console a year and checks if it is a leap year.
        static void FindTheLeapYear(int year)
        {
            bool isLeapYear = DateTime.IsLeapYear(year);
            if(isLeapYear == true)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is Not a leap year.");
            }
        }
    }
}
