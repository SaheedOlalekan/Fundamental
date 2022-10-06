using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("\tTHIS PROGRAM PRINTS THE DAY OF THE WEEK.");
            Console.WriteLine("Hello World!");
            Console.Write("Today is :");
            PrintDayOfTheWeek();
            System.Console.WriteLine();
        }
            // 3. Write a program, which prints, on the console which day of the week is 
            // today.
        static void PrintDayOfTheWeek()
        {
            var day = DateTime.Today.DayOfWeek; 
            System.Console.WriteLine(day);
        }
    }
}
