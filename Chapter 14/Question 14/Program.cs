using System;
using System.Collections.Generic;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            Console.WriteLine(" Hello World!");

            // 14. Write a class GSMTest, which has to test the functionality of class GSM. 
            // Create few objects of the class and store them into an array. Display 
            // information about the created objects. Display information about the 
            // static field nokiaN95.

            GSMTest gSMTest = new GSMTest();
            gSMTest.CreateStudent();
            GSM gsm = new GSM();
            gsm.DisplayNokiaN95();
            System.Console.WriteLine();
            
        }
    }
}
