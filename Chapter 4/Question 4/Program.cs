using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
        //    4. Write a program that prints three numbers in three virtual columns
        //     on the console. Each column should have a width of 10 characters and 
        //     the numbers should be left aligned. The first number should be an 
        //     integer in hexadecimal; the second should be fractional positive; and 
        //     the third – a negative fraction. The last two numbers have to be 
        //     rounded to the second decimal place.

            int num = 765;
            double numb = 57.765;
            double number = -53.8765;
            Console.WriteLine("{0,-10:x} {1,-10:F2} {2,-10:F2}" , num, numb, number);

            Console.WriteLine("");
            
            Console.WriteLine("{0,-10:x}", num);
            Console.WriteLine("{0,-10:F2}", numb);
            Console.WriteLine("{0,-10:F2}", number);

            Console.WriteLine("{0,50:x}", num);
            Console.WriteLine("{0,50:F2}", numb);
            Console.WriteLine("{0,50:F2}", number);


        }
    }
}
