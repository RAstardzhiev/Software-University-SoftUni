namespace _6.Animals.Animals
{
    using Kinds;
    using System;

    public class AnimalFactory
    {
        public static Animal GetAnimal(string kind, string name, int age, string gender = null)
        {
            switch (kind)
            {
                case "Dog":
                    return new Dog(name, age, gender);
                case "Cat":
                    return new Cat(name, age, gender);
                case "Frog":
                    return new Frog(name , age, gender);
                case "Kitten":
                    return new Kitten(name, age);
                case "Tomcat":
                    return new Tomcat(name, age);
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
