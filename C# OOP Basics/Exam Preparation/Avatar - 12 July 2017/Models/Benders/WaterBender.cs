namespace Avatar___12_July_2017.Models.Benders
{
    public class WaterBender : Bender
    {
        private double waterClarity;

        public WaterBender(string name, int power, double waterClarity) : base(name, power)
        {
            this.waterClarity = waterClarity;
        }

        public override double GetTotalPower()
        {
            return this.Power * this.waterClarity;
        }

        public override string ToString()
        {
            return $"{this.Name}, Power: {this.Power}, Water Clarity: {this.waterClarity:F2}";
        }
    }
}
