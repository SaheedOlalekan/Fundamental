using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* 3.Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and
               decimal numeral systems.*/

            int[] hexNumber = { 0xFA, 0x2A3E, 0xFFFF, 0x5A0E9 };
            Console.WriteLine("\n");
            Console.WriteLine("{0, -15} {1, -25} {2, -30}", "Hexadecimal", "Binary Number", "Decimal Number");
            
            for (int item = 0; item < hexNumber.Length; item++)
            {
                string[] hexNumb = { "FA", "2A3E", "FFFF", "5A0E9" };
                int count = item;
                string binaryNumber = Convert.ToString(hexNumber[item], 2);
                string decimalNumber = Convert.ToString(hexNumber[item], 10);
                Console.WriteLine("{0, -15} {1, -25} {2, -30}", hexNumb[count], binaryNumber, decimalNumber);
                count++;
            }
            Console.WriteLine("\n");
        }
    }
}
