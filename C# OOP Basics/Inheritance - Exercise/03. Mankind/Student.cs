namespace _03.Mankind
{
    using System;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private const int FacNumMinLength = 5;
        private const int FacNumMaxLength = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private string FacultyNumber
        {
            set
            {
                if (value.Length < FacNumMinLength || value.Length > FacNumMaxLength || 
                    !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString())
                .AppendLine($"Faculty number: {this.facultyNumber}");

            return sb.ToString();
        }
    }
}
