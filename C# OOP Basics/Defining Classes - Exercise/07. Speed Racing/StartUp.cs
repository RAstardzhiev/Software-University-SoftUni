namespace _07.Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static object cars;

        public static void Main()
        {
            var cars = GetCars();
            DriveCars(cars);
            PrintCars(cars);
        }

        private static void PrintCars(Queue<Car> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars
                .Select(c => $"{c.Model} {c.FuelAmount:F2} {c.DistanceTravelled}")));
        }

        private static void DriveCars(Queue<Car> cars)
        {
            var command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                var currentCar = cars.Where(c => c.Model == command[1]).FirstOrDefault();

                if (currentCar != null)
                {
                    currentCar.Drive(double.Parse(command[2]));
                }

                command = Console.ReadLine().Split();
            }
        }

        private static Queue<Car> GetCars()
        {
            var cars = new Queue<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            while (cars.Count < numberOfCars)
            {
                var input = Console.ReadLine().Split();
                cars.Enqueue(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }

            return cars;
        }
    }
}
