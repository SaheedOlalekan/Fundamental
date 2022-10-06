~using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //    11. We are given a number n and a position p. Write a sequence of 
            //     operations that prints the value of the bit on the position p in the 
            //     number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
            //     p=6 -> 0. 

                System.Console.Write("Enter a number:");
                int n = int.Parse(Console.ReadLine());
                System.Console.Write("Enter a position:");
                double p = double.Parse(Console.ReadLine());
                string binary = Convert.ToString(n , 2);
                System.Console.WriteLine(binary);
                int bit = (int)Math.Pow(2,p);
                bool isOne = (n & bit) != 0;
                if(isOne)
                {
                    System.Console.WriteLine("The bit at the position" +" " + p + " " + "of" + " " + n + " " + "is" + " " + 1 + ".");
                }
                else
                {
                    System.Console.WriteLine("The bit at the position" +" " + p + " " + "of" + " " + n + " " + "is" + " " + 0 + ".");
                }
            
        }
    }
}
