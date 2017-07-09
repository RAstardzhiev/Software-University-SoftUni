namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RepositorySorter
    {
        public void OrderAndTake(Dictionary<string, double> studentsWithMarks, string comparison, int studentToTake)
        {
            comparison = comparison.ToLower();

            if (comparison == "ascending")
            {
                PrintStudents(studentsWithMarks.OrderBy(x => x.Value)
                    .Take(studentToTake)
                    .ToDictionary(pair => pair.Key, kvp => kvp.Value));
            }
            else if (comparison == "descending")
            {
                PrintStudents(studentsWithMarks.OrderByDescending(x => x.Value)
                    .Take(studentToTake)
                    .ToDictionary(pair => pair.Key, kvp => kvp.Value));
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private void PrintStudents(Dictionary<string, double> studentsWithMarks)
        {
            foreach (var kvp in studentsWithMarks)
            {
                OutputWriter.PrintStudent(kvp);
            }
        }
    }
}
