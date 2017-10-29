namespace _3.Shopping_Spree
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            var people = ParseCollectionFromConsole<Person>();
            var products = ParseCollectionFromConsole<Product>();
            BuyProducts(people, products);
            PrintBoughtItems(people);
        }

        private static void PrintBoughtItems(Person[] people)
        {
            foreach (var human in people)
            {
                Console.WriteLine(human.BagOfProducts.Count == 0 
                    ? $"{human.Name} - Nothing bought"
                    : $"{human.Name} - {string.Join(", ", human.BagOfProducts.Select(p => p.Name))}");
            }
        }

        private static void BuyProducts(Person[] people, Product[] products)
        {
            var input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                var buyer = people.FirstOrDefault(p => p.Name == input[0]);
                var product = products.FirstOrDefault(p => p.Name == input[1]);
                if (buyer == null || product == null)
                {
                    throw new ArgumentException("Invalid name!");
                }

                if (product.Price <= buyer.Money)
                {
                    buyer.BuyProduct(product);
                    Console.WriteLine($"{buyer.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{buyer.Name} can't afford {product.Name}");
                }

                input = Console.ReadLine().Split();
            }
        }

        private static T[] ParseCollectionFromConsole<T>()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            var collection = new T[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                var separator = input[i].IndexOf('=');
                var name = input[i].Substring(0, separator);
                var money = decimal.Parse(input[i].Substring(separator + 1));

                try
                {
                    collection[i] = (T)Activator.CreateInstance(typeof(T), name, money);
                }
                catch (TargetInvocationException tie)
                {
                    Console.WriteLine(tie.InnerException.Message);
                    Environment.Exit(Environment.ExitCode);
                }
            }

            return collection;
        }
    }
}
