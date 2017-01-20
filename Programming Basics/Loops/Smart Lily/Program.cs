using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вход
            // От конзолата се прочитат 3 числа, на отделни редове:
            //  •	Възраста на Лили – цяло число в интервала[1...77]
            //  •	Цената на пералнята – число в интервала[1.00...10 000.00]
            //  •	Единична цена на играчка – цяло число в интервала[0...40]
            int age = int.Parse(Console.ReadLine());
            double PeralnqPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            // За нечетните рождени дни (1, 3, 5...n) получава играчки
            int toys = 0;
            for (int i = age; i > 0; i--)
                if (i % 2 != 0)
                    toys++;
            toys *= toyPrice;
            // за всеки четен(2, 4, 6...n) получава пари
            // За втория рожден ден получава 10.00 лв, като сумата се 
            // увеличава с 10.00 лв, за всеки следващ четен рожден ден (2-> 10, 4-> 20, 6-> 30...и т.н.). 
            int money = 0;
            for (int i = age, m = 0; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    m += 10;
                    money += m;
                    // Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях
                    money--;
                }
            }

            if (money + toys >= PeralnqPrice)
                Console.WriteLine("Yes! {0:0.00}", Math.Round(money + toys - PeralnqPrice, 2));
            else
                Console.WriteLine("No! {0:0.00}", Math.Round(PeralnqPrice - (money + toys), 2));
        }
    }
}
