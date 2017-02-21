namespace Charity_Marathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int avarageLaps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine()) * days;
            double moneyPerKm = double.Parse(Console.ReadLine());

            if (runners > trackCapacity)
            {
                runners = trackCapacity;
            }

            decimal totalKilometers = (decimal)runners * avarageLaps * trackLength / 1000M;
            decimal money = totalKilometers * (decimal)moneyPerKm;
            Console.WriteLine("Money raised: {0:F2}", money);
        }
    }
}
