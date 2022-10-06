using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program, which creates an array of 20 elements of type 
            // integer and initializes each of the elements with a value equals to the 
            // index of the element multiplied by 5. Print the elements to the console.
            Console.WriteLine("\n\n");
            for(int i = 1; i <= 20; i++)
            {
                Console.Write(i * 5);
                Console.Write(" ");
            }
        }
    }
}
