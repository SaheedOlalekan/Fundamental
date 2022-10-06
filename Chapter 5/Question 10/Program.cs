using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10.  Write a program that applies bonus points to given scores in the range 
            // [1…9] by the following rules:
            // - If the score is between 1 and 3, the program multiplies it by 10.
            // - If the score is between 4 and 6, the program multiplies it by 100.
            // - If the score is between 7 and 9, the program multiplies it by 1000.
            // - If the score is 0 or more than 9, the program prints an error 
            // message.

            Console.Write("Enter a score between 1 and 9: ");
            int score;
            while(!(int.TryParse(Console.ReadLine(), out score) && score >= 1 && score <= 9))
            {
                Console.Write("Kindly enter a number between 1 and 9: ");
            }
            
            // Switch Method
            switch(score)
            {
                case 1:
                case 2:
                case 3:
                int point1 =  score * 10;
                Console.Write($"The total point is {point1}.");
                break;
 
                case 4:
                case 5:
                case 6:
                int point2 = score * 100;
                Console.Write($"The total point is {point2}.");
                break;

                case 7:
                case 8:
                case 9:
                int point3 = score * 1000;
                Console.Write($"The total point is {point3}.");
                break;

                default:
                Console.Write(" Invalid input.Kindly enter a score between 1 and 9.");
                break;
            }

                    // If Condition Method
                Console.Write("Enter a score between 1 and 9: ");
                int number;
                while(!(int.TryParse(Console.ReadLine(), out number) &&  number >=1 && number <= 9))
                    {
                        Console.Write("Kindly enter a number between 1 and 9: ");
                    }

                if(number >= 1 && number <= 3)
                    {
                        Console.Write("The total point is:" + (number * 10));
                    }

                else if(number >= 4 && number <= 6)
                    { 
                    Console.Write("The total point is:" + (number * 100)); 
                    }
                 else if(number >= 7 && number <= 9)
                    { 
                    Console.Write("The total point is:" + (number * 1000)); 
                    }
                else
                {
                    Console.Write("Invalid input, Kindly enter a number between 1 and 9: ");
                }

        }
    }

}
