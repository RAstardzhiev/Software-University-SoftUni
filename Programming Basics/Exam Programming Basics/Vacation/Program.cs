using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int u4enici = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string typeTransport = Console.ReadLine();

            double oldExpence = 0;
            double u4eniciExpence = 0;

            switch (typeTransport)
            {
                case "train":
                    oldExpence = oldPeople * 24.99;
                    u4eniciExpence = u4enici * 14.99;
                    break;
                case "bus":
                    oldExpence = oldPeople * 32.50;
                    u4eniciExpence = u4enici * 28.50;
                    break;
                case "boat":
                    oldExpence = oldPeople * 42.99;
                    u4eniciExpence = u4enici * 39.99;
                    break;
                case "airplane":
                    oldExpence = oldPeople * 70.00;
                    u4eniciExpence = u4enici * 50.00;
                    break;
                default:
                    break;
            }

            double allExpence = (oldExpence + u4eniciExpence) * 2;
            if (typeTransport.Equals("train") && oldPeople + u4enici >= 50)
                allExpence /= 2;

            allExpence += 82.99 * nights;
            allExpence = allExpence + (allExpence * 0.10);

            Console.WriteLine("{0:0.00}", allExpence);
        }
    }
}
