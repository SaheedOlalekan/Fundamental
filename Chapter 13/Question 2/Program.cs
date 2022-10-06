using System;
using System.Text;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("\n");
            System.Console.WriteLine("\t\tTHIS PROGARAM REVERSES THE GIVEN TEXT.");
            System.Console.Write("Enter a word: ");
            string text = Console.ReadLine();
            PrintReverseString(text);

                // 2. Write a program that reads a string, reverse it and prints it to the 
                // console. For example: "introduction"  "noitcudortni".
        }

        static void PrintReverseString(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = text.Length -1; i >= 0; i--)
            {
               (stringBuilder.Append(text[i])).ToString();
            }
            System.Console.WriteLine(stringBuilder.ToString().ToUpper());
        }
    }
}
