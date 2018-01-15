namespace _3.Sales_Database
{
    using System.Data.Entity;
    using Models;

    public class InitializeAndSeed : DropCreateDatabaseAlways<SalesContext>
    {
        protected override void Seed(SalesContext context)
        {
            //var banana = new Product("Banana", 100, 2.30M);
            //var kiwi = new Product("Kiwi", 50, 3.45M);
            //var orange = new Product("Orange", 80, 3.27M);
            //var strawberry = new Product("Strawberry", 76, 5.47M);
            //var papaya = new Product("Papaya", 30, 3.47M);

            //context.Products.AddRange(new[]
            //{
            //    banana, kiwi, orange, strawberry, papaya
            //});

            //var centerStore = new StoreLocation("Center Store");
            //var eastStore = new StoreLocation("East Store");
            //var westStore = new StoreLocation("West Store");
            //var northStore = new StoreLocation("North Store");
            //var southStore = new StoreLocation("South Store");

            //context.StoreLocations.AddRange(new[]
            //{
            //    centerStore, eastStore, westStore, northStore, southStore
            //});

            //var firstCustomer = new Customer("First", "First@First.com");
            //var secondCustomer = new Customer("Second", "Second@Second.com");
            //var thirdCustomer = new Customer("Third", "Third@Third.com");
            //var fourthCustomer = new Customer("Fourth", "Fourth@Fourth.com");
            //var fifthCustomer = new Customer("Fifth", "Fifth@Fifth.com");

            //context.Customers.AddRange(new[]
            //{
            //    firstCustomer, secondCustomer, thirdCustomer, fourthCustomer, fifthCustomer
            //});

            //context.SaveChanges();

            //firstCustomer.Sales.Add(new Sale(banana.Id, fifthCustomer.Id, centerStore.Id));
            //firstCustomer.Sales.Add(new Sale(orange.Id, firstCustomer.Id, centerStore.Id));
            //secondCustomer.Sales.Add(new Sale(banana.Id, secondCustomer.Id, eastStore.Id));
            //secondCustomer.Sales.Add(new Sale(orange.Id, secondCustomer.Id, eastStore.Id));
            //thirdCustomer.Sales.Add(new Sale(kiwi.Id, thirdCustomer.Id, westStore.Id));

            base.Seed(context);
        }
    }
}
