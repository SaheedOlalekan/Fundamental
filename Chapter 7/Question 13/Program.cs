using System;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13. Write a program, which creates a rectangular array with size of n by m 
            // elements. The dimensions and the elements should be read from the 
            // console. Find a platform with size of (3, 3) with a maximal sum.
            Console.WriteLine("\n\n");
            Console.WriteLine(" \t\t THIS PROGRAM FINDS (3, 3) PLATFORM THAT GIVES THE MAXIMAL SUM.");
            Console.WriteLine("\n");
            Console.Write("Enter the number of rows of the array: ");
            int row;
            while (!(int.TryParse(Console.ReadLine(), out row) && row >= 3))
            {
                Console.Write("Kindly enter a number greater or equal to 3: ");
            }
            Console.Write("Enter the number of columns of the array: ");
            int column;
            while (!(int.TryParse(Console.ReadLine(), out column) && column >= 3))
            {
                Console.Write("Kindly enter a number greater or equal to 3: ");
            }

            int[,] myMatrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"Enter the elemnent at index: {{{i},{j}}}  ");
                    myMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            var watch = new System.Diagnostics.Stopwatch();

            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    watch.Start();
                    if (myMatrix[i, j] > 9)
                    {
                        Console.Write($"{myMatrix[i, j]}  ");
                    }
                    else
                    {
                        Console.Write($" {myMatrix[i, j]}  ");
                    }

                }
                if (i == myMatrix.GetLength(0) - 1)
                {
                    Console.Write(" }");
                }
                else
                {
                    Console.Write(" },");
                }
                Console.WriteLine(" ");
            }


            int sum = int.MinValue, bestSum = 0, bestRow = 0, bestColumn = 0;

            for (int i = 0; i < myMatrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1) - 2; j++)
                {
                    sum = myMatrix[i, j] + myMatrix[i, j + 1] + myMatrix[i, j + 2] +
                          myMatrix[i + 1, j] + myMatrix[i + 1, j + 1] + myMatrix[i + 1, j + 2] +
                          myMatrix[i + 2, j] + myMatrix[i + 2, j + 1] + myMatrix[i + 2, j + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestColumn = j;
                    }
                }
            }
            Console.WriteLine("The best 3*3 platform that gives the maximal sum is: ");
            Console.WriteLine($" {myMatrix[bestRow, bestColumn]},  {myMatrix[bestRow, bestColumn + 1]},  {myMatrix[bestRow, bestColumn + 2]}");
            Console.WriteLine($" {myMatrix[bestRow + 1, bestColumn]},  {myMatrix[bestRow + 1, bestColumn + 1]},  {myMatrix[bestRow + 1, bestColumn + 2]}");
            Console.WriteLine($" {myMatrix[bestRow + 2, bestColumn]},  {myMatrix[bestRow + 2, bestColumn + 1]},  {myMatrix[bestRow + 2, bestColumn + 2]}");

            Console.WriteLine($"The best 3*3 platform gives the sum of {bestSum}.");
            Console.WriteLine("\n");
            watch.Stop();
            Console.WriteLine($"Time taken: {watch.ElapsedMilliseconds}ms.");
        }
    }
}
