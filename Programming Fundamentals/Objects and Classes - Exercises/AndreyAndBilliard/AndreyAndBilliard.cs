namespace AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = GetProductsAndPrices();
            List<Customer> customers = GatherOrders(menu);
            PrintTotalBill(menu, customers);
        }

        private static void PrintTotalBill(Dictionary<string, decimal> menu, List<Customer> customers)
        {
            customers = customers
                .OrderBy(x => x.Name)
                .ToList();

            decimal totalBill = 0M;
            foreach (Customer client in customers)
            {
                Console.WriteLine(client.Name);
                foreach (KeyValuePair<string, int> line in client.Order)
                {
                    Console.WriteLine($"-- {line.Key} - {line.Value}");
                }

                decimal bill = client.Bill(menu);
                Console.WriteLine($"Bill: {bill:F2}");
                totalBill += bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        private static List<Customer> GatherOrders(Dictionary<string, decimal> menu)
        {
            List<Customer> customers = new List<Customer>();
            while (true)
            {
                string[] order = Console.ReadLine().Split('-', ',');
                if (order[0].ToLower().Equals("end of clients"))
                {
                    return customers;
                }

                if (menu.ContainsKey(order[1]))
                {
                    if (customers.Any(x => x.Name.Equals(order[0])))
                    {
                        Customer temp = customers.First(x => x.Name.Equals(order[0]));
                        if (temp.Order.ContainsKey(order[1]))
                        {
                            temp.Order[order[1]] += int.Parse(order[2]);
                        }
                        else
                        {
                            temp.Order[order[1]] = int.Parse(order[2]);
                        }
                    }
                    else
                    {
                        customers.Add(new Customer() { Name = order[0], Order = new Dictionary<string, int>() { { order[1], int.Parse(order[2]) } } });
                    }
                }
            }
        }

        private static Dictionary<string, decimal> GetProductsAndPrices()
        {
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            int numberOfProducts = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] newProduct = Console.ReadLine().Split('-');
                menu[newProduct[0]] = decimal.Parse(newProduct[1]);
            }

            return menu;
        }
    }
}
