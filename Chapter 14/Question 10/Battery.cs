namespace Question_10
{
    internal class Battery
    {
         string model;
        string idleTime;
        string hoursTalks;

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