using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
           /*11.Write a program to find a sequence of neighbor numbers in an array,
          which has a sum of certain number S.Example: { 4, 3, 1, 4, 2, 5, 8},
           S = 11  { 4, 2, 5}.*/

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\tTHIS PROGRAM FINDS A SEQUENCE OF NEIGHBOUR NUMBERS IN AN ARRAY WHICH HAS A SUM OF CERTAIN NUMBER.");
            Console.WriteLine("\n");
            Console.Write("Enter the length of the array: ");
            int length;
            while (!(int.TryParse(Console.ReadLine(), out length)))
            {
                Console.Write("Kindly enter a number: ");
            }
            Console.Write("Enter the sum of the numbers to find: ");
            int sum;
            while (!(int.TryParse(Console.ReadLine(), out sum)))
            {
                Console.Write("Kindly enter a number: ");
            }
            int[] myArray = new int[length];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter the elemnet at index {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int addition = 0, lastIndex = 0, startIndex = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i; j < myArray.Length; j++)
                {
                    addition += myArray[j];
                    if (addition == sum)
                    {
                        sum = addition;
                        startIndex = i;
                        lastIndex = j;
                        break;
                    }
                }

                addition = 0;

            }
            
            
            if (sum != 0)
            {
                Console.Write($"Sum = {sum} ");
                Console.Write("{");
                for (int a = startIndex; a <= lastIndex; a++)
                {
                    Console.Write($"{myArray[a]},");
                }
                  Console.Write("}");
            }
            else
            {
                Console.WriteLine("There is no a sequence of neighbour numbers in an array that has the sum.");
            }



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////



            
        //     /*20. * Write a program, which checks whether there is a subset of given
        //     array of N elements, which has a sum S. The numbers N, S and the array
        //     values are read from the console. Same number can be used many times.
        //     Example: { 2, 1, 2, 4, 3, 5, 2, 6}, S = 14  yes(1 + 2 + 5 + 6 = 14)*/

        //     Console.Write("Enter the length of the array,(N): ");
        //     int arrayLength;
        //     while (!(int.TryParse(Console.ReadLine(), out arrayLength)))
        //     {
        //         Console.Write("Kindly enter a number: ");
        //     }

        //     int[] myArray = new int[arrayLength];

        //     for (int a = 0; a < myArray.Length; a++)
        //     {
        //         Console.Write($"Enter the element at index {{{a}}}: ");
        //         myArray[a] = int.Parse(Console.ReadLine());
        //     }
        //     Console.Write("Enter the sum of the subset(S): ");
        //     int sum;
        //     while (!(int.TryParse(Console.ReadLine(), out sum)))
        //     {
        //         Console.Write("Kindly enter a number lesser than array size(N): ");
        //     }

        //     int addition = 0,startIndex = 0, endIndex = 0, maxSum = 0;
        //     for (int i = 0; i < myArray.Length; i++)
        //     {
        //         addition = myArray[i];
        //         for (int j = i + 1; j < myArray.Length; j++)
        //         {
        //             addition += myArray[j];
        //             if(addition == sum)
        //             {
        //                 maxSum = sum;
        //                 startIndex = i;
        //                 endIndex = j;
        //                 break;
        //             }
        //         }
        //         addition = 0;
                
        //     }
           
        //    if(sum == maxSum)
        //     {
        //         Console.Write($"S = {maxSum}, Yes");
        //         Console.Write("{");
        //         for (int i = startIndex; i <= endIndex; i++)
        //         {
        //            if(i != endIndex)
        //             {
        //                 Console.Write(myArray[i]);
        //                 Console.Write("+");
        //             }
        //             else
        //             {
        //                 Console.Write(myArray[i]);
        //             }
        //         }
               
        //         Console.Write($" = {maxSum}");
        //         Console.Write("}");
        //     }
        //    if(sum != maxSum)
        //     {
        //         Console.WriteLine($"There is no subset of given array which has a sum {maxSum}.");
        //     }
        }
    }
}
