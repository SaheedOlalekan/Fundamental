using System;
namespace Question_15
{
    public class Call
    {
        System.DateTime date;
        System.DateTime timeOfStart;
        System.DateTime durationOfCall;

        internal DateTime DurationOfCall
        {
            get{ return durationOfCall;}
            set{ durationOfCall = value;}
        }

        internal Call (DateTime date, DateTime timeOfStart)
        {
            this.date = date;
            this.timeOfStart = timeOfStart;
            this.durationOfCall = durationOfCall + CallDuration();
        }
        internal TimeSpan CallDuration()
        {
            TimeSpan duration = DateTime.Now - timeOfStart;
            return  duration;
        } 
    }
}   