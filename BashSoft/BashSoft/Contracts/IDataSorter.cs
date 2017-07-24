namespace BashSoft.Contracts
{
    using System.Collections.Generic;

    public interface IDataSorter
    {
        void OrderAndTake(Dictionary<string, double> studentsWithMark, string comparison, int studentsToTake);

        void PrintStudents(Dictionary<string, double> studentsSorted);
    }
}
