using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. The gravitational field of the Moon is approximately 17% of that on the 
            // Earth. Write a program that calculates the weight of a man on the 
            // moon by a given weight on the Earth.
            
            System.Console.WriteLine("Enter the man's weight on Earth: ");
            double number = Int64.Parse(Console.ReadLine());
            double weight =  number * ((double)17/100) ;
            System.Console.WriteLine("The weight of the man on the moon is:" + " " + weight + ".");
        }
    }
}
