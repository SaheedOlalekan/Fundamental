using System;

namespace Question_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //  19. Write a program, which finds all prime numbers in the range 
            // [1…10,000,000].

            Console.Write("\n");
            Console.WriteLine("\t THIS PROGRAM FINDS ALL PRIME NUMBERS IN THE RANGE [1... 10 000 000].");
            Console.Write(" Enter the last number in the range to find its prime: ");
            int number;
            while (!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write("Kindly enter anumber: ");
            }
            var watch = new System.Diagnostics.Stopwatch();
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                watch.Start();
                for (int j = 1; j <= number; j++)
                {
                    if (i % j == 0)
                    {
                        count++;  
                    }
                   
                }
                if (count <= 2)
                {
                    Console.WriteLine(i);
                }
                count = 0;
            }
            watch.Stop();
            Console.WriteLine($"Time Taken: {watch.ElapsedMilliseconds}ms");
        }
    }
}
