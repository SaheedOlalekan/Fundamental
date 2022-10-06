using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the first input: ");
            int numOne = int.Parse(Console.ReadLine());
            System.Console.Write("Enter the second input: ");
            int numTwo = int.Parse(Console.ReadLine());
            System.Console.Write("Enter the third input: ");
            string numThree = Console.ReadLine();

            //Console.WriteLine(GetMax(GetMax(numOne,numTwo), numThree));
           //Console.WriteLine( GetMaximum<string>(numOne, numTwo));
            var result = GetMaximum<int>(numOne, numTwo);
            if(result.Equals(numOne))
            {
                System.Console.WriteLine($"{numOne} is greater than {numTwo} ");
            }
            else if (result.Equals(numTwo))
            {
                System.Console.WriteLine($"{numTwo} is greater than {numOne} ");
            }
            else
            {
                System.Console.WriteLine("Both inputs are Equal ");
            }
        }

            // 2. Create a method GetMax() with two integer (int) parameters, that 
            // returns maximal of the two numbers. Write a program that reads three 
            // numbers from the console and prints the biggest of them. Use the 
            // GetMax() method you just created. Write a test program that validates 
            // that the methods works correctly.
        static int GetMax(int numberOne, int numberTwo)
        {
            int greaterNumber = 0;
            if(numberOne > numberTwo)
            {
                greaterNumber = numberOne;
            }
            else
            {
                greaterNumber = numberTwo;
            }
            return greaterNumber;
        }
        static T GetMaximum<T>( T a, T b) where T : IComparable<T>
        {
            T greater = default(T);
            int great = a.CompareTo(b);
           // greater = a.CompareTo(b);
           if(great == -1)
           {
               return b;
           }
           else if(great == 1)
           {
                return a;
           }
           else
           {
               return  greater;
           }
       }
    }
}
