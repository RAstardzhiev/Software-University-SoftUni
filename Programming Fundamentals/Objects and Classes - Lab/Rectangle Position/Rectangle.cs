namespace Rectangle_Position
{
    public class Rectangle
    {
        public double Left, Top, Right, Bottom;

        // input: left, top, width, height
        public Rectangle(double left, double top, double width, double height)
        {
            this.Left = left;
            this.Top = top;
            this.Bottom = top - height;
            this.Right = left + width;
        }
    }
}
