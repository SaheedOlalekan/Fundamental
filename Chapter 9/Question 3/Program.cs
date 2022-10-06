using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter a number: ");
            int number;
            while(!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write("Kindly enter a number: ");
            }
            PrintLastDigitEnglishName(number);
        }

             //  3. Write a method that returns the English name of the last digit of a 
             // given number. Example: for 512 prints "two"; for 1024  "four".

        static void PrintLastDigitEnglishName(int number)
        {
            int lastDigit = 0;
            lastDigit = number % 10;
            if(lastDigit == 0)
            { 
                Console.WriteLine("Zero");
            }
            else if(lastDigit == 1)
            { 
                Console.WriteLine("One");
            }
            else if(lastDigit == 2)
            { 
                Console.WriteLine("Two");
            }
            else if(lastDigit == 3)
            { 
                Console.WriteLine("Three");
            }
            else if(lastDigit == 4)
            { 
                Console.WriteLine("Four");
            }
            else if(lastDigit == 5)
            { 
                Console.WriteLine("Five");
            }
            else if(lastDigit == 6)
            { 
                Console.WriteLine("Six");
            }
            else if(lastDigit == 7)
            { 
                Console.WriteLine("Seven");
            }
            else if(lastDigit == 8)
            { 
                Console.WriteLine("Eight");
            }
            else if(lastDigit == 9)
            { 
                Console.WriteLine("Nine");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            switch(lastDigit)
            {
                case 0:
                Console.WriteLine("Zero");
                break;
                case 1:
                Console.WriteLine("One");
                break;
                case 2:
                Console.WriteLine("Two");
                break;
                case 3:
                Console.WriteLine("Three");
                break;
                case 4:
                Console.WriteLine("Four");
                break;
                case 5:
                Console.WriteLine("Five");
                break;
                case 6:
                Console.WriteLine("Six");
                break;
                case 7:
                Console.WriteLine("Seven");
                break;
                case 8:
                Console.WriteLine("Eight");
                break;
                case 9:
                Console.WriteLine("Nine");
                break;
                default:
                Console.WriteLine("Invalid Input");
                break;
            }
        }

        }
}
