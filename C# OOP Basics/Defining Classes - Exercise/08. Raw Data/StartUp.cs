namespace _08.Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var cars = GetCars();
            PrintCars(cars);
        }

        private static void PrintCars(Queue<Car> cars)
        {
            var command = Console.ReadLine();

            Console.WriteLine(string.Join(Environment.NewLine, cars
                        .Where(c => c.Cargo.Type == command && command == "fragile"
                            ? c.Tires
                                .Where(t => t.Pressure < 1)
                                .FirstOrDefault() != null
                            : c.Engine.Power > 250)
                        .Select(c => c.Model)));

            //switch (command)
            //{
            //    case "fragile":
            //        Console.WriteLine(string.Join(Environment.NewLine, cars
            //            .Where(c => c.Cargo.Type == "fragile" && c.Tires
            //                .Where(t => t.Pressure < 1)
            //                .FirstOrDefault() != null)
            //            .Select(c => c.Model)));
            //        break;
            //    case "flamable":
            //        Console.WriteLine(string.Join(Environment.NewLine, cars
            //            .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
            //            .Select(c => c.Model)));
            //        break;
            //    default:
            //        break;
            //}
        }

        private static Queue<Car> GetCars()
        {
            var cars = new Queue<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            while (cars.Count < numberOfCars)
            {
                var input = Console.ReadLine().Split();

                /*
                 * Information about a car in the format:
                 * “<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” 
                 */
                var engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                var cargo = new Cargo(int.Parse(input[3]), input[4]);
                var tires = new Tire[]
                {
                    new Tire(int.Parse(input[6]), double.Parse(input[5])),
                    new Tire(int.Parse(input[8]), double.Parse(input[7])),
                    new Tire(int.Parse(input[10]), double.Parse(input[9])),
                    new Tire(int.Parse(input[12]), double.Parse(input[11])),
                };

                cars.Enqueue(new Car(input[0], engine, cargo, tires));
            }

            return cars;
        }
    }
}
