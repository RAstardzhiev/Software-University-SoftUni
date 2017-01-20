using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            int[] nOfPeople = new int[numberOfGroups];

            for (int i = 0; i < numberOfGroups; i++)
                nOfPeople[i] = int.Parse(Console.ReadLine());

            int allPeaple = 0, car = 0, mikrobus = 0, malakAvtobus = 0, golqmAvtobus = 0, train = 0;
            for (int i = 0; i < nOfPeople.Length; i++)
            {
                allPeaple += nOfPeople[i];
                if (nOfPeople[i] < 6) car += nOfPeople[i];
                else if (nOfPeople[i] < 13) mikrobus += nOfPeople[i];
                else if (nOfPeople[i] < 26) malakAvtobus += nOfPeople[i];
                else if (nOfPeople[i] < 41) golqmAvtobus += nOfPeople[i];
                else train += nOfPeople[i];
            }

                Console.WriteLine("{0:0.00}%", car * 1.00 / allPeaple * 100);
                Console.WriteLine("{0:0.00}%", mikrobus * 1.00 / allPeaple * 100);
                Console.WriteLine("{0:0.00}%", malakAvtobus * 1.00 / allPeaple * 100);
                Console.WriteLine("{0:0.00}%", golqmAvtobus * 1.00 / allPeaple * 100);
                Console.WriteLine("{0:0.00}%", train * 1.00 / allPeaple * 100);

        }
    }
}
