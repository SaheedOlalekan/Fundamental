using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Define a class Student, which contains the following information about 
            // students: full name, course, subject, university, e-mail and phone 
            // number.
                Student student = new Student();
                student.FullNames = "Olalekan Saheed O.";
                System.Console.WriteLine(student.FullNames);
        }
    }
}
