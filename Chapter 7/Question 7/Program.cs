using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
               // 7. Write a program, which reads from the console two integer numbers N
            // and K (K<N) and array of N integers. Find those K consecutive 
            // elements in the array, which have maximal sum.

            // Test Case 1: {2,3,9,-4,9,-7,1,6,7}
            // Test Case 2: {-3,7,-2,9,-1,5,-4,3,-3}

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\tTHIS PROGRAM FINDS THE CONSECUTIVE SUBSET OF AN ARRAY THAT GIVES THE MAXIMAL SUM");
            Console.WriteLine("\t\t==================================================================");
            Console.WriteLine("");

            Console.Write("Enter the length of the array,(N): ");
            int arrayLength;
            while (!(int.TryParse(Console.ReadLine(), out arrayLength)))
            {
                Console.Write("Kindly enter a number: ");
            }
            int[] myArray = new int[arrayLength];
            for (int a = 0; a < myArray.Length; a++)
            {
                Console.Write($"Enter the element at index {{{a}}}: ");
                myArray[a] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the size of the subset(K) to give the maximal sum: ");
            int subsetSize;
            while (!(int.TryParse(Console.ReadLine(), out subsetSize) && subsetSize < arrayLength))
            {
                Console.Write("Kindly enter a number lesser than array size(N): ");
            }
            int sum = 0, maximumSum = 0, count = 0, startIndex = 0, lastIndex = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                sum = myArray[i];
                count = 1;
                for (int j = i + 1; j < arrayLength - 1; j++)
                {
                    sum += myArray[j];
                    count ++;
                    if (count == subsetSize)
                    {
                        if (sum > maximumSum)
                        {
                            maximumSum = sum;
                            lastIndex = j;
                            startIndex = i;
                        }
                    }
                }
                count = 0;
            }

            Console.Write("{");
            for (int a = startIndex; a <= lastIndex; a++)
            {
               
                if(a == lastIndex)
                {
                    Console.Write($"{myArray[a]}");
                }
                else
                {
                    Console.Write($"{myArray[a]}, ");
                }
            }
            Console.Write("}");
        }
    }
}
