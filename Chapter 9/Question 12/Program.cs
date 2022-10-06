using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SumOfPolynomials(new int[]{4,2,5,3}, new int[]{7, 2}));
        }

            //  12. Write a method that calculates the sum of two polynomials with integer 
            // coefficients, for example (3x2 + x - 3) + (x - 1) = (3x2 + 2x - 4).

        static int SumOfPolynomials(int[] myArray, int [] myNumbers)
        {
            // Console.WriteLine("Enter the values of ax^2 + x - c"); 

            // for (int i = 0; i < 4; i++)
            // {
            //     if(i == 0)
            //     {
            //         Console.Write("Enter the coefficient of x^2,(a):");
            //         myArray[i] = int.Parse(Console.ReadLine());
            //     }
            //      if(i == 1)
            //     {
            //         Console.Write("Enter the value of x :");
            //         myArray[i] = int.Parse(Console.ReadLine());
            //     }
            //      if(i == 2)
            //     {
            //         Console.Write("Enter the coefficient of x,(b):");
            //         myArray[i] = int.Parse(Console.ReadLine());
            //     }
            //      if(i == 3)
            //     {
            //         Console.Write("Enter the constant(c):");
            //         myArray[i] = int.Parse(Console.ReadLine());
            //     }  
               
            // }
            // Console.WriteLine("Enter the values of the polynomial (x - k): ");
            //  for (int i = 0; i < 3; i++)
            //     {
            //         if(i == 0)
            //         {
            //             Console.Write("Enter the coefficient of x of the polynomial(x): ");
            //             myNumbers[i] = int.Parse(Console.ReadLine());
            //         }
            //         if(i == 1)
            //             {
            //                 Console.Write("Enter the constant(k) of the polynomial(k): ");
            //                 myNumbers[i] = int.Parse(Console.ReadLine());
            //             }
                 
            //     }

                int a = 0, b = 0, c = 0, result = 0; 
                a = myArray[0] * myArray[1] * myArray[1];
                b = (myArray[2] + myNumbers[0]) * myArray[1];
                c = (myArray[3] * - 1) + (myNumbers[1] * - 1);
                result = a + b + c;
                return result;

        }
    }
}
