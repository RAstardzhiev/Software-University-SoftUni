namespace BashSoft
{
    public class Launcher
    {
        public static void Main()
        {
            StudentsRepository.InitializeData();
            // StudentsRepository.GetAllStudentsFromCourse("Unity");
            StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
        }
    }
}
