namespace TeamBuilder.Models.Helpers
{
    using System;
    using System.Linq;

    public class Validator
    {
        public static void StringContainsValidation(string value, string errorMessage, Func<char, bool> mustHaveFunc)
        {
            var arr = value.ToCharArray();
            if (arr.Any(mustHaveFunc))
            {
                return;
            }

            throw new ArgumentException(errorMessage);
        }

        public static void StringLengthValidation(string value, int minLength, int maxLength, string propertyName)
        {
            if (value.Length >= minLength && value.Length <= maxLength)
            {
                return;
            }

            var errorMessage = string.Format(Constants.StringInvalidLengthExceptionMessage,
                propertyName,
                minLength,
                maxLength);

            throw new ArgumentException(errorMessage);
        }

        internal static void IntegerRangeValidation(int? value, string propertyName, int minValue, int maxValue)
        {
            if (value == null || (value >= minValue && value <= maxValue))
            {
                return;
            }

            var errorMessage = string.Format(Constants.IntegerRangeExceptionMessage,
                propertyName, 
                minValue, 
                maxValue);

            throw new ArgumentException(errorMessage);
        }
    }
}
