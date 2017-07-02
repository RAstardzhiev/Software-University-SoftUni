namespace _04.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Queue<Person> people;
            Queue<Product> products;

            try
            {
                people = new Queue<Person>(Console.ReadLine()
                    .Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Split('='))
                    .Select(p => new Person(p[0], decimal.Parse(p[1]))));

                products = new Queue<Product>(Console.ReadLine()
                    .Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Split('='))
                    .Select(p => new Product(p[0], decimal.Parse(p[1]))));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Input have to consist of: Name and Money");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Money parameter have to be a digit");
                return;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            GoShopping(people, products);
            PrintPeople(people);
        }

        private static void PrintPeople(Queue<Person> people)
        {
            Console.WriteLine(string.Join(Environment.NewLine, people
                .Select(person => (person.Products.Count == 0)
                    ? $"{person.Name} - Nothing bought"
                    : $"{person.Name} - {string.Join(", ", person.Products.Select(product => product.Name))}")));
        }

        private static void GoShopping(Queue<Person> people, Queue<Product> products)
        {
            var order = Console.ReadLine();

            while (order != "END")
            {
                var indexOfFirstSpace = order.IndexOf(' ');

                if (indexOfFirstSpace <= 0)
                {
                    throw new ArgumentException("Invalid order");
                }

                var buyerName = order.Substring(0, indexOfFirstSpace);
                var productName = order.Substring(indexOfFirstSpace + 1);
                var currentProduct = products.Where(p => p.Name == productName).FirstOrDefault();
                var currentBuyer = people.Where(p => p.Name == buyerName).FirstOrDefault();

                if (currentProduct == null)
                {
                    throw new ArgumentException("Product does not exists");
                }

                if (currentBuyer == null)
                {
                    throw new ArgumentException("Buyer name does not exists");
                }

                if (currentBuyer.Money >= currentProduct.Cost)
                {
                    Console.WriteLine($"{currentBuyer.Name} bought {currentProduct.Name}");
                    currentBuyer.SubstractMoney(currentProduct.Cost);
                    currentBuyer.Products.Enqueue(currentProduct);
                }
                else
                {
                    Console.WriteLine($"{currentBuyer.Name} can't afford {currentProduct.Name}");
                }

                order = Console.ReadLine();
            }
        }
    }
}
