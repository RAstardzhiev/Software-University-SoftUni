namespace BashSoft
{
    using System;
    using System.Collections.Generic;

    public class RepositoryFilter
    {
        public void FilterAndTake(Dictionary<string, double> studentsWithMarks, string wantedFilters, int studentsToTake)
        {
            if (wantedFilters == "excellent")
            {
               FilterAndTake(studentsWithMarks, x => x >= 5, studentsToTake); 
            }
            else if (wantedFilters == "average")
            {
                FilterAndTake(studentsWithMarks, x => x >= 3.5 && x < 5, studentsToTake);
            }
            else if (wantedFilters == "poor")
            {
                FilterAndTake(studentsWithMarks, x => x < 3.5, studentsToTake);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidStudentFilter);
            }
        }

        private void FilterAndTake(Dictionary<string, double> studentsWithMarks, Predicate<double> givenFilter, int studentsToTake)
        {
            int counter = 0;
            foreach (var username_score in studentsWithMarks)
            {
                if (counter == studentsToTake)
                    break;

                if (givenFilter(username_score.Value))
                {
                    OutputWriter.PrintStudent(username_score);
                    counter++;
                }
            }
        }
    }
}
