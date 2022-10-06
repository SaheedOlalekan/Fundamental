using System;
using System.Collections.Generic;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Write a program that reads five numbers from the console and prints the 
            //     greatest of them.

            Console.Write("Enter the numbers of interger: ");
            int numb = int.Parse(Console.ReadLine());
            List<int> myList = new List<int>();
            

            for (int i = 1; i <= numb; i++)
            {
                Console.Write($"Enter the number {i} : ");
                int number;
                while(!(int.TryParse(Console.ReadLine(), out number)))
                {
                    Console.Write("Kindly enter a number: ");
                }
                myList.Add(number);
            }

            
                foreach(var item in myList)   // To print the list
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine(" ");

                int max = int.MinValue;
               foreach(var item in myList)
               {
                   if(item > max)
                   {
                       max = item;
                   }
               }
                Console.WriteLine($"The largest number is {max}.");
                
        }
    }
}
