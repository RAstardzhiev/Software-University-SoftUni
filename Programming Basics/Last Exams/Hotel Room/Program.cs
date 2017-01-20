using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month =    Console.ReadLine();
            int nights =     int.Parse(Console.ReadLine());

            double studioPricePerNight = 0, apartmentPricePerNight = 0, studioDiscount = 1, apartmentDiscount = 1;

            switch (month)
            {
                case "May":
                case "October":
                    studioPricePerNight = 50;
                    apartmentPricePerNight = 65;
                    if (nights > 14) studioDiscount = 0.7;
                    else if (nights > 7) studioDiscount = 0.95;
                    break;
                case "June":
                case "September":
                    studioPricePerNight = 75.20;
                    apartmentPricePerNight = 68.70;
                    if (nights > 14) studioDiscount = 0.8;
                    break;
                case "July":
                case "August":
                    studioPricePerNight = 76;
                    apartmentPricePerNight = 77;
                    break;
                default:
                    break;
            }

            if (nights > 14) apartmentDiscount = 0.9;

            Console.WriteLine("Apartment: {0:0.00} lv.", Math.Round(apartmentPricePerNight * nights * apartmentDiscount, 2));
            Console.WriteLine("Studio: {0:0.00} lv.", Math.Round(studioPricePerNight * nights * studioDiscount, 2));

        }
    }
}
