using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 5. Write a program, which finds the maximal sequence of consecutively 
            // placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\tTHIS PROGRAM FINDS THE MAXIMAL SEQUENCE OF CONSECUTIVE PLACED INCREASING INTEGERS");
            Console.WriteLine("\n");
            Console.Write("Enter the length of the array: ");
            int number; 
            while(!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.Write("Kindly enter an integer value: ");
            }
            int [] myNumber = new int[number];
            for(int i = 0; i < number; i++)
            {
                Console.Write($"Enter element at index {i + 1}: ");
                myNumber[i] = int.Parse(Console.ReadLine());
            }
            
            int currentCount = 1;
            int maxCount = int.MinValue;
            int nextNumb = 0;
            int numb = 0;
            for(int i = 0; i < myNumber.Length - 2; i++ )
            {
                if((myNumber[i+1] - myNumber[i]) != (myNumber[i+2] - myNumber[i+1]))
                {
                        currentCount = 1;
                }
                else if((myNumber[i+1] - myNumber[i]) == (myNumber[i+2] - myNumber[i+1]))
                {
                   currentCount++;
                   if(currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            nextNumb = myNumber[i + 1];
                            numb = nextNumb;

                        }  
                           
                }
 
            }
            for( int i = myNumber.Length;myNumber.Length > maxCount ; i--)
            {
                Console.WriteLine( numb + " ");
            }
        }
    }
}
