namespace Softuni_Coffee_Orders
{
    using System;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {
        public static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal totalSum = 0M;

            for (int i = 0; i < numberOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                int daysInWeek = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal orderSum = daysInWeek * (decimal)capsulesCount * pricePerCapsule;
                Console.WriteLine("The price for the coffee is: ${0:F2}", orderSum);
                totalSum += orderSum;
            }

            Console.WriteLine("Total: ${0:F2}", totalSum);
        }
    }
}
