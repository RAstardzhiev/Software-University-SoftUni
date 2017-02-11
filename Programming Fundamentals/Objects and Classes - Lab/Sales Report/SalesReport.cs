namespace Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main(string[] args)
        {
            int numberOfSales = int.Parse(Console.ReadLine());
            List<Sale> allSales = GatherSales(numberOfSales)
                .OrderBy(x => x.Town)
                .ToList();

            foreach (Sale sale in allSales)
            {
                Console.WriteLine($"{sale.Town} -> {sale.Money:F2}");
            }
        }

        public static List<Sale> GatherSales(int numberOfSales)
        {
            List<Sale> allSales = new List<Sale>();
            for (int i = 0; i < numberOfSales; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                bool isTownInList = false;
                for (int j = 0; j < allSales.Count; j++)
                {
                    if (allSales[j].Town.Equals(input[0]))
                    {
                        isTownInList = true;
                        allSales[j].Money += decimal.Parse(input[2]) * decimal.Parse(input[3]);
                        break;
                    }
                }

                if (!isTownInList)
                {
                    // town, product, price, quantity
                    allSales.Add(new Sale(input[0], decimal.Parse(input[2]) * decimal.Parse(input[3])));
                }
            }

            return allSales;
        }
    }
}
