using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine( );
            Console.WriteLine(" Hello World!");

                // 12. Add a method to the class GSM, which returns information about the 
                // object as a string.
            
            GSM gSM = new GSM("Samsung", "Samsung Inc", "Omoboriowo Owootomo", 200000);
            string result = gSM.ToString();
            System.Console.WriteLine(result);
            System.Console.WriteLine();

        }
    }
}
