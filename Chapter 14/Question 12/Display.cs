namespace Question_12
{
    internal class Display
    {
        string size;
        string colour;

        internal Display()
        {

        }

        internal Display( string size)
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