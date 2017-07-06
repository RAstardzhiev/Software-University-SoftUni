namespace _01.Person
{
    using System;

    public class Person
    {
        private const int MinAge = 0;
        private const int AllowedNameLengthAbove = 3;

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < MinAge)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < AllowedNameLengthAbove)
                {
                    throw new ArgumentException($"Name's length should not be less than {AllowedNameLengthAbove} symbols!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
