using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter a number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReturnReversedNumber(number));
            PrintReversedNumber(number);
        }

            //7. Write a method that prints the digits of a given decimal number in a 
            // reversed order. For example 256, must be printed as 652.

        static string ReturnReversedNumber(decimal number)
        {
            decimal modulo = 0;
            string reversedNumber = null;
           while(number > 0)
           {
                modulo = number % 10;
                //reversedNumber += modulo; 
                Console.Write(modulo); // instead of saving into the string, write to the Console.
                number  = Math.Floor(number / 10);
           }
           return reversedNumber;
        }
        static void PrintReversedNumber(decimal numb)
        {
            decimal modulo = 0;
            //decimal quotient = 0;
            for ( ; ; )
            {
                modulo = numb % 10;
                numb = Math.Floor(numb / 10);
                Console.Write(modulo);
                if(numb == 0)
                {
                    break;
                }
            }
        }
    }
}
