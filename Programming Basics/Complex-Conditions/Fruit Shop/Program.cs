using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (product.Equals("banana") || product.Equals("apple") || product.Equals("orange") || product.Equals("grapefruit") || product.Equals("kiwi") || product.Equals("pineapple") || product.Equals("grapes"))
            { 
                if (day.Equals("saturday") || day.Equals("sunday"))
                {
                    if (product.Equals("banana")) Console.WriteLine(quantity * 2.70);
                    else if (product.Equals("apple")) Console.WriteLine(quantity * 1.25);
                    else if (product.Equals("orange")) Console.WriteLine(quantity * 0.90);
                    else if (product.Equals("grapefruit")) Console.WriteLine(quantity * 1.60);
                    else if (product.Equals("kiwi")) Console.WriteLine(quantity * 3.00);
                    else if (product.Equals("pineapple")) Console.WriteLine(quantity * 5.60);
                    else if (product.Equals("grapes")) Console.WriteLine(quantity * 4.20);
                }
                else if (day.Equals("monday") || day.Equals("tuesday") || day.Equals("wednesday") || day.Equals("thursday") || day.Equals("friday"))
                {
                    if (product.Equals("banana")) Console.WriteLine(quantity * 2.50);
                    else if (product.Equals("apple")) Console.WriteLine(quantity * 1.20);
                    else if (product.Equals("orange")) Console.WriteLine(quantity * 0.85);
                    else if (product.Equals("grapefruit")) Console.WriteLine(quantity * 1.45);
                    else if (product.Equals("kiwi")) Console.WriteLine(quantity * 2.70);
                    else if (product.Equals("pineapple")) Console.WriteLine(quantity * 5.50);
                    else if (product.Equals("grapes")) Console.WriteLine(quantity * 3.85);
                }
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");
        }
    }
}
