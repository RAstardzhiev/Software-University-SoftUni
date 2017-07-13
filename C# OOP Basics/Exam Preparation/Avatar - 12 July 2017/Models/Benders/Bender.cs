namespace Avatar___12_July_2017.Models.Benders
{
    public abstract class Bender
    {
        private string name;
        private int power;

        public Bender(string name, int power)
        {
            this.name = name;
            this.power = power;
        }

        protected int Power => this.power;

        protected string Name => this.name;

        public abstract double GetTotalPower();
    }
}
