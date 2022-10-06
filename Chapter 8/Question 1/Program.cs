using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
             /* 1.Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary
              numeral system.*/


             int[] numbers = { 151, 35, 43, 251, 1023, 1024 };
             Console.WriteLine("\n\n");
             Console.WriteLine("Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.");
             Console.WriteLine("\n");
             foreach(var number in numbers)
             {
                 string binaryNumber = Convert.ToString(number, 2);
                 Console.Write(binaryNumber + "," + " ");
             }
             Console.WriteLine("\n");
        }
    }
}
