namespace _2.Salary_Increase
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

        public string FirstName { get { return this.firtsName; } }

        public int Age { get { return this.age; } }

        public void IncreaseSalary(double percent)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percent / 100;
            }
            else
            {
                this.salary += this.salary * percent / 200;
            }
        }


        public override string ToString()
        {
            return $"{this.firtsName} {this.lastName} get {this.salary:F2} leva";
        }
    }
}