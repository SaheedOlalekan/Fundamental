using System.Collections.Generic;

namespace Question_17
{
    internal class Call
    {
        string date;
        string timeOfStart;
        string durationOfCall;
        List<string> callHistory; 

        internal string DurationOfCall
        {
            get{ return durationOfCall;}
            set{ durationOfCall = value;}
        }

        internal List<string> CallHistory
        {
            get { return callHistory;}
            set { callHistory = value;}
        }

        internal string Date
        {
            get{ return date;}
            set{ date = value;}
        }

        internal string TimeOfStart
        {
            get{ return timeOfStart;}
            set{ timeOfStart = value;}
        }

         internal Call()
        {
            
        }
        internal Call ( string date, string timeOfStart, string durationOfCall)
        {
            this.date = date;
            this.timeOfStart = timeOfStart;
            this.durationOfCall = durationOfCall;
        }

        public override string ToString()
        {
            return $" Date: {this.date} Time Of Call: {this.timeOfStart} Duration: {this.durationOfCall}";
        }

    }
}