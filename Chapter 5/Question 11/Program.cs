using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11. * Write a program that converts a number in the range [0…999] to 
            // words, corresponding to the English pronunciation. Examples:
            // - 0 --> "Zero"
            // - 12 --> "Twelve"
            // - 98 --> "Ninety eight"
            // - 273 --> "Two hundred seventy three"
            // - 400 --> "Four hundred"
            // - 501 --> "Five hundred and one"
            // - 711 --> "Seven hundred and eleven"

            Console.Write("Enter a number between 0 and 999: ");
            int number;
            while(!(int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 999))
            {
                Console.Write("Kindly enter a number between 0 and 999: ");
            }

            switch(number) 
            {
                case 0: Console.Write("Zero"); break;
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 3: Console.Write("Three"); break;
                case 4: Console.Write("Four"); break;
                case 5: Console.Write("Five"); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven"); break;
                case 8: Console.Write("Eight"); break;
                case 9: Console.Write("Nine"); break;
                case 10: Console.Write("Ten"); break;
                case 11: Console.Write("Eleven"); break;
                case 12: Console.Write("Twelve"); break;
                case 13: Console.Write("Thirteen"); break;
                case 14: Console.Write("Fourteen"); break;
                case 15: Console.Write("Fifteen"); break;
                case 16: Console.Write("Sixteen"); break;
                case 17: Console.Write("Seventeen"); break;
                case 18: Console.Write("Eighteen"); break;
                case 19: Console.Write("Nineteen"); break;

            }
        }
    }
}
