namespace Question11
{
    internal class GSM
    {
        const string nokiaN95 = "Nokia N95";
        string model;
        string manufacturer;
        double price;
        string owner;
        
        internal string NokiaN95
        {
            get{ return nokiaN95;}
        }
        internal GSM()
        {

        }

        internal GSM(string model)
        {
            this.model = model;
        }

        internal GSM(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        internal GSM(double price, string owner)
        {
            this.price = price;
            this.owner = owner;
        }

        internal GSM(double price, string owner, string model)
        {
            this.price = price;
            this.owner = owner;
            this.model = model;
        }
        
        internal void  DisplayNokiaN95()
        {
            System.Console.WriteLine($"This is a {NokiaN95} phone model.");
        }
    }
}