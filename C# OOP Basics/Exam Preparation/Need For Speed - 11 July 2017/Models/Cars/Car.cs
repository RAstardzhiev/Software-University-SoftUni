namespace Need_For_Speed___11_July_2017.Models.Cars
{
    using System.Text;

    public abstract class Car
    {
        private string brand;
        private string model;
        private int yearOfProduction;
        private int horsepower;
        private int acceleration;
        private int suspension;
        private int durability;

        public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        {
            this.brand = brand;
            this.model = model;
            this.yearOfProduction = yearOfProduction;
            this.horsepower = horsepower;
            this.acceleration = acceleration;
            this.suspension = suspension;
            this.durability = durability;
            this.WaitingRaces = 0;
        }

        public int WaitingRaces { get; set; }

        public string Brand => this.brand;

        public string Model => this.model;

        public int HorsePower => this.horsepower;

        public int Acceleration => this.acceleration;

        public int Suspension => this.suspension;

        public int Durability => this.durability;

        internal void DecreaseDurabilityDueToCircuitRace(int laps, int length)
        {
            this.durability -= laps * (length * length);
        }

        public virtual void Tune(int tuneIndex, string addOn)
        {
            this.horsepower += tuneIndex;
            this.suspension += tuneIndex / 2;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.brand} {this.model} {this.yearOfProduction}")
                .AppendLine($"{this.horsepower} HP, 100 m/h in {this.acceleration} s")
                .AppendLine($"{this.suspension} Suspension force, {this.durability} Durability");

            return sb.ToString().Trim();
        }
    }
}