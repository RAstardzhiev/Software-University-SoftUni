namespace _02.Creating_Constructors
{
    using System;

    public class Person
    {
        private string name;
        private int age;

        public Person() : this("No name", 1) { }

        public Person(int age) : this("No name", age) { }

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Invalid name");
            }

            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Age
        {
            get { return this.age; }
        }
    }
}
