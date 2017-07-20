namespace _1.Shapes
{
    public class Rectangle : IDrawable
    {
        private double width;
        private double height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.height = value;
            }
        }

        public void Draw()
        {
            this.DrawLine(this.Width, '*', '*');

            for (int i = 1; i < this.Height - 1; ++i)
            {
                this.DrawLine(this.Width, '*', ' ');
            }

            this.DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(double width, char end, char mid)
        {
            OutputWriter.Write(end);

            for (int i = 1; i < width - 1; ++i)
            {
                OutputWriter.Write(mid);
            }

            OutputWriter.WriteLine(end);
        }
    }
}
