namespace _1.Define_a_class_Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var people = GetPeopleFromConsole();

            Console.WriteLine(string.Join(Environment.NewLine, people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .Select(p => $"{p.Name} - {p.Age}")));
        }

        private static List<Person> GetPeopleFromConsole()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            while (numberOfLines > 0)
            {
                var personData = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (personData.Length > 1)
                {
                    people.Add(new Person(personData[0], int.Parse(personData[1])));
                }
                else if (personData.Length == 1)
                {
                    people.Add(new Person(int.Parse(personData[0])));
                }
                else
                {
                    people.Add(new Person());
                }

                numberOfLines--;
            }

            return people;
        }
    }
}
