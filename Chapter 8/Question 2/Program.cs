using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  2.Convert the number 1111010110011110(2) to hexadecimal and decimal
                numeral systems*/

            int binaryNumber = 0b_1111_0101_1001_1110;
            string decimalNumber = Convert.ToString(binaryNumber, 10);
            Console.Write("To decimal number: ");
            Console.WriteLine(decimalNumber);
            string hexNumber = Convert.ToString(int.Parse(decimalNumber), 16);
            Console.Write("To hexadecimal nukmber: ");
            Console.WriteLine(hexNumber.ToUpper());
        }
    }
}
