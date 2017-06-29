namespace _4.First_and_Reserve_Team
{
    public class Person
    {
        private string firtsName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firtsName, string lastName, int age, double salary)
        {
            this.firtsName = firtsName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public int Age { get { return this.age; } }
    }
}