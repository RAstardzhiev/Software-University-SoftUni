namespace _6.Animals
{
    using Animals;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var animals = GetAnimals();
            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }

        private static Queue<Animal> GetAnimals()
        {
            var animals = new Queue<Animal>();
            var kind = Console.ReadLine();

            while (kind != "Beast!")
            {
                var animalDetails = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var name = animalDetails[0];
                var age = int.Parse(animalDetails[1]);
                var gender = animalDetails[2];

                try
                {
                    var animal = AnimalFactory.GetAnimal(kind, name, age, gender);
                    animals.Enqueue(animal);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                kind = Console.ReadLine();
            }

            return animals;
        }
    }
}
