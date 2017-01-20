using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodAllKG = int.Parse(Console.ReadLine());
            double dogFoodPerDayKG = double.Parse(Console.ReadLine());
            double catFoodPerDayKG = double.Parse(Console.ReadLine());
            double turtleFoodPerDayInGRAMS = double.Parse(Console.ReadLine());

            double eatenFood = days * (dogFoodPerDayKG + catFoodPerDayKG + turtleFoodPerDayInGRAMS / 1000);

            if (foodAllKG >= eatenFood)
            {
                int exessFood = (int)(foodAllKG - eatenFood);
                Console.WriteLine("{0} kilos of food left.", exessFood);
            }
            else
            {
                var neededFood = Math.Ceiling(eatenFood - foodAllKG);
                Console.WriteLine("{0} more kilos of food are needed.", neededFood);
            }

        }
    }
}
