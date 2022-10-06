using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
             // 4. Write an expression that checks whether the third bit in a given integer 
            // is 1 or 0.


             Console.WriteLine("Enter a number:");
             int number4 = int.Parse(Console.ReadLine());
             string binary = Convert.ToString(number4 , 2);
             System.Console.WriteLine(binary);
             bool bit3 = (number4 & 8) != 0;
             if(bit3)
             {
                 System.Console.WriteLine("The third bit of" + " " + number4 + " " + "is 1.");
             }
             else{
                 System.Console.WriteLine("The third bit of" + " " + number4 + " " + "is 0.");
             }

        }
    }
}
