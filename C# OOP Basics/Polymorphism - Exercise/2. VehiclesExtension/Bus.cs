namespace _2.VehiclesExtension
{
    using System;

    class Bus : Vehicle
    {
        private bool isAirConditionerTurnedOn;

        public Bus(double fuelAmount, double fuelConsumption, double airConditioningConsumption, double fuelTankCapacity)
            : base(fuelAmount, fuelConsumption, airConditioningConsumption, fuelTankCapacity)
        {
            this.isAirConditionerTurnedOn = true;
        }

        protected override double FuelAmount
        {
            set
            {
                if (value > this.FuelTankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }

                base.FuelAmount = value;
            }
        }

        public bool IsAirConditionerTurnedOn
        {
            get { return this.isAirConditionerTurnedOn; }
            set { this.isAirConditionerTurnedOn = value; }
        }

        public override string Drive(double distance)
        {
            if (this.isAirConditionerTurnedOn)
            {
                return base.Drive(distance);
            }

            var neededFuel = this.FuelConsumption * distance;

            if (neededFuel > this.FuelAmount)
            {
                return $"Bus needs refueling";
            }

            this.FuelAmount -= neededFuel;
            return $"Bus travelled {distance} km";
        }
    }
}
