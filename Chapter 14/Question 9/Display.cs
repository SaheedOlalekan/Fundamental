namespace Question_9
{
    public class Display
    {
        string size = null;
        string colour = null;

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