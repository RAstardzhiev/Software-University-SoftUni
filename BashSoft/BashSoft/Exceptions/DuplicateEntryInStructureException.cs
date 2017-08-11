namespace BashSoft.Exceptions
{
    using System;

    public class DuplicateEntryInStructureException : Exception
    {
        private const string DuplicateEntry = "The {0} already exists in {1}.";

        public DuplicateEntryInStructureException(string entry, string course) 
            : base(string.Format(DuplicateEntry, entry, course))
        {
        }

        public DuplicateEntryInStructureException(string message) 
            : base(message)
        {
        }
    }
}
