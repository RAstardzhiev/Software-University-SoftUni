namespace _3.Mankind.Models
{
    using System;

    public class Human
    {
        private const string FirstNameMustStartWithCapitalLetterExceptionMessage = "Expected upper case letter! Argument: firstName";
        private const string FirstNameTooShortExceptionMessage = "Expected length at least 4 symbols! Argument: firstName";
        private const string LastNameMustStartWithCapitalLetterExceptionMessage = "Expected upper case letter! Argument: lastName";
        private const string LastNameTooShortExceptionMessage = "Expected length at least 3 symbols! Argument: lastName";
        
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => this.firstName;

            private set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException(FirstNameMustStartWithCapitalLetterExceptionMessage);
                }

                if (value.Length <= 3)
                {
                    throw new ArgumentException(FirstNameTooShortExceptionMessage);
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;

            private set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException(LastNameMustStartWithCapitalLetterExceptionMessage);
                }

                if (value.Length <= 2)
                {
                    throw new ArgumentException(LastNameTooShortExceptionMessage);
                }

                this.lastName = value;
            }
        }
    }
}
