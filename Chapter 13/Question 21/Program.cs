using System;

namespace Question_21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n");
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("\t\t THIS PROGRAM EXTRACTS PALINDROME FROM THE GIVEN TEXT.");
            // System.Console.WriteLine("Enter some words: ");
            // string text = Console.ReadLine();
            System.Console.WriteLine();
            ExtractPalindrome("Wow! Mallam Abba, Madam Lawal and Mum are in Lamal civic centre for noon Exe level meeting .");
        }

            // 21. Write a program that extracts from a text all words which are 
            // palindromes, such as ABBA", "lamal", "exe".
        static string palindome;
        static void ExtractPalindrome(string text)
        {
            Char[] separators = {' ', ',', '.', ';', ':', '/', '\\', '!'};
            string[] myText = text.ToUpper().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            System.Console.WriteLine("The palindrome(s) in the given text is/are: ");
            for (int i = 0; i < myText.Length - 1; i++)
            {
                Char[] reversed = myText[i].ToCharArray();
                for (int j = reversed.Length -1; j >= 0; j--)
                {
                    palindome += reversed[j];
                    if (palindome == myText[i])
                    {
                        Console.WriteLine(palindome);
                    }
                }
                palindome = "";
            }
        }
    }
}
