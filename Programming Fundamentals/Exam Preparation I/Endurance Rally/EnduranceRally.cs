namespace Endurance_Rally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main(string[] args)
        {
            string[] driverNames = Console.ReadLine()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            double[] fuelOfDrivers = new double[driverNames.Length];
            for (int i = 0; i < driverNames.Length; i++)
            {
                fuelOfDrivers[i] = (int)driverNames[i][0];
            }

            double [] zonesFuel = Console.ReadLine()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            int[] checkpointIndixes = Console.ReadLine()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 10)
                .Select(int.Parse)
                .ToArray();

            for (int zone = 0; zone < zonesFuel.Length; zone++)
            {
                if (checkpointIndixes.Contains(zone))
                {
                    for (int i = 0; i < fuelOfDrivers.Length; i++)
                    {
                        fuelOfDrivers[i] += zonesFuel[zone];
                    }
                }
                else
                {
                    for (int i = 0; i < fuelOfDrivers.Length; i++)
                    {
                        fuelOfDrivers[i] -= zonesFuel[zone];
                        if (fuelOfDrivers[i] <= 0 && !driverNames[i].Contains(' '))
                        {
                            driverNames[i] += $" - reached {zone}";
                        }
                    }
                }
            }

            for (int i = 0; i < driverNames.Length; i++)
            {
                if (driverNames[i].Contains(' '))
                {
                    Console.WriteLine(driverNames[i]);
                }
                else
                {
                    Console.WriteLine($"{driverNames[i]} - fuel left {fuelOfDrivers[i]:0.00}");
                }
            }
        }
    }
}
