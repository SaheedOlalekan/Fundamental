using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Write a program that prints all possible cards from a standard deck
            // of cards, without jokers (there are 52 cards: 4 suits of 13 cards)

            for (int i = 1; i <= 4; i++)
            {
                if(i != 0) Console.WriteLine();
                for (int j = 1; j <= 13; j++)
                {
                    switch(i)
                    {
                        case 1: Console.Write("Clubs" + " "); break;
                        case 2: Console.Write("Diamonds" + " "); break;
                        case 3: Console.Write("Hearts" + " "); break;
                        case 4: Console.Write("Spades" + " "); break;
                    }
                    switch(j)
                    {
                        case 1: Console.WriteLine("A"); break;
                        case 2: Console.WriteLine("2"); break;
                        case 3: Console.WriteLine("3"); break;
                        case 4: Console.WriteLine("4"); break;
                        case 5: Console.WriteLine("5"); break;
                        case 6: Console.WriteLine("6"); break;
                        case 7: Console.WriteLine("7"); break;
                        case 8: Console.WriteLine("8"); break;
                        case 9: Console.WriteLine("9"); break;
                        case 10: Console.WriteLine("10");break;
                        case 11: Console.WriteLine("J"); break;
                        case 12: Console.WriteLine("K"); break;
                        case 13: Console.WriteLine("Q"); break;           
                                 
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
