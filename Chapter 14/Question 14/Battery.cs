namespace Question_14
{
    internal class Battery
    {
        string model;
        string idleTime;
        string hoursTalks;
        BatteryType batteryType;

        internal string Model 
        {
            get { return model;}
            set { model = value;}
        }

        internal string IdleTime
        {
            get { return idleTime;}
            set { idleTime = value;}
        }

        internal string HoursTalks
        {
            get { return hoursTalks;}
            set { hoursTalks = value;}
        }

        internal BatteryType BatteryType
        {
            get { return batteryType;}
            set { batteryType = value;}
        }
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

        internal Battery(string model, string idleTime, string hoursTalks, BatteryType batteryType)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.hoursTalks = hoursTalks;
            this.batteryType = batteryType;
        }
    }

    internal enum BatteryType
    {
        LiIon = 1,
        NiMH,
        NiCd,
        LithiumIon,
        LithiumPolymer,
    }
}