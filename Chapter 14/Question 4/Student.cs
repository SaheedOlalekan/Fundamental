using System;
using System.Collections.Generic;

namespace Question_4
{
    class Student
    {
        static int studentCount;
        string fullNames;
        int? age;
        string course;
        Subject subjects;
        University universities;
        string email;
        string phoneNumber;
        
        internal Student(string fullNames, string course, Subject subjects, University universities, string email, string phoneNumber)
            {
                this.fullNames = fullNames;
                this.course = course;
                this.subjects = subjects;
                this.universities = universities;
                this.email = email;
                this.phoneNumber = phoneNumber;
                studentCount++;
            }
        
        internal Student (string fullNames)
            {
                this.fullNames = fullNames;
                studentCount++;
            }
        internal Student(University universities, string course, string FullNames)
        {
            this.universities = universities;
            this.course = course;
            this.fullNames = FullNames;  
            studentCount++;
        }
        internal Student (string course, University universities)
        {
            this.course = course;
            this.universities = universities;
            studentCount++;
        }
        internal Student(string fullNames, string email)
        {
            this.fullNames = fullNames;
            this.email = email;
            studentCount++;
        }
        internal Student()
        {
            studentCount++;
        }

        internal Student (string PhoneNumber, string Email, int age)
        {
            this.phoneNumber = PhoneNumber;
            this.email = Email;
            this.age = age;
            studentCount++;
        }

        internal Student(int age, string fullNames, University universities)
        {
            this.fullNames = fullNames;
            this.universities = universities; 
            studentCount++;  
        }

        internal Student(string fullNames, Subject subjects, University universities)
        {
            this.fullNames = fullNames;
            this.subjects = subjects;
            this.universities = universities;
            studentCount++;
        }

        internal Student (string fullNames, Subject subjects)
        {
            this.fullNames = fullNames;
            this.subjects = subjects;
            studentCount++;
        }

        internal void PrintStudentInfo()
        {
            Student student = new Student();
            Console.Write("\t\t THIS PROGRAM DISPLAYS THE STUDENT'S DETAILS.");
            Console.WriteLine("\n\n");
            Console.Write("Enter your full names: ");
            string fullNames = Console.ReadLine();

            Console.Write("Enter your course: ");
            string course = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine( );
            Console.WriteLine("These are  the recognized Universities: ");
            int counter = 1;
            foreach (var item in Enum.GetNames(typeof(University)))
            {
                Console.WriteLine($"{counter} = {item}");
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Select your preferred university: ");
            int input = int.Parse(Console.ReadLine());
            student.universities = (University)Enum.ToObject(typeof(University), input);
            string selectedUniversity = student.universities.ToString();
            Console.WriteLine();
            Console.Write("Enter the number of subjects to offer: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Console.WriteLine("These are the available subjects: ");
            int count = 1;
            foreach (var item in Enum.GetNames(typeof(Subject)))
            {
                Console.WriteLine($" {count} = {item}");
                count++;
            }
            int[] mySubject = new int[number];
            Console.WriteLine();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Select your subject number {i + 1}:  ");
                mySubject[i] = int.Parse(Console.ReadLine());
            }

            Subject subjects = new Subject();
            List<string> selectedSubjects = new List<string>();
            foreach (var item in mySubject)
            {
                subjects = (Subject)Enum.ToObject(typeof(Subject), item);
                selectedSubjects.Add(subjects.ToString());
            }

            Console.WriteLine("\n");
            Console.WriteLine(" You have successfully registered.\n This is your details: ");
            Console.WriteLine($" Names: {fullNames} \n Course: {course} \n E-mail: {email} \n Phone Number: {phoneNumber}"
            + $" \n Preferred University: {selectedUniversity}");
            Console.Write(" Subjects: ");
            //selectedSubjects.ForEach(subject => Console.Write( subject + ","));
            Console.WriteLine(String.Join( ", ", selectedSubjects));
           
        }
    };

    enum Subject
    {
        EnglishLanguage = 1,
        Mathematics,
        Physics,
        Chemistry,
        Biology,
        AgriculturalScience,
        FurtherMathematics,
        LiteratureInEnglish,
        Goverment,
        History,
        CivicEducation,
        YorubaLanguage,
        Government,
        IslamicReligionKnowledge,
        ChristianReligionKnowlede,
        Economics,
        Marketing,
        PrincipleOfBookKeepingAndAccounting,
        DataProcessing,
        Fishery
    }
    public enum University
    {
        OAU = 1,
        UI,
        FUNAAB,
        FUTA,
        UNIBEN,
        FUOYE,
        UNILORIN,
        BUK,
        LASU,
        LEADCITY,
        MINARET,
        REDEEMERS,
        BOWEN,
        CONVENANT,
        OOU,
        ADELEKE,
        FOUNTAIN,
        UNIOSUN,
        LAUTECH,
        ALHIKMAH,
        UNILAG,
        BABCOCK,
    }
}