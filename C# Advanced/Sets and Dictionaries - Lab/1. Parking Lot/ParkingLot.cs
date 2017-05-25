namespace _1.Parking_Lot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingLot
    {
        public static void Main()
        {
            var cars = ReadInput();
            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars.OrderBy(x => x)));
            }
        }

        private static HashSet<string> ReadInput()
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var cars = new HashSet<string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "IN":
                        cars.Add(input[1]);
                        break;
                    case "OUT":
                        if (cars.Contains(input[1]))
                        {
                            cars.Remove(input[1]);
                        }

                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return cars;
        }
    }
}
