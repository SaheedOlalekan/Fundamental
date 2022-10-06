namespace Question_12
{
    internal class Battery
    {
        string model;
        string idleTime;
        string hoursTalks;
        BatteryType batteryType;

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