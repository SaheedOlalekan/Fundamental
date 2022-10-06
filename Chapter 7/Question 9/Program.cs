using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
             /*9.Write a program, which finds a subsequence of numbers with
             maximal sum. E.g.: { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11.*/
            Console.WriteLine("\n\n");
            Console.WriteLine("THIS PROGRAM FINDS A SUBSEQUENCE OF NUMBERS WITH MAXIMAL SUM IN AN ARRAY.");
            Console.WriteLine("\n");
            Console.Write("Enter the length of the array: ");
            int length;
            while(!(int.TryParse(Console.ReadLine(), out length)))
            {
                Console.Write("Kindly enter a number: ");
            }

            int[] myArray = new int[length];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter the element at index {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t USING BRUTE FORCE METHOD");
            int sum = 0, maxSum = int.MinValue;
            var watch = new System.Diagnostics.Stopwatch();
            foreach( int index in myArray)
            {
                watch.Start();
                sum += index;
                if(sum < 0)
                {
                    sum = 0;   
                }
                if(sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            watch.Stop();
            Console.WriteLine(" ");
            Console.WriteLine($"The maximal sum of a sequence of the array is {maxSum}.");
            Console.WriteLine($"Time Taken: {watch.ElapsedMilliseconds}ms ");


                //?????????????????????????????????????????????????????????????????????????????????????????????????????????????????

                
        //      /*9.Write a program, which finds a subsequence of numbers with
        //    maximal sum. E.g.: { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11.*/


        //     // int[] myArray = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //     //int[] myArray = { -3, 7, -2, 9, -1, 5, -4, 3, -3 };
        //     // int[] myArray = { -2, 16, 6, -1, 2, -15, 6, 4, -8, 8 };
        //     int[] myArray = { -2, 16, 6, -1, 2, -1, 6, 4, -8, 8 };
        //     int sum = 0, maxSum =- 0, j = 0, i = 0;
        //     for(i = 0; i < myArray.Length; i++)
        //     {
        //         sum = myArray[i];
        //         for(j = i + 1; j < myArray.Length; j++)
        //         {
        //             sum += myArray[j];
        //             if(sum > maxSum)
        //             {
        //                 maxSum = sum;
        //             }
        //         }
        //         sum = 0;

        //     }
        //     Console.WriteLine($"The maximal sum of the array is {maxSum}.");  


        }
    }
}
