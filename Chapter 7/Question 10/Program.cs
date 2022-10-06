using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
             /* 10.Write a program, which finds the most frequently occurring element in 
           an array. Example: { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4(5 times).*/
            Console.Write("\n");
            Console.Write("\t\tTHIS PROGRAM FINDS THE MOST FREQUENTLY OCCURRING ELEMENT IN AN ARRAY. ");
            Console.WriteLine("\n");
            int length;
            Console.Write("Enter the length of the array: ");
            while(!(int.TryParse(Console.ReadLine(), out length)))
            {
                Console.Write("Kindly enter a number: ");
            }

            int[] myArray = new int[length];
            for (int k = 0; k < myArray.Length; k++)
            {
                Console.Write($"Enter the element at index {k}: ");
                myArray[k] = int.Parse(Console.ReadLine());

            }
          
            int count = 0, i = 0, j = 0, number = 0, mostNumber = 0;
            int maxCount = int.MinValue;
            var watch = new System.Diagnostics.Stopwatch();

            for (i = 0; i < myArray.Length; i++)
            {
                watch.Start();  
                for (j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        count++;
                        number = myArray[j];
                        
                    }
                }
               
                if (count > maxCount)
                {
                    maxCount = count;
                    if (number > mostNumber)
                    {
                        mostNumber = number;
                    }
                }
               
                count = 0;
            }
            if(maxCount <=1)
            {
                Console.WriteLine("There is no most frequently occurring element in the array.");
            }
            else
            {
                for (int k = 0; k < maxCount; k++)
                {
                    Console.Write(mostNumber + ", " + " ");
                }
            }
            Console.WriteLine($"are the most occurring elements in the array. {mostNumber}({maxCount} times.)");
            Console.WriteLine(" ");
            watch.Stop();
            Console.WriteLine($"Time taken to execute the program is {watch.ElapsedMilliseconds}ms.");
        }
    }
}
