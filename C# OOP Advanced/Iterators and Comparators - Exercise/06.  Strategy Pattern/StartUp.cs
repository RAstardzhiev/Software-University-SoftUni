namespace _06.Strategy_Pattern
{
    using Comparators;
    using Models;
    using System.Collections.Generic;
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var peopleByName = new SortedSet<Person>(new PersonNameComparator());
            var peopleByAge = new SortedSet<Person>(new PersonAgeComparator());
            FillSetsWithPeople(peopleByName, peopleByAge);
            PrintBothSets(peopleByName, peopleByAge);
        }

        private static void PrintBothSets(SortedSet<Person> peopleByName, SortedSet<Person> peopleByAge)
        {
            var sb = new StringBuilder();

            ExtractPeopleData(sb, peopleByName);
            ExtractPeopleData(sb, peopleByAge);

            Console.Write(sb);
        }

        private static void ExtractPeopleData(StringBuilder sb, SortedSet<Person> peopleCollection)
        {
            foreach (var person in peopleCollection)
            {
                sb.AppendLine(person.ToString());
            }
        }

        private static void FillSetsWithPeople(SortedSet<Person> peopleByName, SortedSet<Person> peopleByAge)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            while (numberOfPeople > 0)
            {
                var personData = Console.ReadLine().Split();
                var name = personData[0];
                var age = int.Parse(personData[1]);

                peopleByName.Add(new Person(name, age));
                peopleByAge.Add(new Person(name, age));

                numberOfPeople--;
            }
        }
    }
}
