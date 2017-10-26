namespace _1.Define_a_class_Person
{
public    class Person
    {
        private const string DefaultName = "No name";
        private const int DefaultAge = 1;

        public Person()
            : this(DefaultName, DefaultAge)
        {
        }

        public Person(int age)
            : this(DefaultName, age)
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
