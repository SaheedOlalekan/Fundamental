using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
        //    12. Write a Boolean expression that checks if the bit on position p in the 
        //     integer v has the value 1. Example v=5, p=1 -> false.

                System.Console.Write("Enter a number:");
                int v = int.Parse(Console.ReadLine());
                System.Console.Write("Enter a position:");
                double p = double.Parse(Console.ReadLine());

                string binary = Convert.ToString(v , 2);
                System.Console.WriteLine(binary);

                int bit = (int)Math.Pow(2,p);
                bool isOne = (v & bit) != 0;
                if(isOne)
                {
                    System.Console.WriteLine("The bit at the position" +" " + p + " " + "of" + " " + v + " " + "is" + " " + "true" + ".");
                }
                else
                {
                    System.Console.WriteLine("The bit at the position" +" " + p + " " + "of" + " " + v + " " + "is" + " " + "false" + ".");
                }
            
        }
    }
}
