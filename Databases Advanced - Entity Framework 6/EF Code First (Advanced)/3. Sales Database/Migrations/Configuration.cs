namespace _3.Sales_Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_3.Sales_Database.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "_3.Sales_Database.SalesContext";
        }

        protected override void Seed(_3.Sales_Database.SalesContext context)
        {
            foreach (var customer in context.Customers)
            {
                customer.LastName = $"{customer.FirstName}ov";
            }
        }
    }
}
