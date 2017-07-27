namespace _05.Comparing_Objects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var people = GetPeople();
            PrintStat(people);
        }

        private static void PrintStat(List<Person> people)
        {
            var targetPersonNumber = int.Parse(Console.ReadLine());
            if (targetPersonNumber < 0 || targetPersonNumber >= people.Count)
            {
                Console.WriteLine("No matches");
                return;
            }

            var targetPerson = people[targetPersonNumber];
            var equalityCount = CountEqualPeople(targetPerson, people);
            if (equalityCount <= 1)
            {
                Console.WriteLine("No matches");
                return;
            }

            var differenceEqualCount = CountDifferentPeople(targetPerson, people);
            Console.WriteLine($"{equalityCount} {differenceEqualCount} {people.Count}");
        }

        private static int CountDifferentPeople(Person targetPerson, List<Person> people)
        {
            var differentPeopleCount = 0;

            for (int i = 1; i < people.Count; i++)
            {
                if (people[i - 1].CompareTo(people[i]) != 0)
                {
                    differentPeopleCount++;
                }
            }

            return differentPeopleCount;
        }

        private static int CountEqualPeople(Person targetPerson, List<Person> people)
        {
            var equalityCount = 1;

            for (int i = 1; i < people.Count; i++)
            {
                if (people[i - 1].CompareTo(people[i]) == 0)
                {
                    equalityCount++;
                }
            }

            return equalityCount;
        }

        private static List<Person> GetPeople()
        {
            var people = new List<Person>();

            var personData = Console.ReadLine().Split();

            while (personData[0] != "END")
            {
                var name = personData[0];
                var age = int.Parse(personData[1]);
                var town = personData[2];

                people.Add(new Person(name, age, town));

                personData = Console.ReadLine().Split();
            }

            return people;
        }
    }
}
