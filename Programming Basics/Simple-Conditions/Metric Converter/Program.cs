using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            var numberToConver = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            // Find Meters
            double meters;
            if (from.ToLower().Equals("m"))
                meters = numberToConver;
            else
                meters = findMeters(numberToConver, from);
            // Find the Result
            double result;
            if (to.ToLower().Equals("m"))
                result = meters;
            else
                result = getResult(meters, to);
            Console.WriteLine("{0} {1}", result, to);
        }

        public static double getResult(double m, string to)
        {
            to = to.ToLower();
            if (to.Equals("mm"))
                return m * 1000;
            else if (to.Equals("cm"))
                return m * 100;
            else if (to.Equals("mi"))
                return m * 0.000621371192;
            else if (to.Equals("in"))
                return m * 39.3700787;
            else if (to.Equals("km"))
                return m * 0.001;
            else if (to.Equals("ft"))
                return m * 3.2808399;
            else if (to.Equals("yd"))
                return m * 1.0936133;
            else
            {
                Console.WriteLine("Program Error (012335478) --> Call the developer");
                return 0;
            }
        }

        public static double findMeters(double numberToConvert, string from)
        {
            from = from.ToLower();
            if (from.Equals("mm"))
                return numberToConvert / 1000;
            else if (from.Equals("cm"))
                return numberToConvert / 100;
            else if (from.Equals("mi"))
                return numberToConvert / 0.000621371192;
            else if (from.Equals("in"))
                return numberToConvert / 39.3700787;
            else if (from.Equals("km"))
                return numberToConvert / 0.001;
            else if (from.Equals("ft"))
                return numberToConvert / 3.2808399;
            else if (from.Equals("yd"))
                return numberToConvert / 1.0936133;
            else
            {
                Console.WriteLine("Program Error (21034568) --> Call the developer");
                return 0;
            }
        }
    }
}
