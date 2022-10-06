using System;
using System.Collections.Generic;

namespace Question_6
{
    public class StudentTest
    {
        public void CreateStudent()
        {
            Student student1 = new Student();
            Student student2 = new Student("Olusegun Obasanjo");
            Student student3 = new Student("Olalekan Saheed O","olalekanolalere1804@gmail.com");
            Student student4 = new Student("1234567890"," abc@gmail.com");
            Student student5 = new Student("Oluwole Adeola","oluwole@gmail.com",55); 
            Student student6 = new Student("08097654321", "joebiden@yahoo.com", 60);
            Student student7 = new Student( 76, "Wole Olaoye Olanipekun", University.ADELEKE);
            Student student8 = new Student("Testing Names O", University.FUNAAB, Subject.Biology, Subject.Economics, Subject.FurtherMathematics);
            Student student9 = new Student(University.ALHIKMAH, "Pharmacy", "Abidoye Lukman");
            Student student10 = new Student("John Bidemi", Subject.History, Subject.DataProcessing, Subject.Physics);
            
            List<string> Applicants = new List<string>();
            Applicants.Add(student1.ToString());
            Applicants.Add(student2.ToString());
            Applicants.Add(student3.ToString());
            Applicants.Add(student4.ToString());
            Applicants.Add(student5.ToString());
            Applicants.Add(student6.ToString());
            Applicants.Add(student7.ToString());
            Applicants.Add(student8.ToString());
            Applicants.Add(student9.ToString());
            Applicants.Add(student10.ToString());

            Applicants.ForEach(student=> Console.WriteLine(student));
            
        }
    }
}