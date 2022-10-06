using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        { // 3. Write a program, which compares two arrays of type char
            // lexicographically (character by character) and checks, which one is first 
            // in the lexicographical order.

            Console.WriteLine("\n");
            Console.WriteLine("\tTHIS PROGRAM COMPARES TWO ARRAY LEXICOGRAPHICALLY.");
            Console.Write("Enter the length of the first array: ");
            int firstLength;
            while (!(int.TryParse(Console.ReadLine(), out firstLength)))
            {
                Console.Write("Kindly enter a number: ");
            }
            char[] arrayOne = new Char[firstLength];
            for (int a = 0; a < firstLength; a++)
            {
                Console.Write($"Enter the element at index {a}: ");
                arrayOne[a] = char.Parse(Console.ReadLine());
            }
            Console.Write("Enter the length of the second array: ");
            int secondLength;
            while (!(int.TryParse(Console.ReadLine(), out secondLength)))
            {
                Console.Write("Kindly enter a number: ");
            }
            char[] arrayTwo = new Char[secondLength];
            for (int b = 0; b < secondLength; b++)
            {
                Console.Write($"Enter the element at index {b}: ");
                arrayTwo[b] = char.Parse(Console.ReadLine());
            }
            int smaller = (firstLength + secondLength - Math.Abs(firstLength - secondLength)) / 2; ;
            int i = 0;
            Console.WriteLine("\n");
            for (i = 0; i < smaller; i++)
            {

                if (arrayOne[i] != arrayTwo[i])
                {
                    if (arrayOne[i] < arrayTwo[i])
                    {
                        Console.WriteLine("Array One comes first before array two in lexicographical order.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Array two comes first before array one in lexicographical order.");
                        break;
                    }

                }
                else
                {

                    if (i == arrayOne.Length - 1 && i != arrayTwo.Length - 1)
                    {
                        Console.WriteLine("Array One comes first before array two in lexicographical order.");
                        break;
                    }
                    else if (i == arrayTwo.Length - 1 && i != arrayOne.Length - 1)
                    {
                        Console.WriteLine("Array two comes first before array one in lexicographical order.");
                        break;
                    }
                    else
                    if(i == arrayOne.Length - 1 && i == arrayTwo.Length - 1)
                    {
                       
                        Console.WriteLine("The two arrays are equal.");
                    }

                }   

            }  
            Console.WriteLine("\n"); 

            // THIS APPROACCH ALSO SOLVE THE QUESTION

             /* Console.Write("Enter the length of the first array: ");
             int firstLength;
             while (!(int.TryParse(Console.ReadLine(), out firstLength)))
             {
                 Console.WriteLine("Kindly enter a number: ");
             }
             char[] myArray1 = new char[firstLength];
             for (int i = 0; i < firstLength; i++)
             {
                 Console.Write($"Enter the array at index {i}:");
                 myArray1[i] = char.Parse(Console.ReadLine());
             }
             Console.Write("Enter the length of the second array: ");
             int secondLength;
             while (!(int.TryParse(Console.ReadLine(), out secondLength)))
             {
                 Console.Write("Kindly enter a number: ");
             }
             
             char[] myArray2 = new char[secondLength];
             for (int i = 0; i < secondLength; i++)
             {
                 Console.Write($"Enter the array at index {i}:");
                 myArray2[i] = char.Parse(Console.ReadLine());
             }

             int smaller = (firstLength + secondLength - Math.Abs(firstLength - secondLength)) / 2;
             bool result1 = false;
             bool result2 = false;
             int count = 0;
             for (int i = 0; i < smaller; i++)
             {

                 if (myArray1[i] < myArray2[i])
                 {
                     result1 = true;
                     break;
                 }
                 else if (myArray1[i] > myArray2[i])
                 {
                     result2 = true;
                     break;
                 }
                 else
                 {
                     count++;
                 }      
             }

             if (count == smaller && myArray1.Length == smaller && myArray2.Length > smaller)
             {
                 Console.WriteLine("Array 1 comes first before Array 2 in lexicographical order.");
             }
             else if (count == smaller && myArray2.Length == smaller && myArray1.Length > smaller)
             {
                 Console.WriteLine("Array 2 comes first before Array 1 in lexicographical order.");
             }
             else if (result1)
             {
                 Console.WriteLine("Array 1 comes first before Array 2 in lexicographical order.");
             }
             else if (result2)
             {
                 Console.WriteLine("Array 2 comes first before myArray 1 in lexicographical order.");
             }
             else
             {

                 Console.WriteLine("The two arrays are equal.");
             }

         }*/
              
        }
    }
}
