namespace _3.Sales_Database
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            using (var context = new SalesContext())
            {
                // context.Database.Initialize(true);

                ProductsMigration(context); // 4. Products Migration
            }
        }

        private static void ProductsMigration(SalesContext context)
        {
            // Migrating through the Package Manager Console
            foreach (var sale in context.Sales
                .Include("Product")
                .Include("Customer")
                .Include("StoreLocation"))
            {
                Console.WriteLine($"{sale.Date.ToLocalTime()} - " +
                    $"{sale.StoreLocation.LocationName} sold " +
                    $"{sale.Product.Name} ({sale.Product.Description}) to " +
                    $"{sale.Customer.Name}");
            }
        }
    }
}
