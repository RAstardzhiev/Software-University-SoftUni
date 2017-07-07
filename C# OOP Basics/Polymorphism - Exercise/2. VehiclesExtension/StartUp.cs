namespace _2.VehiclesExtension
{
    using System;

    public class StartUp
    {
        private const double CarAirCondConsumption = 0.9;
        private const double TruckAirCondConsumption = 1.6;
        private const double BuskAirCondConsumption = 1.4;

        public static void Main()
        {
            var carDetails = Console.ReadLine().Split();
            var car = new Car(double.Parse(carDetails[1]), double.Parse(carDetails[2]), CarAirCondConsumption, double.Parse(carDetails[3]));
            var truckDetails = Console.ReadLine().Split();
            var truck = new Truck(double.Parse(truckDetails[1]), double.Parse(truckDetails[2]), TruckAirCondConsumption, double.Parse(carDetails[3]));
            var busDetails = Console.ReadLine().Split();
            var bus = new Bus(double.Parse(busDetails[1]), double.Parse(busDetails[2]), BuskAirCondConsumption, double.Parse(busDetails[3]));

            ExecuteCommands(car, truck, bus);
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteCommands(Car car, Truck truck, Bus bus)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            while (numberOfCommands > 0)
            {
                numberOfCommands--;

                var command = Console.ReadLine().Split();
                var action = command[0];
                var vehicleType = command[1];
                var value = double.Parse(command[2]);

                try
                {
                    switch (action)
                    {
                        case "Drive":
                            Console.WriteLine(vehicleType == "Car"
                                ? car.Drive(value)
                                : vehicleType == "Truck"
                                ? truck.Drive(value)
                                : bus.Drive(value));
                            break;
                        case "Refuel":
                            switch (vehicleType)
                            {
                                case "Car":
                                    car.Refuel(value);
                                    break;
                                case "Truck":
                                    truck.Refuel(value);
                                    break;
                                case "Bus":
                                    bus.Refuel(value);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "DriveEmpty":
                            bus.IsAirConditionerTurnedOn = false;
                            Console.WriteLine(bus.Drive(value));
                            bus.IsAirConditionerTurnedOn = true;
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
