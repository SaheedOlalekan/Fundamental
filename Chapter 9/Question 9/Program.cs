using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FindBiggestElement(new int[]{2,5,7,1,9,0,6,3,4,8});
            FindBiggestElement(new int[]{1,23,67,4,78,90,1246,0});
            FindBiggestElement(new int[]{1,23,67,4,78,90,-1246,0,-67});
        }

        // 9. Write a method that finds the biggest element of an array. Use that 
        // method to implement sorting in descending order.
        static void FindBiggestElement(int [] myNumbers)
        {
            int max = int.MinValue;
            foreach (var item in myNumbers)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            for (int i = 0; i < myNumbers.Length; i++)
            {
                for (int j = i; j < myNumbers.Length ; j++)
                {
                    if(myNumbers[i] < myNumbers[j])
                        {
                            int temp  = myNumbers[j];
                            myNumbers[j] = myNumbers[i];
                            myNumbers[i] = temp;
                        }
                }
            }
            Console.WriteLine($"The biggest element in the array is {max}.");
            Console.Write("The sorted array in descencing order is { ");
            Console.Write(string.Join(",", myNumbers));
            Console.WriteLine(" }");
        }
    }
}
