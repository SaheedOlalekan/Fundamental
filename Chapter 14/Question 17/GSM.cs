using System;
namespace Question_17
{
    internal class GSM
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

        internal void AddCall( )
        {
            Call call1 = new Call("September 6 2022", "5:30PM", "30mins");
            Call call2 = new Call("October 17 2022", "1:45AM", "5mins");
            Call call3 = new Call("January 1 2020", "2:15AM", "1min");
            Call call = new Call();
            Console.WriteLine(new Call("September 6 2022", "5:30PM", "30mins"));
            Console.WriteLine(new Call("October 17 2022", "1:45AM", "5mins"));
            /* call.CallHistory.Add(call1.ToString());
             call.CallHistory.Add(call2.ToString());
             call.CallHistory.Add(call3.ToString());
             foreach (var item in call.CallHistory)
             {
                 Console.WriteLine();
             }

             // call.CallHistory.Add(call1.ToString());
             Console.WriteLine(string.Join("", call1));*/

            int[] myArr = new int[5];
            int[] newArray = new int [20];
            Array.Copy(myArr,newArray, 6);
            myArr = newArray;
            Console.WriteLine(myArr.Length);
            
        }
    }
}