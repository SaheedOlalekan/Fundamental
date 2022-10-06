using System;
using System.Numerics;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Write a program that calculates N!*K!/(N-K)! for given N and K 
            // (1<K<N).


            Console.Write("Enter a value of K term: ");
            int K;
            while (!(int.TryParse(Console.ReadLine(), out K)))
            {
                Console.WriteLine("Invalid input, Kindly enter a positive number: ");
            }

            Console.Write("Enter a value of N term: ");
            int N;
            while (!(int.TryParse(Console.ReadLine(), out N) && N > K))
            {
                Console.WriteLine("Kindly enter a  greater number: ");
            }
            BigInteger nFactorial = 1;
            for (int i = N; i >= 1; i--)
            {
                nFactorial *= i;
            }

            BigInteger kFactorial = 1;
            for (int i = K; i >= 1; i--)
            {
                kFactorial *= i;
            }
            BigInteger dFactorial = 1;
            int denominator = N - K;
            for (int i = denominator; i >= 1; i--)
            {
                dFactorial *= i;
            }

            BigInteger result = (nFactorial * kFactorial) / dFactorial;
            Console.WriteLine("Combination = " + result);
        }

        
    }
}
