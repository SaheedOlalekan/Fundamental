using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter the element at index {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the element to find is position: ");
            int position = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintFirstOccurrencePosition(numbers,position));
        }

                //  6. Write a method that returns the position of the first occurrence of an 
                // element from an array, such that it is greater than its two neighbors 
                // simultaneously. Otherwise the result must be -1.

        static int PrintFirstOccurrencePosition( int[] myArray, int number)
        {
            int elementPosition = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] == number)
                {
                    elementPosition = i;
                    break;
                }
            }
            if(elementPosition == 0 && myArray.Length == 1)
            {
                elementPosition = 0;
                return elementPosition;
            }
            else if(elementPosition == 0 && (myArray.Length) > 1)
            {
                if(myArray[elementPosition] > myArray[elementPosition + 1])
                {
                    return elementPosition;
                }
                else
                {
                    elementPosition = -1;
                    return elementPosition;
                }
            }
            else if(elementPosition == myArray.Length - 1 && (myArray.Length) > 1)
            {
                if(myArray[elementPosition] > myArray[myArray.Length - 2])
                {
                    
                    return elementPosition;
                }
                else
                {
                    elementPosition = -1;
                    return elementPosition;
                }
            }
            else if(elementPosition != 0 && elementPosition != myArray.Length - 1 && myArray.Length > 1)
            {
                if(myArray[elementPosition] > myArray[elementPosition - 1] && myArray[elementPosition] > myArray[elementPosition + 1])
                {
                    return elementPosition;
                }
                else
                {
                    elementPosition = -1;
                    return elementPosition;
                }
            }
            else
            {
                elementPosition = -1;
                return elementPosition; 
            }
        }
    }
}
