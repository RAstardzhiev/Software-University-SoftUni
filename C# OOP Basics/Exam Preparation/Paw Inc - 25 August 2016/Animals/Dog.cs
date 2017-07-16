namespace Paw_Inc___25_August_2016.Animals
{
    public class Dog : Animal
    {
        private int amountOfCommands;

        public Dog(string name, int age, int amountOfCommands) : base(name, age)
        {
            this.amountOfCommands = amountOfCommands;
        }
    }
}
