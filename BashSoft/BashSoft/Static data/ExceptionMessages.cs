namespace BashSoft
{
    public static class ExceptionMessages
    {
        public const string DataAlreadyInitialisedException = "Data is already initialized!";
        public const string InexistingCourseInDataBase = "The course you are trying to get does not exist in the data base!";
        public const string InexistingStudentInDataBase = "The user name for the student you are trying to get does not exist!";
        public const string UnauthorizedAccessExceptionMessage = "The folder/file you are trying to get access needs a higher level of rights than you currently have.";
        public const string ComparisonOfFilesWithDifferentSizes = "Files not of equal size, certain mismatch.";
        public const string UnableToGoHigherInPartitionHierarchy = "Impossible operation. There is no higher folder than current one.";
        // public const string UnableToParseNumber = "The sequence you've written is not a valid number.";
        // public const string InvalidTakeQuantityParameter = "The take command expected does not match the format wanted!";
        public const string NullOrEmptyValue = "The value of the variable CANNOT be null or empty!";
        public const string InvalidScores = "The number for the score you've entered is not in the range of 0 - 100";
        public const string InvalidNumberOfScores = "The number of scores for the given course is greater than the possible.";
    }
}
