namespace Price_Change_Alert
{
    using System;

    public class PriceChangeAlert
    {
        public static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshold = double.Parse(Console.ReadLine()) * 100;
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double newPrice = double.Parse(Console.ReadLine());
                double difference = ChangeRate(lastPrice, newPrice);
                bool isSignificantDifference = IsChangeSignificant(difference, significanceThreshold);
                
                string message = PriceChangeStatement(newPrice, lastPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = newPrice;
            }
        }

        private static string PriceChangeStatement(double newPrice, double lastPrice, double difference, bool isSignificantDifference)
        {
            string statement = string.Empty;
            if (difference == 0)
            {
                statement = string.Format("NO CHANGE: {0}", newPrice);
            }
            else if (!isSignificantDifference)
            {
                statement = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                statement = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                statement = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference);
            }

            return statement;
        }

        private static bool IsChangeSignificant(double difference, double significanceThreshold)
        {
            if (Math.Abs(difference) >= significanceThreshold)
            {
                return true;
            }

            return false;
        }

        private static double ChangeRate(double lastPrice, double newPrice)
        {
            return (newPrice - lastPrice) / lastPrice * 100;
        }
    }
}
