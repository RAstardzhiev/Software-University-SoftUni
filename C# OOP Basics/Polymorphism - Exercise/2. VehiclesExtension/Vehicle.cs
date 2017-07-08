namespace _2.VehiclesExtension
{
    using System;

    public abstract class Vehicle
    {
        private double fuelAmount;
        private double fuelConsumption;
        private double fuelTankCapacity;
        private double airConditioningConsumption;

        public Vehicle(double fuelAmount, double fuelConsumption, double airConditioningConsumption, double fuelTankCapacity)
        {
            this.fuelTankCapacity = fuelTankCapacity;
            this.FuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;            
            this.airConditioningConsumption = airConditioningConsumption;
        }

        protected virtual double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }

                this.fuelAmount = value;
            }
        }

        protected double FuelTankCapacity => this.fuelTankCapacity;

        protected double FuelConsumption => this.fuelConsumption;

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            this.FuelAmount += fuel;
        }

        public virtual string Drive(double distance)
        {
            var neededFuel = (this.FuelConsumption + this.airConditioningConsumption) * distance;

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
