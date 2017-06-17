namespace BashSoft
{
    using System;
    using System.Collections.Generic;

    class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int studentsToTake)
        {
            if (wantedFilter == "excellent")
            {
                FilterAndTake(wantedData, ExcelentFilter, studentsToTake);
            }
            else if (wantedFilter == "average")
            {
                FilterAndTake(wantedData, AverageFilter, studentsToTake);
            }
            else if (wantedFilter == "poor")
            {
                FilterAndTake(wantedData, PoorFilter, studentsToTake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentFilter);
            }
        }

        private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter, int studentsToTake)
        {
            int counterForPrinted = 0;

            foreach (var userName_Points in wantedData)
            {
                if (counterForPrinted == studentsToTake)
                {
                    break;
                }

                double averageMark = Average(userName_Points.Value);

                if (givenFilter(averageMark))
                {
                    OutputWriter.PrintStudent(userName_Points);
                    counterForPrinted++;
                }
            }
        }

        private static bool ExcelentFilter(double mark)
        {
            return mark >= 5.0;
        }

        private static bool AverageFilter(double mark)
        {
            return mark < 5.0 && mark >= 3.50;
        }

        private static bool PoorFilter(double mark)
        {
            return mark < 3.50;
        }

        private static double Average(List<int> scoresOnTaska)
        {
            int totalScore = 0;

            foreach (var score in scoresOnTaska)
            {
                totalScore += score;
            }

            var percentageOfAll = totalScore / scoresOnTaska.Count * 100;
            var mark = percentageOfAll * 4 + 2;

            return mark;
        }
    }
}
