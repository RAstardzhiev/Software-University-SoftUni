namespace BashSoft
{
    using System.Collections.Generic;
    using System.Linq;

    class RepositorySorters
    {
        public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentToTake)
        {
            comparison = comparison.ToLower();

            if (comparison == "ascending")
            {
                PrintStudents(wantedData.OrderBy(x => x.Value
                    .Sum())
                    .Take(studentToTake)
                    .ToDictionary(pair => pair.Key, kvp => kvp.Value));
            }
            else if (comparison == "descending")
            {
                PrintStudents(wantedData.OrderByDescending(x => x.Value
                    .Sum())
                    .Take(studentToTake)
                    .ToDictionary(pair => pair.Key, kvp => kvp.Value));
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private static void PrintStudents(Dictionary<string, List<int>> studentsSorted)
        {
            foreach (var kvp in studentsSorted)
            {
                OutputWriter.PrintStudent(kvp);
            }
        }
    }
}
