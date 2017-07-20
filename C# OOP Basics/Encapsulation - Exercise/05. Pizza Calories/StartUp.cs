namespace _05.Pizza_Calories
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            CalculatePizzaCalories();
        }

        private static void CalculatePizzaCalories()
        {
            var inpit = Console.ReadLine().Split();

            try
            {
                while (inpit[0] != "END")
                {
                    switch (inpit[0].ToLower())
                    {
                        case "pizza":
                            var pizza = SetPizza(inpit[1], int.Parse(inpit[2]));
                            Console.WriteLine(pizza.GetTotalCalories());
                            break;
                        case "dough":
                            var douugh = new Dough(inpit[1], inpit[2], int.Parse(inpit[3]));
                            Console.WriteLine($"{douugh.GetCalories():F2}");
                            break;
                        case "topping":
                            var toppint = new Topping(inpit[1], int.Parse(inpit[2]));
                            Console.WriteLine($"{toppint.GetCalories():F2}");
                            break;
                        default:
                            break;
                    }

                    inpit = Console.ReadLine().Split();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Pizza SetPizza(string name, int toppingsCount)
        {
            var doughTypeAndTechnique = Console.ReadLine().Split();

            var pizza = new Pizza(name, toppingsCount);
            pizza.Dough = new Dough(doughTypeAndTechnique[1], doughTypeAndTechnique[2], int.Parse(doughTypeAndTechnique[3]));

            for (int i = 0; i < toppingsCount; i++)
            {
                var toppingData = Console.ReadLine().Split();
                pizza.AddTopping(new Topping(toppingData[1], int.Parse(toppingData[2])));
            }

            return pizza;
        }
    }
}
