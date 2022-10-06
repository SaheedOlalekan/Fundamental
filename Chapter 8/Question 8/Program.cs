using System;
using System.Collections.Generic;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
             // 8.Write a program that converts a hexadecimal number to binary one.

             Console.WriteLine("\n\n");
             Console.WriteLine("\t\tTHIS PROGRAM CONVERTS HEXADECIMAL NUMBER TO BINARY NUMBER");
             Console.WriteLine( "\n");
             Console.Write("Enter a number in hexadecimal format:");
             string hex = Console.ReadLine();
             string hexa = hex.ToUpper();
             var hexArray = hexa.ToCharArray();
             int hexNumber = 0;
             var hexadecimalNumber = new List<int>();

             // To convert the User's input to hexadecimal number:
             for (int i = 0; i < hexArray.Length; i++)
             {
                 if(hexArray[i] == '0')
                 {
                     hexNumber = 0;
                 }
                 if (hexArray[i] == '1')
                 {
                     hexNumber = 1;
                 }
                 if (hexArray[i] == '2')
                 {
                     hexNumber = 2;
                 }
                 if (hexArray[i] == '3')
                 {
                     hexNumber = 3;
                 }
                 if (hexArray[i] == '4')
                 {
                     hexNumber = 4;
                 }
                 if (hexArray[i] == '5')
                 {
                     hexNumber = 5;
                 }
                 if (hexArray[i] == '6')
                 {
                     hexNumber = 6;
                 }
                 if (hexArray[i] == '7')
                 {
                     hexNumber = 7;
                 }
                 if (hexArray[i] == '8')
                 {
                     hexNumber = 8;
                 }
                 if (hexArray[i] == '9')
                 {
                     hexNumber = 9;
                 }
                 if (hexArray[i] == 'A')
                 {
                     hexNumber = 10;
                 }
                 if (hexArray[i] == 'B')
                 {
                     hexNumber = 11;
                 }
                 if (hexArray[i] == 'C')
                 {
                     hexNumber = 12;
                 }
                 if (hexArray[i] == 'D')
                 {
                     hexNumber = 13;
                 }
                 if (hexArray[i] == 'E')
                 {
                     hexNumber = 14;
                 }
                 if (hexArray[i] == 'F')
                 {
                     hexNumber = 15;
                 }

                 hexadecimalNumber.Add(hexNumber);
             }

             // To  Convert to base 10
             int positionValue = 1, decNumber = 0, result = 0;
             hexadecimalNumber.Reverse();
             for (int i = 0; i < hexadecimalNumber.Count; i++)
             {
                 decNumber = hexadecimalNumber[i] * positionValue;
                 result += decNumber;
                 positionValue *= 16;
             }

             //To Convert to binary base

             int remainder = 0;
             var binaryNumber = new List<int>();
             while(result > 0)
             {

                 remainder = result % 2;
                 result = result / 2;
                 binaryNumber.Add(remainder);
             }

             
             Console.Write($"{hexa} in binary number is: ");
             binaryNumber.Reverse();
             Console.Write(string.Join("", binaryNumber));
             Console.WriteLine(" ");
             
            // binaryNumber.ForEach(each => Console.Write(each));



             // ============================================================================================================   


             /*// 8.Write a program that converts a hexadecimal number to binary one.

            
            Console.WriteLine("\t\tTHIS PROGRAM CONVERTS HEXADECIMAL NUMBER TO DECIMAL NUMBER");
            Console.WriteLine("\n");
            Console.Write("Enter the number in hexadecimal format: ");
            string numb = Console.ReadLine();
            string number = numb.ToUpper();
            var decimalNumber = new List<int>();
            int output = 0;
            var remainder = new char[number.Length];
            remainder = number.ToCharArray();
            foreach (var item in remainder)
            {
                if (item == '0')
                {
                    output = 0;
                }
                if (item == '1')
                {
                    output = 1;
                }
                if (item == '2')
                {
                    output = 2;
                }
                if (item == '3')
                {
                    output = 3;
                }
                if (item == '4')
                {
                    output = 4;
                }
                if (item == '5')
                {
                    output = 5;
                }
                if (item == '6')
                {
                    output = 6;
                }
                if (item == '7')
                {
                    output = 7;
                }
                if (item == '8')
                {
                    output = 8;
                }
                if (item == '9')
                {
                    output = 9;
                }
                if (item == 'A')
                {
                    output = 10;
                }
                if (item == 'B')
                {
                    output = 11;
                }
                if (item == 'C')
                {
                    output = 12;
                }
                if (item == 'D')
                {
                    output = 13;
                }
                if (item == 'E')
                {
                    output = 14;
                }
                if (item == 'F')
                {
                    output = 15;
                }
                decimalNumber.Add(output);
            }


            int placeValue = 1, decNumber = 0, result = 0;
            for (int i = decimalNumber.Count - 1; i >= 0; i--)
            {
                decNumber = decimalNumber[i] * placeValue;
                placeValue *= 16;
                result += decNumber;
            }
             


            
           

            int remainder2 = 0;
            var keep4me = new Stack();
            int staysafe = result;
            while (result > 0)
            {
                remainder2 = result % 2;
                result = result / 2;
                keep4me.Push(remainder2);
            }


            Console.Write($"{numb} converts to binary number is: ");
            foreach (var item in keep4me)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n\n");*/
        }
    }
}
