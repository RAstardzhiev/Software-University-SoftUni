namespace _01.Person
{
    using System;

    public class Child : Person
    {
        private const int MaxAge = 15;

        public Child(string name, int age) : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }

            set
            {
                if (value > MaxAge)
                {
                    throw new ArgumentException($"Child's age must be less than {MaxAge}!");
                }

                base.Age = value;
            }
        }
    }
}
