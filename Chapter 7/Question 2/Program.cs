using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
                // 2. Write a program, which reads two arrays from the console and checks 
                // whether they are equal (two arrays are equal when they are of equal 
                // length and all of their elements, which have the same index, are equal).
               
                Console.Write("Enter the length of the first array: ");
                int first = int.Parse(Console.ReadLine());
                int [] firstArray = new int [first];
                for(int i = 0; i < first; i++)
                {
                    Console.Write($"Enter array at index {i + 1}: ");
                    firstArray[i] = int.Parse(Console.ReadLine());
                }
                 Console.Write("Enter the length of the second array: ");
                int second = int.Parse(Console.ReadLine());
                int [] secondArray = new int [second];
                for(int i = 0; i < second; i++)
                {
                    Console.Write($"Enter array at index {i + 1}: ");
                    secondArray[i] = int.Parse(Console.ReadLine());
                }
                bool playOn = true;
                if(firstArray.Length == secondArray.Length)
                {
                   
                    for(int j = 0; j < firstArray.Length; j++)
                    {
                        if(firstArray[j] != secondArray[j])
                        {
                            playOn = false;
                            break;
                            
                        }
                        else
                        {
                            playOn = true;
                        } 
                    }
                    if(playOn == true)
                    {
                        Console.Write("The two arrays are equal.");
                    }
                    if(playOn == false)
                    {
                        Console.WriteLine("The two arrays are not equal."); 
                    }
                }
                else  
                {
                    Console.WriteLine("The two arrays are not equal.");
                }
        }
    }
}
