namespace _2.Coffee_Machine
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            CoffeeMachine machine = new CoffeeMachine();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();
                if (inputArgs.Length == 1)
                {
                    machine.InsertCoin(inputArgs[0]);
                }
                else
                {
                    machine.BuyCoffee(inputArgs[0], inputArgs[1]);
                }
            }

            foreach (var coffeeType in machine.CoffeesSold)
            {
                Console.WriteLine(coffeeType);
            }
        }
    }
}
