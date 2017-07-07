namespace _1.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelAmount;
        private double fuelConsumption;
        private double airConditioningConsumption;

        public Vehicle(double fuelAmount, double fuelConsumption, double airConditioningConsumption)
        {
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.airConditioningConsumption = airConditioningConsumption;
        }

        public virtual void Refuel(double fuel)
        {
            this.fuelAmount += fuel;
        }

        public string Drive(double distance)
        {
            var neededFuel = (this.fuelConsumption + airConditioningConsumption) * distance;

            if (neededFuel > this.fuelAmount)
            {
                return $"{this.GetType().Name} needs refueling";
            }

            this.fuelAmount -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelAmount:F2}";
        }
    }
}
