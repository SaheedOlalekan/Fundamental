namespace Question_2
{
    public class Student
    {
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
            }
        internal Student (string fullNames)
            {
                this.fullNames = fullNames;
            }
        internal Student(University universities, string course, string fullNames)
        {
            this.universities = universities;
            this.course = course;
            this.fullNames = fullNames;  
        }
        internal Student()
        {
            
        }

        internal Student (string PhoneNumber, string Email)
        {
            this.phoneNumber = PhoneNumber;
            this.email = Email;
        }

        public Student(string fullNames, University universities)
        {
            this.fullNames = fullNames;
            this.universities = universities;   
        }

        internal Student(string fullNames, Subject subjects)
        {
            this.fullNames = fullNames;
            this.subjects = subjects;
        }

        internal Student (string fullNames, Subject subjects, University universities)
        {
           this.fullNames = fullNames;
           this.subjects = subjects;
           this.universities = universities;
        }
    }

    internal enum Subject
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