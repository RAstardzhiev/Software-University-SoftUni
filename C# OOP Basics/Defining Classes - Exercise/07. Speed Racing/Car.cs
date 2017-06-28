namespace _07.Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double distanceTravelled;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
            this.distanceTravelled = 0.0;
        }

        public string Model
        {
            get { return this.model; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumptionPerKm
        {
            get { return this.fuelConsumptionPerKm; }
        }

        public double DistanceTravelled
        {
            get { return this.distanceTravelled; }
            set { this.distanceTravelled = value; }
        }

        public void Drive(double kilometers)
        {
            var neededFuel = kilometers * this.fuelConsumptionPerKm;

            if (this.fuelAmount < neededFuel)
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            this.fuelAmount -= neededFuel;
            this.distanceTravelled += kilometers;
        }
    }
}
