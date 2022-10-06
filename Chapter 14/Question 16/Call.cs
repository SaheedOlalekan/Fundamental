using System.Collections.Generic;

namespace Question_16
{
    internal class Call
    {
        System.DateTime date;
        System.DateTime timeOfStart;
        System.DateTime durationOfCall;
        List<Call> callHistory; 

        internal System.DateTime DurationOfCall
        {
            get{ return durationOfCall;}
            set{ durationOfCall = value;}
        }

        internal List<Call> CallHistory
        {
            get { return callHistory;}
            set { callHistory = value;}
        }

        internal Call (System.DateTime date, System.DateTime timeOfStart)
        {
            this.date = date;
            this.timeOfStart = timeOfStart;
            this.durationOfCall = durationOfCall + CallDuration();
        }
        internal System.TimeSpan CallDuration()
        {
            System.TimeSpan duration = System.DateTime.Now - timeOfStart;
            return  duration;
        } 
    }
}