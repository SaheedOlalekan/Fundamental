using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Write a program that reads two numbers from the console and prints the 
            // greater of them. Solve the problem without using conditional 
            // statements.

            Console.Write("Enter the first number: ");
            int numb1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int numb2 = int.Parse(Console.ReadLine());
            int max = numb1 > numb2? numb1 : numb2;  // Using of Ternary Method
            Console.WriteLine($"The greater of the the two numbers is {max}.");
            int greater = Math.Max(numb1, numb2); // Using of function of class Math.Max
            int smaller = Math.Min(numb1, numb2); // Using of function  of class Math.Min          
            Console.WriteLine($"The greater of the numbers is {greater}.");
            int larger = (numb1 + numb2 + Math.Abs(numb1 - numb2)) /2;   // Using of function of Math.Abs
            int smaller2 = (numb1 + numb2 - Math.Abs(numb1 - numb2)) / 2; // Using of function of Math.Abs
            Console.WriteLine($"Greater number: {larger}."); 
           // Console.WriteLine($"Smaller number: {smaller2}.");


           



        }
    }
}
