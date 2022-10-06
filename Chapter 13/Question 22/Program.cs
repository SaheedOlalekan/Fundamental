using System;
using System.Collections.Generic;

namespace Question_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        // 22. Write a program that reads a string from the console and prints in 
        // alphabetical order all letters from the input string and how many 
        // times each one of them occurs in the string.

        static int count;
        static void PrintNumberOfLettersInOrder(string text)
        {
            Char[] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
             'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

             char[] allLetters =  text.ToUpper().ToCharArray();
             Dictionary<char, int> myDictionary = new Dictionary<char, int>();
             for (int i = 0; i < allLetters.Length; i++)
             {
                if(alphabet[i] == allLetters[i])
                {
                    if(!(myDictionary.ContainsKey(alphabet[i])))
                    {
                        myDictionary.Add(alphabet[i], count);
                    }

                    else
                    {
                        count++;
                    }
                }

                 
             }
        }
    }
}
