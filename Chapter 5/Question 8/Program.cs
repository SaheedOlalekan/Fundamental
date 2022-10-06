using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Write a program that, depending on the user’s choice, inputs int, double
            // or string variable. If the variable is int or double, the program 
            // increases it by 1. If the variable is a string, the program appends "*" at 
            // the end. Print the result at the console. Use switch statement.

            Console.WriteLine("To enter an interger number, press 1: \nTo enter a double number, press 2: \nTo enter a string word, press 3: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                Console.Write("Enter an integer number:");
                int input1;
                while(!(int.TryParse(Console.ReadLine(), out input1)))
                {
                    Console.Write("Kindly enter an integer number: ");
                }
                 int sum = input1 + 1;
                Console.Write($"The result is {sum}.");
                break;

                case 2:
                Console.Write("Enter a double number:");
                double input2 = double.Parse(Console.ReadLine());
                double sum2 = input2 + 1;
                Console.Write($"The result is {sum2}.");
                break;

                case 3:
                Console.Write("Enter a string: ");
                string input3 = Console.ReadLine(); 
                Console.WriteLine($"The result is {input3}*.");
                break;

                default:
                Console.Write("Invalid input, Kindly choose between options 1, 2 and 3.");
                break;


            }
        }
    }
}
