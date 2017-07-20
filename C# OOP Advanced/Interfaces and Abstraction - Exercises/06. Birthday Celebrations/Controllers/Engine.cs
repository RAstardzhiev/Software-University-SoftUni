namespace _06.Birthday_Celebrations.Controllers
{
    using Interfaces;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private const string RebelBirthDate = "Unknown";

        internal void Run()
        {
            // BirthdayCelebrationsImplementation();
            this.FoodShortageImplementation();
        }

        private void FoodShortageImplementation()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var people = new Stack<Buyer>();

            while (numberOfPeople > 0)
            {
                var personData = Console.ReadLine().Split();
                var name = personData[0];
                var age = int.Parse(personData[1]);

                if (personData.Length == 4)
                {
                    var id = personData[2];
                    var birthdate = personData[3];
                    people.Push(new Citizen(name, age, id, birthdate));
                }
                else
                {
                    var group = personData[2];
                    people.Push(new Rebel(RebelBirthDate, name, group));
                }

                numberOfPeople--;
            }

            this.GoShopping(people);
            Console.WriteLine(people.Sum(p => p.Food));
        }

        private void GoShopping(Stack<Buyer> people)
        {
            var name = Console.ReadLine();

            while (name != "End")
            {
                var currentBuyer = people.FirstOrDefault(p => p.Name == name);

                if (currentBuyer != null)
                {
                    currentBuyer.BuyFood();
                }

                name = Console.ReadLine();
            }
        }

        private void BirthdayCelebrationsImplementation()
        {
            var livingBeings = new Queue<IBirthable>();
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string name;
            string birthdate;

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Citizen": // Citizen <name> <age> <id> <birthdate>
                        name = input[1];
                        var age = int.Parse(input[2]);
                        var id = input[3];
                        birthdate = input[4];
                        livingBeings.Enqueue(new Citizen(name, age, id, birthdate));
                        break;
                    case "Pet": // Pet <name> <birthdate>
                        name = input[1];
                        birthdate = input[2];
                        livingBeings.Enqueue(new Pet(birthdate, name));
                        break;
                    case "Robot":
                    default:
                        break;
                }

                input = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            this.PrintBirethDaysInParticularYear(livingBeings);
        }

        private void PrintBirethDaysInParticularYear(Queue<IBirthable> livingBeings)
        {
            var targetYear = Console.ReadLine().Trim();
            var birthsInThisYear = livingBeings
                .Where(lb => lb.BirthDate.EndsWith(targetYear))
                .Select(lb => lb.BirthDate);

            if (birthsInThisYear != null)
            {
                Console.WriteLine(string.Join(Environment.NewLine, birthsInThisYear));
            }
        }
    }
}
