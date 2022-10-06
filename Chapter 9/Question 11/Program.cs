using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("\n");
            Console.WriteLine("Hello World!");

            StartMenu();
            //Console.WriteLine(long.MaxValue);
        }

                //  11. Write a program that solves the following tasks:
                // - Put the digits from an integer number into a reversed order.
                // - Calculate the average of given sequence of numbers.
                // - Solve the linear equation a * x + b = 0.
                // Create appropriate methods for each of the above tasks.
                // Make the program show a text menu to the user. By choosing an option 
                // of that menu, the user will be able to choose which task to be invoked.
                // Perform validation of the input data:
                // - The integer number must be a positive in the range [1…50,000,000].
                // - The sequence of numbers cannot be empty.
                // - The coefficient a must be non-zero.

        static void ReverseNumber(int number)
        {
            int modulo = 0;
            while(number > 0)
            {
                modulo = number % 10;
                number = number / 10;
                Console.Write(modulo);
            }
        }
        static void CalculateAverage(int[]numbers)
        {
            int average = 0, numb = numbers.Length;
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
             average = sum / numb;
             Console.WriteLine($"The average of the numbers is {average}.");
        }

        static void SolveLinearEquation(int a, int x, int b)
        {
            int result = 0;
            result = (a * x) + b;
            Console.WriteLine($"The equation is equal to: {result}");
        }

        static void StartMenu()
        {
            bool playOn = true;
            while(playOn)
            {
                Console.WriteLine("Kindly enter between 1, 2, and 3 to perform these operations: ");
                Console.WriteLine("PRESS 1: TO REVERSE A NUMBER");
                Console.WriteLine("PRESS 2: TO FIND AVERAGE OF NUMBERS");
                Console.WriteLine("PRESS 3: TO SOLVE LINEAR EQUATION(a * x + b = 0)");
                int start;
                while(!(int.TryParse(Console.ReadLine(), out start)  && start >= 1 && start <= 3))
                {
                    Console.WriteLine("Kindly enter 1, 2, or 3: ");
                }
                if(start == 1)
                {
                    Console.Write("Enter a number to reverse: ");
                    int number;
                    while(!(int.TryParse(Console.ReadLine(), out number) && number > 0 && number <= 50000000))
                    {
                        Console.Write("Kindly enter a positive number less than 50,000,000: ");
                    }

                    ReverseNumber(number);
                    Console.WriteLine(" ");
                }
                else if(start == 2)
                {
                    Console.Write("Enter the length of the array of numbers: ");
                    int length;
                    while(!(int.TryParse(Console.ReadLine(), out length) && length > 0 && length <= 50000000))
                    {
                        Console.Write("Kindly enter a positive number less than 50,000,000: ");
                    }
                    int [] myArray = new int[length];
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write($"Enter the element at index {i}: ");
                        myArray[i] = int.Parse(Console.ReadLine());
                    }

                    CalculateAverage(myArray);

                }
                else if(start == 3)
                {
                    Console.WriteLine("Linear Equation: a * x + b = 0");
                    Console.Write("Enter the value of a: ");
                    int a;
                    while(!(int.TryParse(Console.ReadLine(), out a) && a > 0 && a <= 50000000))
                    {
                        Console.Write("Kindly enter a positive number less than 50,000,000: ");
                    }
                    Console.Write("Enter the value of x: ");
                    int x;
                    while(!(int.TryParse(Console.ReadLine(), out x) && x > 0 && x <= 50000000))
                    {
                        Console.Write("Kindly enter a positive number less than 50,000,000: ");
                    }
                    Console.Write("Enter the value of b: ");
                    int b;
                    while(!(int.TryParse(Console.ReadLine(), out b) && b > 0 && b <= 50000000))
                    {
                        Console.Write("Kindly enter a positive number less than 50,000,000: ");
                    }

                    SolveLinearEquation(a,x,b);
                }
                Console.WriteLine("\n");
                Console.Write("PRESS 4: TO PERFORM ANY OTHER ACTION, OTHER TO EXIT:  ");
                // Console.WriteLine("\n");
                // Console.Write("PRESS any other key to EXIT: ");
                Console.WriteLine("\n");
                int goOn;
                while(!(int.TryParse(Console.ReadLine(), out goOn)))
                    {
                        Console.Write("Kindly enter a number: ");
                    }
                if(goOn == 4)
                {
                    playOn = true;
                }
                else
                {
                    Console.WriteLine("Thanks for using our program.");
                    playOn = false;
                    break;
                }
                 Console.WriteLine("\n");
            }
        }
    }
}
