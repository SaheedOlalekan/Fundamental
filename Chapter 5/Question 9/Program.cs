using System;
using System.Collections.Generic;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //    9. We are given 5 integer numbers. Write a program that finds those 
            //       subsets whose sum is 0. Examples:
            //       - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
            //        is 0.
            //        - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
            //        with sum 0.

            
            
            Console.Write("Enter the first number: ");
            int firstNumber;
            while(!(int.TryParse(Console.ReadLine(), out firstNumber)))
            {
                Console.Write("Enter a number: ");
            }
             Console.Write("Enter the second number: ");
            int secondNumber;
            while(!(int.TryParse(Console.ReadLine(), out secondNumber)))
            {
                Console.Write("Enter a number: ");
            }

             Console.Write("Enter the third number: ");
            int thirdNumber;
            while(!(int.TryParse(Console.ReadLine(), out thirdNumber)))
            {
                Console.Write("Enter a number: ");
            }
             Console.Write("Enter the fourth number: ");
            int fourthNumber;
            while(!(int.TryParse(Console.ReadLine(), out fourthNumber)))
            {
                Console.Write("Enter a number: ");
            }

             Console.Write("Enter the fifth number: ");
            int fifthNumber;
            while(!(int.TryParse(Console.ReadLine(), out fifthNumber)))
            {
                Console.Write("Enter a number: ");
            }

            if(firstNumber + secondNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is Zero.");
            }
            else if(firstNumber + thirdNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber} and {thirdNumber} is Zero.");
            }
            else if(firstNumber + fourthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber} and {fourthNumber} is Zero.");
            }
            else if(firstNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber} and {fifthNumber} is Zero.");
            }
           else if(secondNumber + thirdNumber == 0)
            {
                Console.WriteLine($"The sum of {secondNumber} and {thirdNumber} is Zero.");
            }
            else if(secondNumber + fourthNumber == 0)
            {
                Console.WriteLine($"The sum of {secondNumber} and {fourthNumber} is Zero.");
            }
           else if(secondNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {secondNumber} and {fifthNumber} is Zero.");
            }
            else if(thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine($"The sum of {thirdNumber} and {fourthNumber} is Zero.");
            }
            else  if(thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {thirdNumber} and {fifthNumber} is Zero.");
            }
            else if(fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {fourthNumber} and {fifthNumber} is Zero.");
            }

            else if(firstNumber + secondNumber + thirdNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber} and {thirdNumber} is Zero.");
            }
            else if(firstNumber + secondNumber + fourthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber} and {fourthNumber} is Zero.");
            }
            else if(firstNumber + secondNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber} and {fifthNumber} is Zero.");
            }
            else if(firstNumber + thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber} and {fifthNumber} is Zero.");
            }
            else if(firstNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {fourthNumber} and {fifthNumber} is Zero.");
            }
           else if(firstNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber} and {fourthNumber} is Zero.");
            }
            else if(secondNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine($"The sum of {secondNumber}, {thirdNumber} and {fourthNumber} is Zero.");
            }
            else if(secondNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {secondNumber}, {fourthNumber} and {fifthNumber} is Zero.");
            }
            else if(secondNumber + thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {secondNumber}, {thirdNumber} and {fifthNumber} is Zero.");
            }
            else if(thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {thirdNumber}, {fourthNumber} and {fifthNumber} is Zero.");
            }
            else  if(firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber},{thirdNumber} and {fourthNumber} is Zero.");
            }
            else  if(firstNumber + secondNumber + thirdNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber}, {thirdNumber} and {fifthNumber} is Zero.");
            }
            else if(firstNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {thirdNumber}, {fourthNumber} and {fifthNumber} is Zero.");
            }
            else if(firstNumber + secondNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber}, {fourthNumber} and {fifthNumber} is Zero.");
            }
            else if(secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {secondNumber}, {thirdNumber}, {fourthNumber} and {fifthNumber} is Zero.");
            }
            else if(firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
            {
                Console.WriteLine($"The sum of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} and {fifthNumber} is Zero.");
            } 
            else 
            { 
                Console.WriteLine("No sum of substring is equal Zero.");
            }
            
            








                
                
              
                
            
        }
    }
}
