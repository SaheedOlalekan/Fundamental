using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter the element at index {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the number to find its occurrence: ");
            int numb = int.Parse(Console.ReadLine());
            GetNumberOfOccurrence(array, numb);
        }

            // 4. Write a method that finds how many times certain number can be 
            // found in a given array. Write a program to test that the method works 
            // correctly.

        static void GetNumberOfOccurrence(int[] numbers, int numb)
        {
            int count = 0;
            foreach (var number in numbers)
            {
                if (number == numb)
                {
                    count++;
                }
            }
            Console.WriteLine($"{numb} occurs {count} time(s) in the array.");
            
        }    
    }
}
