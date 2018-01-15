namespace _9.Hospital_Database.Modles.Helpers
{
    using System;
    using System.Text.RegularExpressions;

    public class DataValidator
    {
        private const string PasswordValidationPattern = @"^[a-zA-Z0-9]{8,16}$";

        private const string InvalidIdExceptionMessage = "Id can not be less than 1";
        private const string InvalidPasswordExceptionMessage = "Password can contain only letters and digits and must be between 8 and 16 symbols";

        public void NullCheck(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException();
            }
        }

        public void NullCheck<T>(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
        }

        public void IdValidation(int? id)
        {
            if (id < 1)
            {
                throw new ArgumentException(InvalidIdExceptionMessage);
            }
        }

        public void PasswordValidation(string password)
        {
            if (!Regex.IsMatch(password, PasswordValidationPattern))
            {
                throw new ArgumentException(InvalidPasswordExceptionMessage);
            }
        }
    }
}
