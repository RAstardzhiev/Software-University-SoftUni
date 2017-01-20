using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm___Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredHours =  int.Parse(Console.ReadLine());
            int availableDays =  int.Parse(Console.ReadLine());
            int employeesWorkingOverTime =   int.Parse(Console.ReadLine());

            //През 10 % от дните служителите са на обучение и не могат да работят по проекта
            //Един нормален работен ден във фирмата е 8 часа
            //Всеки служител може да работи по проекта в извънработно време по 2 часа на ден

            //Напишете програма, която изчислява дали фирмата може да завърши 
            //    проекта навреме и колко часа не достигат или остават

            double workingDays = availableDays - availableDays * 0.1;
            int workingHours = (int)(workingDays * 8 + employeesWorkingOverTime * availableDays * 2);

            if (workingHours > requiredHours)
                Console.WriteLine("Yes!{0} hours left.", workingHours - requiredHours);
            else
                Console.WriteLine("Not enough time!{0} hours needed.", requiredHours - workingHours);
        }
    }
}
