using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Write a Boolean expression that checks whether a given integer is 
            // divisible by both 5 and 7, without a remainder. 

             Console.WriteLine("Enter a number:");
            int number2 = int.Parse(Console.ReadLine());
            bool isDivisible = false;
            if(number2 % 5 == 0 && number2 % 7 == 0){
                System.Console.WriteLine($"{!isDivisible}");
            }
            else{
                System.Console.WriteLine( isDivisible);
            }


        }
    }
}
