namespace Question_1
{
    class Student
    {
        string fullNames;
        string course; 
        Subject subjects; 
        University universities; 
        string email; 
        string phoneNumber;

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