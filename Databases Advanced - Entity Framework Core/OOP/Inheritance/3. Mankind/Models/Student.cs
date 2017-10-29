namespace _3.Mankind.Models
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private const string InvalidFacultyNumberLengthExceptionMessage = "Invalid faculty number!";

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => this.facultyNumber;

            set
            {
                // Length Validation
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException(InvalidFacultyNumberLengthExceptionMessage);
                }

                // Symbol Validation
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]) && !char.IsLetter(value[i]))
                    {
                        throw new ArgumentException(InvalidFacultyNumberLengthExceptionMessage);
                    }
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}")
                .AppendLine($"Faculty number: {this.facultyNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
