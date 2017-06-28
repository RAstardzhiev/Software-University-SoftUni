namespace _08.Raw_Data
{
    public class Tire
    {
        private int age;
        private double pressure;

        public Tire(int age, double pressure)
        {
            this.age = age;
            this.pressure = pressure;
        }

        public int Age
        {
            get { return this.age; }
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
    }
}
