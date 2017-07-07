namespace _1.Vehicles
{
    using System;

    public class StartUp
    {
        private const double CarAirCondConsumption = 0.9;
        private const double TruckAirCondConsumption = 1.6;

        public static void Main()
        {
            var carDetails = Console.ReadLine().Split();
            var car = new Car(double.Parse(carDetails[1]), double.Parse(carDetails[2]), CarAirCondConsumption);
            var truckDetails = Console.ReadLine().Split();
            var truck = new Truck(double.Parse(truckDetails[1]), double.Parse(truckDetails[2]), TruckAirCondConsumption);

            ExecuteCommands(car, truck);
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ExecuteCommands(Car car, Truck truck)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            while (numberOfCommands > 0)
            {
                var command = Console.ReadLine().Split();
                var action = command[0];
                var vehicleType = command[1];
                var value = double.Parse(command[2]);

                switch (action)
                {
                    case "Drive":
                        Console.WriteLine(vehicleType == "Car" 
                            ? car.Drive(value)
                            : truck.Drive(value));
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
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }

                numberOfCommands--;
            }
        }
    }
}
