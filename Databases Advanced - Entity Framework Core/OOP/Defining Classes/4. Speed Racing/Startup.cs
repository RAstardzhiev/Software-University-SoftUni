namespace _4.Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var cars = GetCarsFromInput();
            DriveCars(cars);

            Console.WriteLine(string.Join(Environment.NewLine, cars.Select(c => c.ToString())));
        }

        private static void DriveCars(HashSet<Car> cars)
        {
            var input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                var carModel = input[1];
                var distance = double.Parse(input[2]);
                var car = cars.FirstOrDefault(c => c.Model == carModel);
                if (car != null)
                {
                    try
                    {
                        car.Moove(distance);
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                }

                input = Console.ReadLine().Split();
            }
        }

        private static HashSet<Car> GetCarsFromInput()
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new HashSet<Car>(new CarComparer());

            while (numberOfCars > 0)
            {
                var carData = Console.ReadLine()
                    .Split()
                    .ToArray();

                cars.Add(new Car(carData[0], double.Parse(carData[1]), double.Parse(carData[2])));

                numberOfCars--;
            }

            return cars;
        }
    }
}
