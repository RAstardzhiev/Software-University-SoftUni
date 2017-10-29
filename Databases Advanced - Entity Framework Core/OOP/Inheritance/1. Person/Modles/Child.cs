namespace _1.Person.Modles
{
    using System;

    public class Child : Person
    {
        private string AgeTooBigExceptionMessage = "Child's age must be less than 15!";

        public Child(string name, int age) 
            : base(name, age)
        {
            this.Age = age;
        }

        public override int Age
        {
            get => base.Age;

            protected set
            {
                if (value > 15)
                {
                    throw new ArgumentException(AgeTooBigExceptionMessage);
                }

                base.Age = value;
            }
        }
    }
}
