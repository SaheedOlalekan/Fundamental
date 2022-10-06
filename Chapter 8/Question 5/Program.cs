using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
           //5.Write a program that converts a binary number to decimal one.
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\tTHIS PROGRAM CONVERTS BINARY NUMBER TO DECIMAL NUMBER");
            var watch = new System.Diagnostics.Stopwatch();
            string save = "";
            Console.Write("Enter a number in binary number format: ");
            
            string num = Console.ReadLine();
            
            char[] numOfArray = num.ToCharArray();
            watch.Start();
            for (int i = numOfArray.Length - 1; i >= 0; i--)
            {
                
                save += numOfArray[i];
            }
            char[] reversedArray = save.ToCharArray();

            int digit = 0;
            int placeValue = 1;
            int decimalNumber = 0;

            foreach (var item in reversedArray)
            {
                if (item == '0')
                {
                    digit = 0;
                }
                if (item == '1')
                {
                    digit = 1;
                }
                decimalNumber += digit * placeValue;

                placeValue *= 2;

            }
            Console.WriteLine(string.Join("", decimalNumber));
            watch.Stop();
            Console.Write($"Execution Time:{watch.ElapsedMilliseconds}ms.");



             //     SECOND APPROACH
            Console.WriteLine("\n\n");
            Console.Write("Enter a number in binary format: ");
            long binary = long.Parse(Console.ReadLine());
            long remainder = 0, keep4Me = 0, decimalNumb = 0;
            placeValue = 1;
            watch.Start();
            while (binary > 0)
            {
                remainder = binary % 10;
                keep4Me = remainder * placeValue;
                decimalNumb += keep4Me;
                binary = binary / 10;
                placeValue *= 2;
            }
            Console.WriteLine(decimalNumb);
            watch.Stop();
            Console.WriteLine($"Time Taken: {watch.ElapsedMilliseconds}ms.");
        }
    }
}
