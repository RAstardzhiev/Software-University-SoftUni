namespace _21.vs2.Parking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingSystem2
    {
        public static void Main()
        {
            var parkingDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var usedPlaces = new Dictionary<int, HashSet<int>>(); // Key = row & Value = used columns

            for (int i = 0; i < parkingDimensions[0]; i++)
            {
                usedPlaces[i] = new HashSet<int>();
            }

            var input = Console.ReadLine().Split();

            while (input[0] != "stop")
            {
                var car = new Car
                {
                    EntryRow = int.Parse(input[0]),
                    ParkRow = int.Parse(input[1]),
                    ParkCol = int.Parse(input[2])
                };
                
                // Try park the car
                if (usedPlaces.ContainsKey(car.ParkRow) && usedPlaces[car.ParkRow].Count() < parkingDimensions[1] - 1) // If true => Car can park
                {
                    if (usedPlaces[car.ParkRow].Contains(car.ParkCol)) // If aimed cell is used
                    {
                        FindNearestFreeCell(car, usedPlaces, parkingDimensions);
                    }

                    usedPlaces[car.ParkRow].Add(car.ParkCol); // Add the cell to used ones
                    Console.WriteLine(Math.Abs((car.EntryRow) - (car.ParkRow)) + car.ParkCol + 1); // Write distance to park
                }
                else
                {
                    Console.WriteLine($"Row {car.ParkRow} full");
                }

                input = Console.ReadLine().Split();
            }
        }

        private static void FindNearestFreeCell(Car car, Dictionary<int, HashSet<int>> usedPlaces, int[] parkingDimensions)
        {
            var testChange = 1;
            var leftTestCol = car.ParkCol - testChange;
            var rightTestCol = car.ParkCol + testChange;

            while (leftTestCol > 0 || rightTestCol < parkingDimensions[1])
            {
                if (leftTestCol > 0 && !usedPlaces[car.ParkRow].Contains(leftTestCol)) // Try park on Left
                {
                    car.ParkCol = leftTestCol;
                    return;
                }

                if (rightTestCol < parkingDimensions[1] && !usedPlaces[car.ParkRow].Contains(rightTestCol)) // Try park on Right
                {
                    car.ParkCol = rightTestCol;
                    return;
                }

                testChange++;
                leftTestCol = car.ParkCol - testChange;
                rightTestCol = car.ParkCol + testChange;
            }
        }
    }
}
