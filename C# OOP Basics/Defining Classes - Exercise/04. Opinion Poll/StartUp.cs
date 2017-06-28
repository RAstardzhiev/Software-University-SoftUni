namespace _04.Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = GetPeople();
            PrintPeopleOlderThan30(people);
        }

        private static void PrintPeopleOlderThan30(HashSet<Person> people)
        {
            Console.WriteLine(string.Join(Environment.NewLine, people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .Select(p => $"{p.Name} - {p.Age}")));
        }

        private static HashSet<Person> GetPeople()
        {
            var people = new HashSet<Person>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            while (numberOfPeople > 0)
            {
                var personData = Console.ReadLine().Split();
                people.Add(new Person(personData[0], int.Parse(personData[1])));

                numberOfPeople--;
            }

            return people;
        }
    }
}
