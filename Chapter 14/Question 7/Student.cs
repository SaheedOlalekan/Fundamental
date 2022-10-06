using System;
using System.Collections.Generic;

namespace Question_7
{
    public class Student
    {
        static int studentCount;
        static string fullNames;
        static int? age;
        static string course;
        static Subject[] subjects;
        static University? university;
        static string email;
        static string phoneNumber;
        public static string FullNames
        {
            get{ return fullNames;}
            set{ fullNames = value;}
        }
        public static string Course
        {
            get{ return course;}
            set{ course = value;}
        }
        public static int? Age
        {
            get{ return age;}
            set{ age = value;}
        }
        public static string Email
        {
            get{ return email;}
            set{ email = value;}
        }
        public  static Subject[] Subjects
        {
            get{ return subjects;}
            set{ subjects = value;}
        }
        public static University? Universities
        {
            get{ return university;}
            set{ university = value;}
        }
        public string PhoneNumber
        {
            get { return phoneNumber;}
            set { phoneNumber = value;}
        }
       
        static Student()
        {
            studentCount++;
        }
        internal Student()
        {
            studentCount++;
        }
        internal Student (string fullNames)
        {
            FullNames = fullNames;
            studentCount++;
        }
        internal Student(string fullNames, string email)
        {
            FullNames = fullNames;
            Email = email;
            studentCount++;
        }
        internal Student(University universities, string course, string fullNames)
        {
            Universities = universities;
            Course = course;
            FullNames = fullNames;
            studentCount++;
        }
        internal Student (string course, University universities)
        {
            Course = course;
            Universities = universities;
            studentCount++;
        }
        internal Student (params Subject[] subjects)
        {
            Subjects = subjects;
            studentCount++;
        }
        internal Student (string phoneNumber, string email, int age)
        {
            PhoneNumber = phoneNumber;
            Email = email;
            Age = age;
            studentCount++;
        }
        internal Student(int age, string fullNames, University universities)
        {
            FullNames = fullNames;
            Universities = universities;
            studentCount++;
        }
        internal Student(string fullNames, University universities, params Subject[] subjects)
        {
            FullNames = fullNames;
            Subjects = subjects;
            Universities = universities;
            studentCount++;
        }
        internal Student(string fullNames, string course, University universities, string email, string phoneNumber, params Subject[] subjects)
        {
            FullNames = fullNames;
            Course = course;
            Subjects = subjects;
            Universities = universities;
            Email = email;
            PhoneNumber = phoneNumber;
            studentCount++;
        }
        
        public  override string ToString()
        {
            return $"{FullNames} {Age} {Course}  " +
             $"{Email} {university.ToString()} {ListOfSubjects(Subjects)} {PhoneNumber}";
        }
        
        
        public static string ListOfSubjects( Subject[] subjects)
        {
            string mySubjects = string.Empty;
            if(subjects != null)
            {
                for (int i = 0; i < subjects.Length; i++)
                {
                    mySubjects += subjects[i] + ", ";
                }
            }
           return mySubjects;
        }
       /* public static void PrintStudentInfo()
        {
            Student student = new Student();
            Console.Write("\t\t THIS PROGRAM DISPLAYS THE STUDENT'S DETAILS.");
            Console.WriteLine("\n");

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
            Console.WriteLine("These are the recognized Universities: ");
            int counter = 1;
            foreach (var item in Enum.GetNames(typeof(University)))
            {
                Console.WriteLine($"{counter} = {item}");
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine("Select your preferred university: ");
            int input = int.Parse(Console.ReadLine());
            University university = (University)Enum.ToObject(typeof(University), input);
            string selectedUniversity = university.ToString();
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
           
        }*/
    }

    public enum Subject
    {
        EnglishLanguage = 1,
        Mathematics,
        Physics,
        Chemistry,
        Biology,
        AgriculturalScience,
        FurtherMathematics,
        LiteratureInEnglish,
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