namespace Avatar___12_July_2017.Models.Benders
{
    public class FireBender : Bender
    {
        private double heatAggression;

        public FireBender(string name, int power, double heatAggression) : base(name, power)
        {
            this.heatAggression = heatAggression;
        }

        public override double GetTotalPower()
        {
            return this.Power * this.heatAggression;
        }

        public override string ToString()
        {
            return $"{this.Name}, Power: {this.Power}, Heat Aggression: {this.heatAggression:F2}";
        }
    }
}
