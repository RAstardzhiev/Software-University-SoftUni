namespace Avatar___12_July_2017.Models.Benders
{
    public class AirBender : Bender
    {
        private double aerialIntegrity;

        public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
        {
            this.aerialIntegrity = aerialIntegrity;
        }

        public override double GetTotalPower()
        {
            return this.Power * this.aerialIntegrity;
        }

        public override string ToString()
        {
            return $"{this.Name}, Power: {this.Power}, Aerial Integrity: {this.aerialIntegrity:F2}";
        }
    }
}
