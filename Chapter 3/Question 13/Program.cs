using System;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //     13. We are given the number n, the value v (v = 0 or 1) and the position p. 
            //     write a sequence of operations that changes the value of n, so the bit on 
            //     the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
            //     Another example: n=35, p=2, v=1 -> n=39.

                Console.Write("Enter a number:");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter a value between 0 and 1:");
                int v = int.Parse(Console.ReadLine());
                Console.Write("Enter a position:");
                int p = int.Parse(Console.ReadLine());
                int power =(int) Math.Pow(2,p);
                string binary = Convert.ToString(n, 2);
                Console.WriteLine($"{n} in binary number is {binary}.");
                int Value = (n & power);
                int pValue = (n + power);
                int nValue = (n - power);
                int result = v == 0 ? pValue : nValue;
                Console.WriteLine($"The new number is {result}.");



        }
    }
}
