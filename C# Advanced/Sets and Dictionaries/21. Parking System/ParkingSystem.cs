namespace _21.Parking_System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingSystem
    {
        public static void Main()
        {
            var parkingDimensionsRolCol = InitializeParking();
            var usedCells = new HashSet<Cell>();

            var input = Console.ReadLine().Split();

            while (input[0] != "stop")
            {
                var carEntranceRow = int.Parse(input[0]);
                var carParkingArim = new Cell
                {
                    Row = int.Parse(input[1]),
                    Column = int.Parse(input[2])
                };

                // Process car
                if (IsCarParked(carParkingArim, usedCells, parkingDimensionsRolCol))
                {
                    // Print distance travelled to the park
                    Console.WriteLine(Math.Abs((carEntranceRow + 1) - (carParkingArim.Row + 1)) + carParkingArim.Column + 1);
                    usedCells.Add(carParkingArim);
                }
                else
                {
                    Console.WriteLine($"Row {carParkingArim.Row} full");
                }

                input = Console.ReadLine().Split();
            }
        }

        private static bool IsCarParked(Cell carParkingArim, HashSet<Cell> usedCells, int[] parkingDimensions)
        {
            // Try park
            if (usedCells.Where(c => c.Row == carParkingArim.Row && c.Column == carParkingArim.Column)
                .FirstOrDefault() == null)
            {
                return true;
            }

            var testCol = 1;

            // Loop around the row to find free cell to park
            while (true)
            {
                var leftCol = carParkingArim.Column - testCol;
                var rightCol = carParkingArim.Column + testCol;

                if (leftCol <= 0 && rightCol >= parkingDimensions[1])
                {
                    break;
                }

                // Try park left
                if (leftCol > 0 && 
                    usedCells.Where(c => c.Row == carParkingArim.Row && c.Column == leftCol)
                    .FirstOrDefault() == null)
                {
                    carParkingArim.Column = leftCol;
                    return true;
                }

                // Try park right
                if (rightCol < parkingDimensions[1] && 
                    usedCells.Where(c => c.Row == carParkingArim.Row && c.Column == rightCol)
                    .FirstOrDefault() == null)
                {
                    carParkingArim.Column = rightCol;
                    return true;
                }

                testCol++;
            }

            return false;
        }

        private static int[] InitializeParking()
        {
            var dimmensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            return new int[] { dimmensions[0], dimmensions[1] };
        }
    }
}
