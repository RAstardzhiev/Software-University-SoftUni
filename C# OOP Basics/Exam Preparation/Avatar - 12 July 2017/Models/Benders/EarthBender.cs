namespace Avatar___12_July_2017.Models.Benders
{
    public class EarthBender : Bender
    {
        private double groundSaturation;

        public EarthBender(string name, int power, double groundSaturation) : base(name, power)
        {
            this.groundSaturation = groundSaturation;
        }

        public override double GetTotalPower()
        {
            return this.Power * this.groundSaturation;
        }

        public override string ToString()
        {
            return $"{this.Name}, Power: {this.Power}, Ground Saturation: {this.groundSaturation:F2}";
        }
    }
}
