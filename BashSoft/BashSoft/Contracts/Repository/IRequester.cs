namespace BashSoft.Contracts.Repository
{
    public interface IRequester
    {
        void GetStudentScoresFromCourse(string courseName, string username);

        void GetAllStudentsFromCourse(string courseName);
    }
}
