namespace Question_16
{
    public class GSM
    {
        const string nokiaN95 = "Nokia N95";
        string model;
        string manufacturer;
        double? price;
        string owner;

        internal string Model
        {
            get{ return model;}
            set{ model = value;}
        }

        internal string Manufacturer
        {
            get{ return manufacturer;}
            set { manufacturer = value;}   
        }

        internal double? Price
        {
            get { return price;}
            set { price = value;}
        }

        internal string Owner
        {
            get { return owner;}
            set { owner = value;}
        }
        internal  static string NokiaN95
        {
            get { return nokiaN95; }
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
        internal GSM(string model, string manufacturer, string owner, double price )
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }
        internal void DisplayNokiaN95()
        {
            System.Console.WriteLine($" This is a {NokiaN95} phone model.");
        }

        public override string ToString()
        {
            return $" Model: {this.model} Manufacturer: {this.manufacturer} Owner: {this.owner} Price: {this.price}";
        }
    }
}