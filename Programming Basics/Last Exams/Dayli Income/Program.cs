    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayli_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysInMounth =    int.Parse(Console.ReadLine());
            double dailyIncome =     double.Parse(Console.ReadLine());
            double usdRate =     double.Parse(Console.ReadLine());

            //годината има точно 365 дни
            //В края на годината Иван получава бонус, който е равен на 2.5 месечни заплати
            //От спечеленото през годината му се удържат 25 % данъци

            double bonusInBGN = usdRate * (dailyIncome * workingDaysInMounth * 2.5);
            double annualIncomeInBGN = workingDaysInMounth * 12 * dailyIncome * usdRate + bonusInBGN;
            annualIncomeInBGN -= annualIncomeInBGN * 0.25;

            Console.WriteLine(Math.Round(annualIncomeInBGN / 365, 2));
        }
    }
}
