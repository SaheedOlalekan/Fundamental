namespace Question_9
{
    internal class GSM
    {
        string model;
        string manufacturer;
        double price;
        string owner;

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
    }
}