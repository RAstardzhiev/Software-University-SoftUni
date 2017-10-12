namespace _1.Local_Store
{
    using System;
    using Modedls;
    public class Startup
    {
        public static void Main()
        {
            using (var context = new LocalStoreContext())
            {
                // LocalStore(context); // 1. Local Store
                LocalStoreImprovement(context); // 2. Local Store Improvement
            }
        }

        private static void LocalStoreImprovement(LocalStoreContext context)
        {
            // Migration made through the Package Manager Console
            foreach (var product in context.Products)
            {
                Console.WriteLine(product + Environment.NewLine);
            }
        }

        private static void LocalStore(LocalStoreContext context)
        {
            //context.Database.Initialize(true);

            //context.Products.AddRange(new[]
            //{
            //    new Product("Banana", "Equador", 2.35M), 
            //    new Product("Kiwi", "Tanzania", 2.99M),
            //    new Product("Orange", "Greece", 3.67M)
            //});

            //context.SaveChanges();
        }
    }
}
