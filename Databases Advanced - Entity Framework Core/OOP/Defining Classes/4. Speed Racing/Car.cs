namespace _4.Speed_Racing
{
    using System;

    public class Car
    {
        private const string InsufficientFuelExceptionMessage = "Insufficient fuel for the drive";

        private const double InitialDistanceTravelled = 0;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            DistanceTravelled = InitialDistanceTravelled;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double DistanceTravelled { get; set; }

        public void Moove(double distance)
        {
            var neededFuel = distance * this.FuelConsumptionPerKm;
            if (neededFuel > this.FuelAmount)
            {
                throw new InvalidOperationException(InsufficientFuelExceptionMessage);
            }

            this.FuelAmount -= neededFuel;
            this.DistanceTravelled += distance;
        }

        public override string ToString() => $"{this.Model} {this.FuelAmount:F2} {this.DistanceTravelled}";
    }
}
