using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 6. Write a class StudentTest, which has to test the functionality of the 
            // class Student.
            Student student = new Student();
            StudentTest studentTest = new StudentTest();
            studentTest.CreateStudent();
        }
    }
}
