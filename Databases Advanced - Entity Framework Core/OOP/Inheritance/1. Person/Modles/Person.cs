namespace _1.Person.Modles
{
    using System;
    using Interfaces;

    public class Person : IPerson
    {
        private string NameTooShorExceptionMessage = "Name's length should not be less than 3 symbols!";
        private string NegativeAgeExceptionMessage = "Age must be positive!";

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(NameTooShorExceptionMessage);
                }

                this.name = value;
            }
        }

        public virtual int Age
        {
            get => this.age;

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(NegativeAgeExceptionMessage);
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
