namespace _2.Coffee_Machine
{
    using System;
    using System.Collections.Generic;

    public class CoffeeMachine
    {
        private int reseivedCoins;
        private IList<CoffeeType> orders;

        public CoffeeMachine()
        {
            this.orders = new List<CoffeeType>();
        }

        public IEnumerable<CoffeeType> CoffeesSold => this.orders as IReadOnlyCollection<CoffeeType>;

        public void BuyCoffee(string size, string type)
        {
            CoffeePrice coffeeSize;
            var isSizeValid = Enum.TryParse(size, true, out coffeeSize);

            CoffeeType coffeeType;
            var isTypeValid = Enum.TryParse(type, true, out coffeeType);

            var requiredMoney = (int)coffeeSize;
            if (this.reseivedCoins < requiredMoney || !isSizeValid || !isTypeValid)
            {
                return;
            }

            this.reseivedCoins = 0;
            this.orders.Add(coffeeType);
        }

        public void InsertCoin(string coin)
        {
            this.reseivedCoins += (int)Enum.Parse(typeof(Coin), coin);
        }
    }
}
