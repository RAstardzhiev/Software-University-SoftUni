namespace _2.Animals
{
    using System;

    internal class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return $"{base.ExplainMyself()} {Environment.NewLine}MEEOW";
        }
    }
}