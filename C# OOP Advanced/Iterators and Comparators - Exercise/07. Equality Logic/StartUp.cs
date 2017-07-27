namespace _07.Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var sortedPeople = new SortedSet<Person>();
            var hashedPeople = new HashSet<Person>(new PersonEqualityComparer());
            FillCollections(sortedPeople, hashedPeople);

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashedPeople.Count);
        }

        private static void FillCollections(SortedSet<Person> sortedPeople, HashSet<Person> hashedPeople)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());

            while (numberOfPeople > 0)
            {
                var personData = Console.ReadLine().Split();
                var name = personData[0];
                var age = int.Parse(personData[1]);

                sortedPeople.Add(new Person(name, age));
                hashedPeople.Add(new Person(name, age));

                numberOfPeople--;
            }
        }
    }
}
