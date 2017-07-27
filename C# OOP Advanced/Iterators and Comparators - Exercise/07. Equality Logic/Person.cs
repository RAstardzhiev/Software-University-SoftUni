namespace _07.Equality_Logic
{
    using System;

    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.age = value;
            }
        }

        public int CompareTo(Person other)
        {
            var comparison = this.Name.CompareTo(other.Name);

            return comparison == 0
                ? this.Age.CompareTo(other.Age)
                : comparison;
        }
    }
}
