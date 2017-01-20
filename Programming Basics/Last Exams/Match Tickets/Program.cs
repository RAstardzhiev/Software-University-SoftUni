using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget =  double.Parse(Console.ReadLine());
            string category =     Console.ReadLine();
            int people =   int.Parse(Console.ReadLine());

            double travelCost = 0;
                if (people < 5) travelCost = 0.75;
                else if (people < 10) travelCost = 0.60;
                else if (people < 25) travelCost = 0.50;
                else if (people < 50) travelCost = 0.40;
                else travelCost = 0.25;

            double ticketPrice = 0;
                if (category.ToLower().Equals("vip")) ticketPrice = 499.99;
                else if (category.ToLower().Equals("normal")) ticketPrice = 249.99;

            ticketPrice *= people;

            if (budget >= ticketPrice + budget * travelCost)
                Console.WriteLine("Yes! You have {0:0.00} leva left.", budget - (ticketPrice + budget * travelCost));
            else
                Console.WriteLine("Not enough money! You need {0:0.00} leva.", (ticketPrice + budget * travelCost) - budget);
        }
    }
}
