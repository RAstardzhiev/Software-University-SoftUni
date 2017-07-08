namespace _3.Wild_farm
{
    using Animals;
    using Foods;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            FeedAnimals();
        }

        private static void FeedAnimals()
        {
            var animalDetails = Console.ReadLine().Split().Where(s => s != string.Empty).ToArray();

            while (animalDetails[0] != "End")
            {
                var animal = SetAnimal(animalDetails);

                var foodDetails = Console.ReadLine().Split().Where(s => s != string.Empty).ToArray();
                var food = SetFood(foodDetails);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Eat(food);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                Console.WriteLine(animal);

                animalDetails = Console.ReadLine().Split().Where(s => s != string.Empty).ToArray();
            }
        }

        private static Food SetFood(string[] foodDetails)
        {
            switch (foodDetails[0])
            {
                case "Vegetable":
                    return new Vegetable(int.Parse(foodDetails.Last()));
                case "Meat":
                    return new Meat(int.Parse(foodDetails.Last()));
                default:
                    return null;
            }
        }

        private static Animal SetAnimal(string[] animalDetails)
        {
            var type = animalDetails[0];
            var name = animalDetails[1];
            var weight = double.Parse(animalDetails[2]);
            var livingRegion = animalDetails[3];

            switch (type)
            {
                case "Mouse":
                    return new Mouse(name, type, weight, livingRegion);
                case "Zebra":
                    return new Zebra(name, type, weight, livingRegion);
                case "Cat":
                    var breed = animalDetails[4];
                    return new Cat(name, type, weight, livingRegion, breed);
                case "Tiger":
                    return new Tiger(name, type, weight, livingRegion);
                default:
                    return null;
            }
        }
    }
}
