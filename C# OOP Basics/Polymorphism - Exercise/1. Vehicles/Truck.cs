namespace _1.Vehicles
{
    public class Truck : Vehicle
    {
        private const double TakenFuelInCharging = 0.95;

        public Truck(double fuelAmount, double fuelConsumption, double airConditioningConsumption) 
            : base(fuelAmount, fuelConsumption, airConditioningConsumption)
        {
        }

        public override void Refuel(double fuel)
        {
            fuel *= TakenFuelInCharging;
            base.Refuel(fuel);
        }
    }
}
