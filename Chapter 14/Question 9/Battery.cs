namespace Question_9
{
    internal class Battery
    {
        string model = null;
        string idleTime = null;
        string hoursTalks = null;

        internal Battery()
        {

        }

        internal Battery(string model)
        {
            this.model = model;
        }

        internal Battery(string model, string idleTime)
        {
            this.model = model;
            this.idleTime = idleTime;
        }

        internal Battery(string model, string idleTime, string hoursTalks)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.hoursTalks = hoursTalks;
        }
    }
}