using System;

namespace Chapter_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int startPoint = 2;
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write((startPoint = i) + ",");
                }
                else
                {
                    Console.Write( " " +(startPoint = i * (-1)) + " ," + " ");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // This is another way of attemting the question.

            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("" + i + " , ");
                }
                else
                {
                    Console.Write( "-" + i + " ,");
                }
            }

        }
    }
}
