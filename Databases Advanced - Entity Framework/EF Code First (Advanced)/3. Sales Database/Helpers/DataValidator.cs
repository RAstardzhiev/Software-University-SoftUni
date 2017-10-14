namespace _3.Sales_Database.Helpers
{
    using System;

    public class DataValidator
    {
        private const string EmptyStringExceptionMessage = "{0} must have {1}!";
        private const string StringMoreThanMaxLengthExceptionMessage = "{0} must be no more than {1} symbols!";
        private const string StringLessThanMinLengthExceptionMessage = "{0} cannot be less than {1} symbols!";
        private const string NegativeNumberExceptionMessage = "{0} cannot be less than zero!";
        private const string IdLessThanOneExceptionMessage = "Id must be greater than 0";

        public void StringExistenceValidation(string value, string objName, string propName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(EmptyStringExceptionMessage, nameof(objName), nameof(propName)));
            }
        }

        public void StringMaxLengthValidator(string value, int maxLength, string propName)
        {
            if (value != null && value.Length > maxLength)
            {
                throw new ArgumentException(string.Format(StringMoreThanMaxLengthExceptionMessage, propName, maxLength));
            }
        }

        public void StringMinLengthValidator(string value, int minLength, string propName)
        {
            if (value != null && value.Length < minLength)
            {
                throw new ArgumentException(string.Format(StringLessThanMinLengthExceptionMessage, propName, minLength));
            }
        }

        public void NummericNonNegativeValidation(double value, string propName)
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(NegativeNumberExceptionMessage, nameof(propName)));
            }
        }

        public void NummericNonNegativeValidation(decimal value, string propName)
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(NegativeNumberExceptionMessage, nameof(propName)));
            }
        }

        public void NummericNonNegativeValidation(int? value, string propName)
        {
            if (value < 0)
            {
                throw new ArgumentException(string.Format(NegativeNumberExceptionMessage, nameof(propName)));
            }
        }

        public void IdGreaterThanZeroValidation(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(IdLessThanOneExceptionMessage);
            }
        }
    }
}
