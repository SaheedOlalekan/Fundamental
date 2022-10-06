using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //  4. Write a program, which finds the maximal sequence of consecutive 
            //     equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t THIS PROGRAM RETURNS THE MAXIMAL SEQUENCE OF CONSECUTIVE EQUAL ELEMENTS.");
            Console.WriteLine("\n\n");
            Console.Write("Enter the length of the array: ");
            int length;
            while (!(int.TryParse(Console.ReadLine(), out length)))
            {
                Console.Write("Kindly enter a number: ");
            }
            int[] myAarray = new int[length];
            for (int k = 0; k < length; k++)
            {
                Console.Write($"Enter the element at index {k}: ");
                myAarray[k] = int.Parse(Console.ReadLine());
            }
            int number = 0;
            int currentCount = 1;
            int nextNumber = 0;
            int maxCount = int.MinValue;
            int i = 0;

            for (i = 0; i < length - 1; i++)
            {
                if (myAarray[i] != myAarray[i + 1])
                {
                    currentCount = 1;
                }
                else 
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        nextNumber = myAarray[i + 1];
                        number = nextNumber;
                    }
                }

            }
            Console.WriteLine("\n");
            if(maxCount > 0)
            {
                Console.Write("The maximal sequence of consecutive equal element in the array are: ");
                for (int h = 0; h < maxCount; h++)
                {
                    Console.Write(number + " ");
                    
                }
            }
            if(maxCount <= 1)
            {
                Console.WriteLine("There is no number with maximal sequence of consecutive  equal elements in the array.");
            }
            Console.WriteLine("\n");    
        }
    }
}
