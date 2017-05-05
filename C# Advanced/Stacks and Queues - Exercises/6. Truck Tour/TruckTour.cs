namespace _6.Truck_Tour
{
    using System;
    using System.Linq;

    public class TruckTour
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var startIndex = 0;
            var truckFuel = 0;

            for (int i = 0; i < n; i++)
            {
                var pipeData = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                truckFuel += pipeData[0] - pipeData[1];

                if (truckFuel < 0)
                {
                    truckFuel = 0;
                    startIndex = i + 1;
                }
            }

            Console.WriteLine(startIndex);
        }
    }
}
