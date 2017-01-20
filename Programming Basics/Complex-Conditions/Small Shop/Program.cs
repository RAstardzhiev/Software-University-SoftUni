using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            if (town.ToLower().Equals("sofia"))
            {
                if (product.ToLower().Equals("coffee")) Console.WriteLine(quantity * 0.50);
                else if (product.ToLower().Equals("water")) Console.WriteLine(quantity * 0.80);
                else if (product.ToLower().Equals("beer")) Console.WriteLine(quantity * 1.20);
                else if (product.ToLower().Equals("sweets")) Console.WriteLine(quantity * 1.45);
                else if (product.ToLower().Equals("peanuts")) Console.WriteLine(quantity * 1.60);
            }
            else if (town.ToLower().Equals("plovdiv"))
            {
                if (product.ToLower().Equals("coffee")) Console.WriteLine(quantity * 0.40);
                else if (product.ToLower().Equals("water")) Console.WriteLine(quantity * 0.70);
                else if (product.ToLower().Equals("beer")) Console.WriteLine(quantity * 1.15);
                else if (product.ToLower().Equals("sweets")) Console.WriteLine(quantity * 1.30);
                else if (product.ToLower().Equals("peanuts")) Console.WriteLine(quantity * 1.50);
            }
            else if (town.ToLower().Equals("varna"))
            {
                if (product.ToLower().Equals("coffee")) Console.WriteLine(quantity * 0.45);
                else if (product.ToLower().Equals("water")) Console.WriteLine(quantity * 0.70);
                else if (product.ToLower().Equals("beer")) Console.WriteLine(quantity * 1.10);
                else if (product.ToLower().Equals("sweets")) Console.WriteLine(quantity * 1.35);
                else if (product.ToLower().Equals("peanuts")) Console.WriteLine(quantity * 1.55);
            }
        }
    }
}
