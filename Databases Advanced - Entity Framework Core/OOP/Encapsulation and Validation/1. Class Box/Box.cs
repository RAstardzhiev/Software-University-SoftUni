namespace _1.Class_Box
{
    using System;

    public class Box
    {
        private const string SideValidationExceptionMessage = "{0} cannot be zero or negative.";

        private double length;
        private double height;
        private double width;

        public Box(double length, double height, double width)
        {
            this.Length = length;
            this.Height = height;
            this.Width = width;
        }

        public double Length
        {
            get => this.length;

            private set
            {
                this.NonZereoOrLessValidation(value, nameof(this.Length));
                this.length = value;
            }
        }

        public double Height
        {
            get => height;

            private set
            {
                this.NonZereoOrLessValidation(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double Width
        {
            get => width;

            private set
            {
                this.NonZereoOrLessValidation(value, nameof(this.Width));
                this.width = value;
            }
        }

        public double GetSurfaceArea() 
            => (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        public double GetLateralSurfaceArea() 
            => (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

        public double GetVolume() 
            => this.Length * this.Width * this.Height;

        private void NonZereoOrLessValidation(double value, string propName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(string.Format(SideValidationExceptionMessage, propName));
            }
        }
    }
}
