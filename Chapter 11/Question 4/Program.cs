using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n");
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("\t\t THIS PROGRAM CALCULATES THE EXECUTION TIME UNTIL NOW");
            System.Console.WriteLine();
            CalculateExecutionTimeTillNow();
            System.Console.WriteLine();

        }

                // 4. Write a program, which prints on the standard output the count of days, 
                // hours, and minutes, which have passes since the computer is 
                // started until the moment of the program execution. For the 
                // implementation use the class Environment.

        static void CalculateExecutionTimeTillNow()
        {
            int stopWatch = Environment.TickCount;
            Console.WriteLine($"Miliseconds: {stopWatch}");
            int days = stopWatch / 86400000;
            double remainderAfterDays = stopWatch - (days * 86400000.0);
            Console.WriteLine($"{days} Days, {remainderAfterDays} miliseconds.");
            double hours = Math.Floor(remainderAfterDays / 3600000);
            double remainderAfterHours = remainderAfterDays - (hours * 3600000);
            Console.WriteLine($"{days} Days, {hours} Hours, {remainderAfterHours} miliseconds.");
            double minutes = Math.Floor(remainderAfterHours / 60000);
            double remainderAfterMinutes = remainderAfterHours - (minutes * 60000);
            Console.WriteLine($"{days} Days, {hours} Hours, {minutes} Minutes," +
                $" {remainderAfterMinutes} Miliseconds.");
            double seconds = Math.Floor(remainderAfterMinutes / 1000);
            double remainderAfterSeconds = remainderAfterMinutes - (seconds * 1000);
            Console.WriteLine($"{days} Days, {hours} Hours, {minutes} Minutes, {seconds} Seconds, " +
                $"{remainderAfterSeconds} Miliseconds.");
            double miliseconds = remainderAfterSeconds;
            Console.WriteLine($"The program execution time until this moment is : {days} Days, {hours} Hours, " +
                $"{minutes} Minutes, {seconds} Seconds, {miliseconds} miliseconds.");
        }
    }
}
