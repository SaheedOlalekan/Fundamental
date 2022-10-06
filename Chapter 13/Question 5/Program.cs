using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("\t\t THIS PROGAM PRINTS THE NUMBERS OF SUBSTRING IN THE GIVEN STRING.");
            System.Console.WriteLine();
            System.Console.WriteLine("Enter the string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the keyword to search for: ");
            string keyword = Console.ReadLine();
            text.ToLower();
            keyword.ToLower();
            NumberOfStringInText(text, keyword); 
            Console.WriteLine();
        }

        // 5. Write a program that detects how many times a substring is contained in 
        // the text. For example, let’s look for the substring "in" in the text:
        // We are living in a yellow submarine. We don't have anything 
        // else. Inside the submarine is very tight. So we are drinking 
        // all the day. We will move out of it in 5 days.
        // The result is 9 occurrences.
         static int counter;
        static void NumberOfStringInText(string text, string keyword)
        {
            string quote = text.ToLower();
            int index = quote.IndexOf(keyword);
            
            while (index != -1)
            {
                counter++;
                Console.WriteLine($"{{{keyword}}} is found at index of {index}.");
                index = quote.IndexOf(keyword, index + 1);
            }
            Console.WriteLine();
            Console.WriteLine($"{{{keyword}}} is found in {counter} places in the given string.");
        }
    }
}
