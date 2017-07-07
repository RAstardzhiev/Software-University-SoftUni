namespace _2.VehiclesExtension
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelAmount, double fuelConsumption, double airConditioningConsumption, double fuelTankCapacity) 
            : base(fuelAmount, fuelConsumption, airConditioningConsumption, fuelTankCapacity)
        {
        }

        protected override double FuelAmount
        {
            get
            {
                return base.FuelAmount;
            }

            set
            {
                if (value > this.FuelTankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }

                base.FuelAmount = value;
            }
        }
    }
}
