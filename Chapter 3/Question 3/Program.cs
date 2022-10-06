using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Write an expression that looks for a given integer if its third digit (right 
            // to left) is 7.

             Console.WriteLine("Enter a number:");
             int number3 = int.Parse(Console.ReadLine());
            // if((number3 % 1000)/ 100 == 7)
            // //  {
            // //      Console.WriteLine("The third number of " + number3 + " is 7.");
            // //  }
            // //  else
            // //  {
            // //     System.Console.WriteLine("The third number of " + number3 + " is Not 7. ");

            // //  }

            //                     //Other Way
            int numb = number3 / 100;
            int num = (numb % 10);
            if(num == 7)
            {
                 Console.WriteLine("The third number of " + number3 + " is 7.");
            }
            else
            {
                 System.Console.WriteLine("The third number of " + number3 + " is Not 7. ");
            }

        }
    }
}
