namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var collectedData = CollectData();
            PrintPerson(collectedData);
        }

        private static void PrintPerson(Queue<Person> collectedData)
        {
            var personToPrint = Console.ReadLine();
            var person = collectedData
                .FirstOrDefault(p => p.Name == personToPrint);

            if (person != null)
            {
                Console.Write(person.ToString());
            }
        }

        private static Queue<Person> CollectData()
        {
            var collectedData = new Queue<Person>();
            var data = Console.ReadLine().Split();

            while (data[0] != "End")
            {
                var personName = data[0];
                var currentPerson = collectedData.FirstOrDefault(p => p.Name == personName);

                if (currentPerson == null)
                {
                    currentPerson = new Person(personName);
                    collectedData.Enqueue(currentPerson);
                }

                OrderData(currentPerson, data);

                data = Console.ReadLine().Split();
            }

            return collectedData;
        }

        private static void OrderData(Person currentPerson, string[] data)
        {
            switch (data[1])
            {
                case "company":
                    var companyName = data[2];
                    var salary = decimal.Parse(data[4]);
                    var department = data[3];
                    currentPerson.AssignACompany(new Company(companyName, salary, department));
                    break;
                case "pokemon":
                    var pokemonName = data[2];
                    var type = data[3];
                    currentPerson.AddInCollection(new Pokemon(pokemonName, type));
                    break;
                case "parents":
                    var parentName = data[2];
                    var parentBirthDay = data[3];
                    currentPerson.AddInCollection(new Parent(parentName, parentBirthDay));
                    break;
                case "children":
                    var childName = data[2];
                    var childBirthDay = data[3];
                    currentPerson.AddInCollection(new Child(childName, childBirthDay));
                    break;
                case "car":
                    var model = data[2];
                    var speed = int.Parse(data[3]);
                    currentPerson.AssignACar(new Car(model, speed));
                    break;
                default:
                    break;
            }
        }
    }
}
