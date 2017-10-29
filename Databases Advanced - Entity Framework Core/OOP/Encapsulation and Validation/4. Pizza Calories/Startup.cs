namespace _4.Pizza_Calories
{
    using System;
    using Models;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var pizza = GetPizzaFromConsole();
            Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
        }

        private static Pizza GetPizzaFromConsole()
        {
            var pizzaName = Console.ReadLine().Split()[1];
            Pizza pizza = null;

            try
            {
                pizza = new Pizza(pizzaName);

                var doughData = Console.ReadLine().Split();
                var doughType = doughData[1];
                var doughBakingTechnique = doughData[2];
                var doughWeight = double.Parse(doughData[3]);

                var dough = new Dough(doughType, doughBakingTechnique, doughWeight);
                pizza.Dough = dough;

                var input = Console.ReadLine().Split();
                while (input[0] != "END")
                {
                    var toppingType = input[1];
                    var toppingWeight = double.Parse(input[2]);
                    var topping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(new Topping(toppingType, toppingWeight));

                    input = Console.ReadLine().Split();
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(Environment.ExitCode);
            }

            return pizza;
        }
    }
}
