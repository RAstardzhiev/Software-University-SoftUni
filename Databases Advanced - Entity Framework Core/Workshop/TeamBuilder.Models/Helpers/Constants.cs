namespace TeamBuilder.Models.Helpers
{
    public class Constants
    {
        /* User */
        public const int UsernameMinLength = 3;
        public const int UsernameMaxLength = 25;
        public const int UserFirstNameMaxLength = 25;
        public const int UserLastNameMaxLength = 25;
        public const int UserAgeMinLength = 0;
        public const int UserAgeMaxLength = int.MaxValue;
        public const int PasswordMinLength = 6;
        public const int PasswordMaxLength = 30;

        /* Team */
        public const int TeamNameMaxLength = 25;
        public const int TeamDescriptionMaxLength = 32;
        public const int TeamAcronymExactLength = 3;

        /* Events */
        public const int EventNameMaxLength = 25;
        public const int EventDescriptionMaxLength = 250;

        public const int DefaultStringMinLength = 1;

        public const string PasswordMissingDigitExceptionMessage = "Password must contain at least one Digit!";
        public const string PasswordMissingUpperCaseExceptionMessage = "Password must contain at least one Upper Case Letter!";
        public const string StringInvalidLengthExceptionMessage = "{0} must be long between ({1}-{2})!";
        public const string IntegerRangeExceptionMessage = "{0} must be between ({1}-{2})!";
        public const string StartDateErrorExceptionMessage = "Wrong start date!";
    }
}
