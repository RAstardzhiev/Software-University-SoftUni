namespace AndreyAndBilliard
{
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> Order { get; set; }

        public decimal Bill(Dictionary<string, decimal> menu)
        {
            decimal bill = 0M;
            foreach (KeyValuePair<string, int> item in this.Order)
            {
                if (menu.ContainsKey(item.Key))
                {
                    bill += menu[item.Key] * item.Value;
                }
            }

            return bill;
        }
    }
}
