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
                context.Database.Initialize(true);
            }
        }
    }
}
