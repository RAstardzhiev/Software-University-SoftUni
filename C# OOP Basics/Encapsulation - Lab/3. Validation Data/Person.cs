namespace _3.Validation_Data
{
    using System;

    public class Person
    {
        private string firtsName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firtsName, string lastName, int age, double salary)
        {
            this.FirstName = firtsName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firtsName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }

                this.firtsName = value;
            }
        }

        public string LastName
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }

                this.age = value;
            }
        }

        public double Salary
        {
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }

                this.salary = value;
            }
        }

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