namespace _10.Explicit_Interfaces
{
    using Interfaces;
    using Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            // PrintNamesAsDifferentInterfaces(); // Both variants work
            PrintNamesWithTypeCasting(); // Both variants work
        }

        private static void PrintNamesWithTypeCasting()
        {
            var name = Console.ReadLine().Split();

            while (name[0] != "End")
            {
                var human = new Citizen(name[0]);
                Console.WriteLine(((IPerson)human).GetName());
                Console.WriteLine(((IResident)human).GetName());

                name = Console.ReadLine().Split();
            }
        }

        private static void PrintNamesAsDifferentInterfaces()
        {
            var name = Console.ReadLine().Split();

            while (name[0] != "End")
            {
                IPerson person = new Citizen(name[0]);
                Console.WriteLine(person.GetName());

                IResident resident = new Citizen(name[0]);
                Console.WriteLine(resident.GetName());

                name = Console.ReadLine().Split();
            }
        }
    }
}
