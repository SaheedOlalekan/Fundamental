namespace Question_15
{
    internal class Display
    {
        string size;
        string colour;

        internal string Size
        {
            get { return size; }
            set { size = value; }
        }

        internal string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        internal Display()
        {

        }

        internal Display(string size)
        {
            this.size = size;
        }

        internal Display(string size, string colour)
        {
            this.size = size;
            this.colour = colour;
        }
    }
}