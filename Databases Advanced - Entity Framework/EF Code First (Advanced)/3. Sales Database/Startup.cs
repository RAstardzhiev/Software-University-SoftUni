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
                 context.Database.Initialize(true); // 3.	Sales Database
                 ProductsMigration(context); // 4. Products Migration
                // SalesMigrationThroughModifyingEmptyMigration(context); // 5. Sales Migration
            }
        }

        private static void SalesMigrationThroughModifyingEmptyMigration(SalesContext context)
        {
            throw new NotImplementedException();
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
