using System;
using System.Collections.Generic;

namespace Question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //    16. Write a program that by a given integer N prints the numbers from 1 to N 
            //     in random order.
            Console.Write("Enter the number: ");
            int number;
            while(!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write("Kindly enter a number: ");
            }

            Random random = new Random();
            List<int> myList = new List<int>();
            bool cont = true;
            while(cont)
            {
                if (myList.Count == number) 
                        { cont = false; } 
                int roundomNumber = random.Next(1, number + 1);

                if (!myList.Contains(roundomNumber))
                {
                    myList.Add(roundomNumber);
                }
                
            }

            foreach(int num in myList)
            {
                Console.Write($"{num} ");
            }
            

        }
    }
}
