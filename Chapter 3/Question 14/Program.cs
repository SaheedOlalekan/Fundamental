using System;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {




             //    16. Write a program that by a given integer N prints the numbers from 1 to N 
            //     in random order.
            Console.Write("Enter a positive number: ");
            int number;
            while(!(int.TryParse(Console.ReadLine(), out number) && number > 0))
            {
                Console.Write("Kindly enter a positive number:");
            }
            int [] myArray = new int[number];
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                myArray[i] = i + 1;
              
            } 
            for (int j = 0; j < myArray.Length; j++)
            {
                int roundomNumber = random.Next(1, number + 1);
                int temporary = myArray[j+1];
                myArray[j+1]= myArray[roundomNumber];
                myArray[roundomNumber]= temporary;
                Console.Write(myArray[j +1]);
            }











            /*// 14. Write a program that checks if a given number n (1 < n < 100) is a 
            //  prime number (i.e. it is divisible without remainder only to itself and 1).

            System.Console.Write( "Enter a number between 1 and 100: ");
            int number;
            while(!(int.TryParse(Console.ReadLine(), out number) && number > 0  && number <= 100))
            {
                 System.Console.Write( "Invalid input, Enter a number between 1 and 100: ");
            }
           
            bool isPrime = true;
            for (int i = 2; i < (number/2); i++)
            {
                if(number % i == 0) 
                {
                   isPrime = false;
                   Console.WriteLine($"{number} is not a prime number.");
                   break;
                }   

            }
            if(isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }*/
          
       }
    }
}
