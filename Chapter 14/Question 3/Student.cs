namespace Question_3
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

        internal Student (string phoneNumber, string Email, int age)
        {
            this.phoneNumber = phoneNumber;
            this.email = Email;
            this.age = age;
            studentCount++;
        }

        Student(int age, string fullNames, University universities)
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
    }

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

    enum University
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