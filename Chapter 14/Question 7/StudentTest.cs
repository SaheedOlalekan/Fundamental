using System;
using System.Collections.Generic;

namespace Question_7
{
    public class StudentTest
    {
        public static void CreateStudent()
        {
            Student student1 = new Student();
            System.Console.WriteLine(student1.ToString());
            Console.WriteLine();

            Student student2 = new Student("Brilliant Treasure");
            Console.WriteLine(student2.ToString());
            System.Console.WriteLine();

            Student student3 = new Student("Lucky Ojuolape", "ojuolape@yahoo.com");
            Console.WriteLine(student3.ToString());
            System.Console.WriteLine();

            Student student4 = new Student(University.UNILAG, "Cinematography", "Tunde Kelani");
             System.Console.WriteLine(student4.ToString());
            System.Console.WriteLine();

            Student student5 = new Student("brt", University.UNILAG);
            System.Console.WriteLine(student5.ToString());
            System.Console.WriteLine();

            Student student6 = new Student(Subject.AgriculturalScience, Subject.Biology, Subject.Chemistry, Subject.ChristianReligionKnowlede);
            System.Console.WriteLine(student6.ToString());
            System.Console.WriteLine();

            Student student7 = new Student("09087654321","noway4distraction@gmail.com",105); 
            System.Console.WriteLine(student7.ToString());
            System.Console.WriteLine();

            Student student8 = new Student(76, "Wole Olaoye Olanipekun", University.ADELEKE);
            System.Console.WriteLine(student8.ToString());
            System.Console.WriteLine();

            Student student9 = new Student("No Case Names", University.FUNAAB, Subject.Biology, Subject.Economics, Subject.FurtherMathematics);
            System.Console.WriteLine(student9.ToString());
            System.Console.WriteLine();

            Student student10 = new Student("Koloruko", "Yoruba", University.OAU, "koloruko@gmail.com", "09123456789", Subject.YorubaLanguage, Subject.LiteratureInEnglish);
            System.Console.WriteLine(student10.ToString());
            System.Console.WriteLine();

            

            

            

        }    
    }
}