using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
          // 6. Write a program that calculates N!/K! for given N and K (1<K<N).

            Console.Write("Enter the K term: ");
            int K;
            while(!(int.TryParse(Console.ReadLine(), out K) && 1 < K))
            {
                Console.Write("Kindly enter a positive number: ");
            }
            Console.Write("Enter the N term: ");
            int N;
            while(!(int.TryParse(Console.ReadLine(), out N) && K < N))
            {
                Console.Write("Kindly enter a greater number: ");
            }
            if(!(1 < K && K < N))
            {
                Console.Write("Kindly enter a number greater than 1 and less than" + " " + N );
            }

            int factorial = 1;
            for (int i = N; i > K; i--)
            {
                factorial *= i;
            }

            Console.Write(factorial);
        }
    }
}
