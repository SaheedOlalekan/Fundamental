using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Write a program that finds the biggest of three integers, using nested 
            //     if statements .

           
            Console.Write("Enter the  first number: ");
            int num= int.Parse(Console.ReadLine());
             Console.Write("Enter the second number: ");
            int numb = int.Parse(Console.ReadLine());
             Console.Write("Enter the third number: ");
            int number = int.Parse(Console.ReadLine());
            if(num == numb && num == number)
                {
                    Console.WriteLine("The three numbers are equal.");
                }
            else
            {
                if(num > numb && num > number)
                    {
                        Console.WriteLine($"{num} is the greatest of {num}, {numb} and {number}.");
                    }
                if(numb > num && numb > number)
                    {
                        Console.WriteLine($"{numb} is the greatest of {numb}, {num} and {number}.");
                    }
                if(number > num && number > numb)
                    {
                        Console.WriteLine($"{number} is greatest of {number}, {num} and {numb}.");
                    }



                   Console.Write("Enter the  first number: ");
                    int n1= int.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the third number: ");
                    int n3 = int.Parse(Console.ReadLine());
                    if(n1 > n2)
                    {
                        if(n3 > n1) Console.WriteLine("Biggest: " + n3);
                        else if(n3 < n1) Console.WriteLine("Biggest: " + n1);
                        else Console.WriteLine("Biggest are:" + n1 + " " + n3);
                    }
                    if(n1 < n2)
                    {
                        if(n3 < n2) Console.WriteLine("Biggest: " + n2);
                        else if(n3 > n2) Console.WriteLine("Biggest" + n3);
                        else Console.WriteLine("Biggest:" + n1 + n2);

                    }
                    if(n1 == n2)
                    {
                        if(n3 < n1) Console.WriteLine("Biggest: " + n1, n2 );
                        if(n3 > n1) Console.WriteLine("Biggest:" + n3);
                        else Console.WriteLine("The three numbers are equal.");
                    }

                    
            }
        }   
            
    }
}
